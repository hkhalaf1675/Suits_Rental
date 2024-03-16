using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Models
{
    public class SuitBook
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReturnDate { get; set; }
        [ForeignKey("SuitSize")]
        public int SuitSizeId { get; set; }
        public SuitSize SuitSize { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public List<OrderAttachmentSize> OrderAttachmentSizes { get; set; }

    }
}
