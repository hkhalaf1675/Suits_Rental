using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Dtos
{
    public class InvoiceDto
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string CustomerName { get; set; }
        public int ItemsCount { get; set; }
        public string OrderType { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainAmount { get; set; }
    }
}
