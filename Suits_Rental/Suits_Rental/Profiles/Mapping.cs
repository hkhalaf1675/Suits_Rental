﻿using Suits_Rental.Dtos;
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
        public static InvoiceDto OrderToInvoice(Order order)
        {
            return new InvoiceDto
            {
                OrderId = order.Id,
                OrderType = order.Type,
                TotalPrice = Convert.ToDecimal(order.TotalPrice),
                PaidAmount = Convert.ToDecimal(order.PaidAmount),
                RemainAmount = Convert.ToDecimal(order.RemainAmount),
                ItemsCount = Convert.ToInt32(order.ItemsCount),
                CustomerName = order.Customer.Name
            };
        }

        public static OrderReadDto OrderToReadDto(Order order)
        {
            return new OrderReadDto
            {
                Id = order.Id,
                CustomerName = order.Customer.Name,
                Date = Convert.ToDateTime(order.Date),
                RentDays = Convert.ToInt32(order.RentDays),
                TotalPrice = Convert.ToDecimal(order.TotalPrice),
                RemainAmount = Convert.ToDecimal(order.RemainAmount),
                BetAttachment = Convert.ToString(order.BetAttachment)
            };
        }
    }
}
