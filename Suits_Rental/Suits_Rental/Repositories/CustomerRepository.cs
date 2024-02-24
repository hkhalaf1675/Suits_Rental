using Suits_Rental.Contexts;
using Suits_Rental.IRepositories;
using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext context;
        public CustomerRepository()
        {
            context = new ApplicationDbContext();
        }
        public bool AddNew(Customer customer)
        {
           context.Customers.Add(customer);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int? GetLast()
        {
            return context.Customers.OrderByDescending(c => c.Id).FirstOrDefault()?.Id;
        }
    }
}
