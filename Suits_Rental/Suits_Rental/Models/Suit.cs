﻿using System;
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
        public int AvaibableCounter { get; set; } = 8;
        public decimal? RentalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public List<Suit_Attachments> Attachments { get; set; }
        public List<SuitOrder> OrderSuits { get; set; }
    }
}
