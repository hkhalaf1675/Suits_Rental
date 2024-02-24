using Suits_Rental.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.IRepositories
{
    public interface IOrderRepository
    {
        bool Make(OrderDto order);
    }
}
