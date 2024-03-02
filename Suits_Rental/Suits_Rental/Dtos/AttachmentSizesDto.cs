using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Dtos
{
    public class AttachmentSizesDto
    {
        public int SuitId { get; set; }
        public int AttachmentId { get; set; }
        public string AttachmentName { get; set; }
        public int SizeId { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return $"البدلة رقم {SuitId} {AttachmentName} مقاس {Size}";
        }
    }
}
