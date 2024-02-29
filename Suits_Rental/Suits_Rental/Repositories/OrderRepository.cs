using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Dtos;
using Suits_Rental.IRepositories;
using Suits_Rental.Models;
using Suits_Rental.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext context;
        private readonly ICustomerRepository customerRepository;
        public OrderRepository()
        {
            context = new ApplicationDbContext();
            customerRepository = new CustomerRepository();
        }

        private bool Make(OrderWriteWithOutCustomerDto order)
        {
            context.Orders.Add(new Models.Order
            {
                Date = DateTime.UtcNow,
                Type = order.Type,
                CustomerId = order.CustomerId,
                RentDays = order.RentDays,
                TotalPrice = order.TotalPrice,
                PaidAmount = order.PaidAmount,
                RemainAmount = order.RemainAmount,
                ItemsCount = order.SuitsIDs.Count,
                BetAttachment = order.BetAttachment,
                Discount = order.Discount,
                UserName = order.UserName
            });

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            int? orderId = context.Orders.OrderByDescending(o => o.Id).FirstOrDefault()?.Id;
            if (orderId == null)
            {
                return false;
            }

            foreach (int suitId in order.SuitsIDs)
            {
                context.SuitOrders.Add(new Models.SuitOrder
                {
                    SuitId = suitId,
                    OrderId = Convert.ToInt32(orderId)
                });

                var orderSuit = context.Suits.Where(S => S.Id == suitId).FirstOrDefault();
                if (orderSuit != null)
                {
                    if(orderSuit.AvaibableCounter > 0)
                    {
                        orderSuit.AvaibableCounter--;
                    }
                }
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        public OrderReadDto GetById(int orderId)
        {
            var order = context.Orders.Include(O => O.Customer).Where(O => O.Id == orderId).FirstOrDefault();
            if(order == null)
            {
                return null;
            }
            else
            {
                return Mapping.OrderToReadDto(order);
            }
        }

        public bool MakeWithNewCustomer(OrderDto order)
        {
            bool checkAddCustomer = customerRepository.AddNew(new Models.Customer
            {
                Name = order.CustomerName,
                Address = order.Address,
                Phone = order.PhoneNumber
            });

            if(!checkAddCustomer)
            {
                return false;
            }

            int? customerId = customerRepository.GetLast();
            if(customerId == null)
            {
                return false;
            }

            bool checkAddOrder = Make(Mapping.FromOrderDto(Convert.ToInt32(customerId),order));

            if(!checkAddOrder)
            {
                return false;
            }

            return true;
        }
        public bool MakeWithOldCustomer(OrderWriteWithOutCustomerDto order)
        {
            bool checkAddOrder = Make(order);
            if (!checkAddOrder)
            {
                return false;
            }

            return true;
        }

        public InvoiceDto GetInvoice(int orderId)
        {
            InvoiceDto invoice;

            var order = context.Orders
                .Include(O => O.Customer)
                .Where(O => O.Id == orderId)
                .FirstOrDefault();
            if(order != null)
            {
                invoice = Mapping.OrderToInvoice(order);
            }
            else
            {
                invoice = null;
            }

            return invoice;
        }

        public bool GetRemainAmount(int orderId)
        {
            var order = context.Orders.Where(O => O.Id == orderId).FirstOrDefault();
            if(order != null)
            {
                order.PaidAmount = order.TotalPrice;
                order.RemainAmount = 0;

                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch(Exception ex) 
                { 
                    return false;
                }
            }
            return false;
        }

        public bool ReturnOrderSuits(int orderId)
        {
            var order = context.Orders.Where(O => O.Id == orderId).FirstOrDefault();
            if (order != null)
            {
                order.Status = true;
                order.PaidAmount = order.TotalPrice;
                order.RemainAmount = 0;

                var orderSuits = context.SuitOrders.Where(SO => SO.OrderId == orderId).ToList();
                foreach(var orderSuit in orderSuits)
                {
                    var suit = context.Suits.Where(S => S.Id == orderSuit.SuitId).FirstOrDefault();
                    if(suit != null)
                    {
                        suit.AvaibableCounter += 1;
                        try
                        {
                            context.SaveChanges();
                        }
                        catch(Exception ex)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public List<OrderReadDto> GetAll()
        {
            List<OrderReadDto> orderReadDtos = new List<OrderReadDto>();
            var orders = context.Orders
                .Include(O => O.Customer)
                .OrderByDescending(O => O.Date)
                .Take(20)
                .ToList();
            if(orders != null)
            {
                foreach (var order in orders)
                {
                    if (order != null)
                    {
                        orderReadDtos.Add(Mapping.OrderToReadDto(order));
                    }
                }
            }
            return orderReadDtos;
        }

        public List<OrderReadDto> GetUnreturned()
        {
            List<OrderReadDto> orderReadDtos = new List<OrderReadDto>();
            var orders = context.Orders.Include(O => O.Customer).Where(O => O.Status == false).OrderByDescending(O => O.Date).ToList();
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    if (order != null)
                    {
                        orderReadDtos.Add(Mapping.OrderToReadDto(order));
                    }
                }
            }
            return orderReadDtos;
        }

        public List<OrderReadDto> GetReport(DateTime start, DateTime end)
        {
            List<OrderReadDto> orderReadDtos = new List<OrderReadDto>();

            var orders = context.Orders
                .Include(O => O.Customer)
                .Where(O => O.Date >= start && O.Date <= end)
                .OrderByDescending(O => O.Date)
                .ToList();

            foreach (var order in orders)
            {
                orderReadDtos.Add(Mapping.OrderToReadDto(order));
            }

            return orderReadDtos;
        }
        public int GetLastOrderId()
        {
            return context.Orders
                .OrderByDescending(O => O.Id)
                .ToList()[0].Id;
        }
        public bool Delete(int orderId)
        {
            var order = context.Orders.FirstOrDefault(O => O.Id == orderId);
            if(order != null)
            {
                var orderSuits = context.SuitOrders
                    .Include(SO => SO.Suit)
                    .Where(SO => SO.OrderId == orderId)
                    .ToList();
                foreach(var suit in orderSuits)
                {
                    if(suit.Suit != null)
                    {
                        suit.Suit.AvaibableCounter += 1;
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                    }
                }

                context.SuitOrders.RemoveRange(orderSuits);
                context.Orders.Remove(order);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
