using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Dtos;
using Suits_Rental.IRepositories;
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

        public bool Make(OrderDto order)
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

            context.Orders.Add(new Models.Order
            {
                Date = DateTime.UtcNow,
                Type = order.Type,
                CustomerId = Convert.ToInt32(customerId),
                RentDays = order.RentDays,
                TotalPrice = order.TotalPrice,
                PaidAmount = order.PaidAmount,
                RemainAmount = order.RemainAmount,
                ItemsCount = order.SuitsIDs.Count,
                BetAttachment = order.BetAttachment
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
            if(orderId == null)
            {
                return false;
            }

            foreach(int suitId in order.SuitsIDs)
            {
                context.SuitOrders.Add(new Models.SuitOrder
                {
                    SuitId = suitId,
                    OrderId = Convert.ToInt32(orderId)
                });

                var orderSuit = context.Suits.Where(S => S.Id == suitId).FirstOrDefault();
                if(orderSuit != null)
                {
                    orderSuit.AvailableStatus = false;
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

        public InvoiceDto GetLastInvoice()
        {
            InvoiceDto lastInvoice;

            var lastOrder = context.Orders.Include(O => O.Customer).OrderByDescending(O => O.Id).FirstOrDefault();
            if(lastOrder != null)
            {
                lastInvoice = Mapping.OrderToInvoice(lastOrder);
            }
            else
            {
                lastInvoice= null;
            }

            return lastInvoice;
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
                var orderSuits = context.SuitOrders.Where(SO => SO.OrderId == orderId).ToList();
                foreach(var orderSuit in orderSuits)
                {
                    var suit = context.Suits.Where(S => S.Id == orderSuit.SuitId).FirstOrDefault();
                    if(suit != null)
                    {
                        suit.AvailableStatus = true;
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
            var orders = context.Orders.Include(O => O.Customer).OrderByDescending(O => O.Date).ToList();
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
    }
}
