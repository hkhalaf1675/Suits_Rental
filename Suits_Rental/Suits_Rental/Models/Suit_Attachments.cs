using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Models
{
    public class Suit_Attachments
    {
        public int Id { get; set; }
        public string? AttachmentName { get; set; }
        public string? Notes { get; set; }
        [ForeignKey("Suit")]
        public int SuitId { get; set; }
        public Suit Suit { get; set; }
        public List<Attachment_Sizes> Attachment_Sizes { get; set; }
        public List<OrderAttachmentSize> OrderAttachmentSizes { get; set; }

        public override string ToString()
        {
            return $"{AttachmentName} البدلة رقم {SuitId}";
        }
    }
}
