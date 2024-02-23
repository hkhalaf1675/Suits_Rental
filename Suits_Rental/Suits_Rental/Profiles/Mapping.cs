using Suits_Rental.Dtos;
using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Profiles
{
    public class Mapping
    {
        public static Suit MapDtoToSuit(SuitDto suitDto)
        {
            List<Suit_Attachments> suit_Attachments = new List<Suit_Attachments>();
            foreach(var item in suitDto.SuitAttachments)
            {
                suit_Attachments.Add(MapDtoToSuitAttachment(item));
            }

            return new Suit
            {
                Size = suitDto.SuitSize,
                RentalPrice = suitDto.RentalPrice,
                SalePrice = suitDto.SalePrice,
                Attachments = suit_Attachments
            };
        }

        public static Suit_Attachments MapDtoToSuitAttachment(SuitAttachmentDto suitAttachmentDto)
        {
            return new Suit_Attachments
            {
                AttachmentName = suitAttachmentDto.AttachmentName,
                Size = suitAttachmentDto.AttachmentSize,
                Notes = suitAttachmentDto.AttachmentNotes
            };
        }

        public static SuitReadDto SuitToReadDto(Suit suit)
        {
            return new SuitReadDto
            {
                Id = suit.Id,
                Size = suit.Size,
                RentalPrice = suit.RentalPrice,
                SalePrice = suit.SalePrice,
                AttachmentsCount = suit.Attachments.Count,
                Status = (suit.AvailableStatus == true) ? "موجودة" : "غير موجودة"
            };
        }
    }
}
