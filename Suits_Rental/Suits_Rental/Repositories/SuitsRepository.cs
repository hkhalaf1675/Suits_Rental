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
                .ThenInclude(At => At.Attachment_Sizes)
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
                    .Where(S => S.AvailableCounter > 0)
                    .Select(S => S.AvailableCounter)
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
                var result = context.Orders
                    .Where(O => O.Status == Status.Outside)
                    .Select(O => O.ItemsCount).ToList().Sum();

                if(result != null)
                {
                    outsideSuits = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                outsideSuits = 0;
            }

            return outsideSuits;
        }

        public bool Update(int id, Suit suit)
        {
            var oldSuit = context.Suits
                .Include(S => S.Attachments)
                .FirstOrDefault(S => S.Id == id);

            if(oldSuit != null)
            {
                oldSuit.RentalPrice = suit.RentalPrice;
                oldSuit.SalePrice = suit.SalePrice;
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
                .Where(S => S.AvailableCounter > 0)
                .ToList();

            List<SuitReadDto> readDtos = new List<SuitReadDto>();

            foreach (var suit in suits)
            {
                readDtos.Add(Mapping.SuitToReadDto(suit));
            }

            return readDtos;
        }

        public List<Suit_Attachments> GetSuitAttachments()
        {
            return context.Suit_Attachments
                .ToList();
        }

        public List<Suit_Attachments> GetSuitAttachmentsById(int suitId)
        {
            return context.Suit_Attachments
                .Where(SA => SA.SuitId == suitId)
                .ToList();
        }

        public List<Attachment_Sizes> GetAvailableSizes(int attachmentId)
        {
            return context.Attachment_Sizes
                .Where(AS => AS.AttachmentId == attachmentId && AS.AvailableStatus == true && AS.Size > 0)
                .ToList();
        }

        public Suit? GetSuit(int suitId)
        {
            return context.Suits
                .Include(S => S.Attachments)
                .ThenInclude(At => At.Attachment_Sizes)
                .FirstOrDefault(S => S.Id == suitId);
        }
    }
}
