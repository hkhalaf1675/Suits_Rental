using Suits_Rental.Dtos;
using Suits_Rental.Models;
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
        bool MakeWithNewCustomer(OrderDto order);
        bool MakeWithOldCustomer(OrderWriteWithOutCustomerDto order);
        InvoiceDto GetInvoice(int orderId);
        List<OrderReadDto> GetAll();
        bool GetRemainAmount(int orderId);
        bool ReturnOrderSuits(int orderId);
        List<OrderReadDto> GetUnreturned();
        List<OrderReadDto> GetReport(DateTime start, DateTime end);
        int GetLastOrderId();
        bool Delete(int orderId);
    }
}
