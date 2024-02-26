using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.IRepositories
{
    public interface ICustomerRepository
    {
        bool AddNew(Customer customer);
        int? GetLast();
        List<Customer> GetLastTen();
        List<Customer> SearchByName(string name);
    }
}
