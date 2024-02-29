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
        SuitDto? GetById(int id);
        int GetAvailableSuitsCount();
        int GetOutsideSuitsCount();
        bool AddNew(SuitDto suit);
        bool Update(int id, SuitDto suitDto);
        bool Delete(int id);
        List<SuitReadDto> GetAll();
        List<SuitReadDto> GetAllAvailable();
    }
}
