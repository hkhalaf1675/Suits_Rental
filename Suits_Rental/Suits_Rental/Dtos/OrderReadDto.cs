using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Dtos
{
    public class OrderReadDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int ItemsCount { get; set; }
        public int RentDays { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal RemainAmount { get; set; }
        public string BetAttachment { get; set; }
    }
}
