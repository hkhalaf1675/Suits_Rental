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

        public List<Customer> GetLastTen()
        {
            return context.Customers
                .OrderByDescending(C => C.Id)
                .Take(10).ToList();
        }

        public int? GetLast()
        {
            return context.Customers
                .OrderByDescending(c => c.Id)
                .FirstOrDefault()?.Id;
        }

        public List<Customer> SearchByName(string name)
        {
            return context.Customers
                .Where(C => C.Name.Contains(name) || C.Name == name)
                .ToList();
        }
    }
}
