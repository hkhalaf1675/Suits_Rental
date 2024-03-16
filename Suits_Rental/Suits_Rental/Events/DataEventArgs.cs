using Suits_Rental.Dtos;
using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Events
{
    public class DataEventArgs:EventArgs
    {
        public List<Attachment_Sizes> Attachment_Sizes { get; set; }

        public DataEventArgs(List<Attachment_Sizes> attachment_Sizes)
        {
            Attachment_Sizes = attachment_Sizes;
        }
    }
}
