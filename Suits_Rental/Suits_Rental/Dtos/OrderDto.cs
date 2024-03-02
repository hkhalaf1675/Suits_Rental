using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Dtos
{
    public class OrderDto
    {
        public string Type { get; set; }
        public int RentDays { get; set; }
        public List<SuitReadDto> SuitsDto { get; set; }
        public List<AttachmentSizesDto> AttachmentsSizes { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainAmount { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BetAttachment { get; set; }
        public string UserName { get; set; }
        public int Discount { get; set; }
        public string Notes { get; set; }
    }
}
