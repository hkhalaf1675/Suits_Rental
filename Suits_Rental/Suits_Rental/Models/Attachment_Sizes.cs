using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Models
{
    public class Attachment_Sizes
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public Status AvailableStatus { get; set; }
        [ForeignKey("Attachment")]
        public int AttachmentId { get; set; }
        public Suit_Attachments Attachment { get; set; }
        public List<OrderAttachmentSize> OrderAttachmentSizes { get; set; }

        public override string ToString()
        {
            return $"{Attachment.AttachmentName} البدلة رقم {Attachment.SuitId} مقاس {Size}";
        }
    }
}
