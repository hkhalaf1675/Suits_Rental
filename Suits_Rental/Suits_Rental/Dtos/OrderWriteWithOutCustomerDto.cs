using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Dtos
{
    public class OrderWriteWithOutCustomerDto
    {
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public int RentDays { get; set; }
        public List<int> SuitsIDs { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainAmount { get; set; }
        public string BetAttachment { get; set; }
    }
}
