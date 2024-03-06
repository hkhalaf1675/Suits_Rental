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
        public int AvailableCounter { get; set; } = 8;
        public decimal? RentalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int Size1 { get; set; }
        public int Size2 { get; set; }
        public int Size3 { get; set; }
        public int Size4 { get; set; }
        public int Size5 { get; set; }
        public int Size6 { get; set; }
        public int Size7 { get; set; }
        public int Size8 { get; set; }
        public List<Suit_Attachments> Attachments { get; set; }
        public List<SuitOrder> OrderSuits { get; set; }
    }
}
