using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Core
{
    public class FormState
    {
        static Form previousPage;

        public static Form PreviousPage
        {
            get
            {
                return previousPage;
            }
            set
            {
                previousPage = value;
            }
        }
    }
}
