using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Dtos
{
    public class SuitDto
    {
        public int Id { get; set; }
        public int SuitSize { get; set; }
        public decimal? RentalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public List<SuitAttachmentDto?>? SuitAttachments { get; set; }
    }
}
