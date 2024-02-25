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
        OrderReadDto GetById(int orderId);
        bool Make(OrderDto order);
        InvoiceDto GetLastInvoice();
        List<OrderReadDto> GetUnReturnedSuits();
        bool GetRemainAmount(int orderId);
        bool ReturnOrderSuits(int orderId);
    }
}
