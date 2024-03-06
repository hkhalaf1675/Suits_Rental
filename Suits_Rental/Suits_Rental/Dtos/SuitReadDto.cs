using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Dtos
{
    public class SuitReadDto
    {
        public int Id { get; set; }
        public decimal? RentalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int AttachmentsCount { get; set; }
        public int AvailableCount { get; set; }

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
