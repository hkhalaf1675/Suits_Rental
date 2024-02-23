using Microsoft.EntityFrameworkCore;
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

        public Suit? GetById(int id)
        {
            return context.Suits.Include(S => S.Attachments).SingleOrDefault(S => S.Id == id);
        }

        public List<SuitReadDto> GetAll()
        {
            var suits = context.Suits.Include(S => S.Attachments).ToList();
            
            List<SuitReadDto> readDtos = new List<SuitReadDto>();

            foreach(var suit in suits)
            {
                readDtos.Add(Mapping.SuitToReadDto(suit));
            }

            return readDtos;
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
            var suit = GetById(id);
            if(suit  == null)
            {
                return false;
            }
            context.Suits.Remove(suit);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public int GetAvailableSuitsCount()
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

        public int GetOutsideSuitsCount()
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

        public bool Update(int id, Suit suit)
        {
            var oldSuit = GetById(id);

            oldSuit.Size = suit.Size;
            oldSuit.SalePrice = suit.SalePrice;
            oldSuit.RentalPrice = suit.RentalPrice;

            oldSuit.Attachments = suit.Attachments;

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
    }
}
