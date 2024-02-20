using Suits_Rental.Contexts;
using Suits_Rental.Dtos;
using Suits_Rental.IRepositories;
using Suits_Rental.Models;
using Suits_Rental.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Repositories
{
    public class SuitsRepository : ISuitsRepository
    {
        private ApplicationDbContext context;

        public SuitsRepository()
        {
            this.context = new ApplicationDbContext();
        }
        public bool AddNew(SuitDto suit)
        {
            Suit newSuit = Mapping.MapDtoToSuit(suit);

            context.Suits.Add(newSuit);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int GetAvailableSuits()
        {
            int availableSuits = 0;
            try
            {
                availableSuits =  context.Suits.Where(S => S.AvailableStatus == true).Count();
            }
            catch (Exception ex)
            {
                availableSuits = 0;
            }

            return availableSuits;
        }

        public int GetOutsideSuits()
        {
            int outsideSuits = 0;
            try
            {
                outsideSuits = context.Suits.Where(S => S.AvailableStatus == false).Count();
            }
            catch (Exception ex)
            {
                outsideSuits = 0;
            }

            return outsideSuits;
        }

        public bool Update(int id, SuitDto suit)
        {
            throw new NotImplementedException();
        }
    }
}
