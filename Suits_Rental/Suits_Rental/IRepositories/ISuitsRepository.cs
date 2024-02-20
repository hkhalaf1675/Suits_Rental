using Suits_Rental.Dtos;
using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.IRepositories
{
    public interface ISuitsRepository
    {
        int GetAvailableSuits();
        int GetOutsideSuits();
        bool AddNew(SuitDto suit);
        bool Update(int id,SuitDto suit);
        bool Delete(int id);
    }
}
