using Suits_Rental.Contexts;
using Suits_Rental.Dtos;
using Suits_Rental.IRepositories;
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
    }
}
