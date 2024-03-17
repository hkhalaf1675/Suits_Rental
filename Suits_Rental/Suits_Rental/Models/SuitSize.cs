using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Models
{
    public class SuitSize
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public Status AvailableStatus { get; set; }
        [ForeignKey("Suit")]
        public int SuitId { get; set; }
        public Suit Suit { get; set; }
        public List<SuitBook> SuitBooks { get; set; }

        public override string ToString()
        {
            return $"{Size}";
        }
    }
}
