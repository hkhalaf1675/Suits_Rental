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

        private bool Make(OrderDto order)
        {
            context.Orders.Add(new Models.Order
            {
                Date = order.Date,
                Type = order.Type,
                CustomerId = order.CustomerId,
                RentDays = order.RentDays,
                TotalPrice = order.TotalPrice,
                PaidAmount = order.PaidAmount,
                RemainAmount = order.RemainAmount,
                ItemsCount = order.SuitsDto.Count,
                BetAttachment = order.BetAttachment,
                Discount = order.Discount,
                UserName = order.UserName,
                Notes = order.Notes,
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

            foreach (var suit in order.SuitsDto)
            {
                context.SuitOrders.Add(new Models.SuitOrder
                {
                    SuitId = suit.Id,
                    OrderId = Convert.ToInt32(orderId)
                });

                var orderSuit = context.Suits.Where(S => S.Id == suit.Id).FirstOrDefault();
                if (orderSuit != null)
                {
                    if(orderSuit.AvailableCounter > 0)
                    {
                        orderSuit.AvailableCounter--;
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

                var suitOrderId = context.SuitOrders.OrderByDescending(SO => SO.Id).FirstOrDefault()?.Id;
                if (suitOrderId == null)
                {
                    continue;
                }
                foreach(var item in order.AttachmentsSizes)
                {
                    var attachmentSize = context.Attachment_Sizes.FirstOrDefault(AS => AS.Id == item.SizeId);
                    if(attachmentSize == null)
                    {
                        continue;
                    }
                    attachmentSize.AvailableStatus = false;
                    context.OrderAttachmentSizes.Add(new OrderAttachmentSize
                    {
                        AttachmentId = item.AttachmentId,
                        AttachmentSizeId = item.SizeId,
                        SuitOrderId = Convert.ToInt32(suitOrderId)
                    });

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
            return true;
        }

        public OrderReadDto GetById(int orderId)
        {
            var order = context.Orders
                .Include(O => O.OrderSuits)
                .ThenInclude(OS => OS.OrderAttachmentSizes)
                .ThenInclude(OAS => OAS.Attachment_Size)
                .Include(O => O.Customer)
                .Where(O => O.Id == orderId)
                .FirstOrDefault();
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
            order.CustomerId = Convert.ToInt32(customerId);

            bool checkAddOrder = Make(order);

            if(!checkAddOrder)
            {
                return false;
            }

            return true;
        }

        public bool MakeWithOldCustomer(OrderDto order)
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
            var order = context.Orders
                .Include(O => O.OrderSuits)
                .ThenInclude(SO => SO.OrderAttachmentSizes)
                .Where(O => O.Id == orderId)
                .FirstOrDefault();
            if (order != null)
            {
                order.Status = true;
                order.PaidAmount = order.TotalPrice;
                order.RemainAmount = 0;

                foreach(var orderSuit in order.OrderSuits)
                {
                    foreach(var item in orderSuit.OrderAttachmentSizes)
                    {
                        var attachmentSize = context.Attachment_Sizes
                            .FirstOrDefault(AS => AS.Id == item.AttachmentSizeId);

                        if(attachmentSize != null)
                        {
                            attachmentSize.AvailableStatus = true;
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
                    var suit = context.Suits
                        .FirstOrDefault(S => S.Id == orderSuit.SuitId);
                    if(suit != null)
                    {
                        suit.AvailableCounter += 1;
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
            var order = context.Orders
                .Include(O => O.OrderSuits)
                .ThenInclude(OS => OS.OrderAttachmentSizes)
                .ThenInclude(OAS => OAS.Attachment_Size)
                .FirstOrDefault(O => O.Id == orderId);

            if(order == null)
            {
                return false;
            }

            foreach(var orderSuit in order.OrderSuits)
            {
                if(orderSuit is null)
                {
                    continue;
                }
                foreach(var size in orderSuit.OrderAttachmentSizes)
                {
                    if(size is null)
                    {
                        continue;
                    }
                    size.Attachment_Size.AvailableStatus = true;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                var suit = context.Suits
                    .FirstOrDefault(S => S.Id == orderSuit.SuitId);
                if(suit is null)
                {
                    continue;
                }
                suit.AvailableCounter++;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            context.SuitOrders.RemoveRange(order.OrderSuits);
            context.Orders.Remove(order);
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
    }
}
