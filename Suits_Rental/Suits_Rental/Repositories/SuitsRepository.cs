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

        public SuitDto? GetById(int id)
        {
            var suit =  context.Suits
                .Include(S => S.Attachments)
                .SingleOrDefault(S => S.Id == id);

            if(suit != null)
            {
                return Mapping.SuitToDto(suit);
            }
            else
            {
                return null;
            }
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
            var suit = context.Suits.FirstOrDefault(S => S.Id == id);
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
                availableSuits = context.Suits
                    .Where(S => S.AvaibableCounter > 0)
                    .Select(S => S.AvaibableCounter)
                    .ToList().Sum();
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
                outsideSuits = context.Suits
                    .Where(S => S.AvaibableCounter != 8)
                    .Select(S => S.AvaibableCounter)
                    .ToList().Sum();
            }
            catch (Exception ex)
            {
                outsideSuits = 0;
            }

            return outsideSuits;
        }

        public bool Update(int id, SuitDto suitDto)
        {
            var oldSuit = context.Suits
                .Include(S => S.Attachments)
                .FirstOrDefault(S => S.Id == id);

            if(oldSuit != null)
            {
                var suit = Mapping.MapDtoToSuit(suitDto);
                oldSuit.Size = suit.Size;
                oldSuit.RentalPrice = suit.RentalPrice;
                oldSuit.SalePrice = suit.SalePrice;
                oldSuit.Attachments.Clear();
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

            return false;
        }

        public List<SuitReadDto> GetAllAvailable()
        {
            var suits = context.Suits
                .Include(S => S.Attachments)
                .Where(S => S.AvaibableCounter > 0)
                .ToList();

            List<SuitReadDto> readDtos = new List<SuitReadDto>();

            foreach (var suit in suits)
            {
                readDtos.Add(Mapping.SuitToReadDto(suit));
            }

            return readDtos;
        }
    }
}
