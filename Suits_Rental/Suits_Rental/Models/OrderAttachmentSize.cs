using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Models
{
    public class OrderAttachmentSize
    {
        public int Id { get; set; }
        [ForeignKey("SuitBook")]
        public int SuitBookId { get; set; }
        public SuitBook SuitBook { get; set; }
        [ForeignKey("Attachment_Size")]
        public int? AttachmentSizeId { get; set; }
        public Attachment_Sizes? Attachment_Size { get; set; }
    }
}
