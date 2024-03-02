using Suits_Rental.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Events
{
    public class DataEventArgs:EventArgs
    {
        public List<AttachmentSizesDto> AttachmentSizesDtos { get; set; }

        public DataEventArgs(List<AttachmentSizesDto> sizesDtos)
        {
            AttachmentSizesDtos = sizesDtos;
        }
    }
}
