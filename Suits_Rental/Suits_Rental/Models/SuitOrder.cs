using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Models
{
    public class SuitOrder
    {
        public int Id { get; set; }
        [ForeignKey("Suit")]
        public int? SuitId { get; set; }
        public Suit? Suit { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal? Price { get; set; }
    }
}
