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
        public int? Size { get; set; }
        public string? Notes { get; set; }
        [ForeignKey("Suit")]
        public int SuitId { get; set; }
        public Suit Suit { get; set; }
    }
}
