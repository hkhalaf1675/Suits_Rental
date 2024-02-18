using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Models
{
    public class Suit
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public bool AvailableStatus { get; set; } = true;
        public decimal? RentalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public List<Suit_Attachments> Attachments { get; set; }
    }
}
