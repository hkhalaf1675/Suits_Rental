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
                Id = suitDto.Id,
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
                CustomerName = order.Customer.Name,
                Cashier = order.UserName,
                Discount = order.Discount
            };
        }

        public static OrderReadDto OrderToReadDto(Order order)
        {
            return new OrderReadDto
            {
                Id = order.Id,
                CustomerName = order.Customer.Name,
                PhoneNumber = order.Customer.Phone,
                Address = order.Customer.Address,
                Date = Convert.ToDateTime(order.Date),
                RentDays = Convert.ToInt32(order.RentDays),
                TotalPrice = Convert.ToDecimal(order.TotalPrice),
                RemainAmount = Convert.ToDecimal(order.RemainAmount),
                BetAttachment = Convert.ToString(order.BetAttachment),
                ItemsCount = Convert.ToInt32(order.ItemsCount),
                Status = order.Status,
                Discount = order.Discount,
                UserName = order.UserName
            };
        }

        public static OrderWriteWithOutCustomerDto FromOrderDto(int cutsomerId ,OrderDto orderDto)
        {
            return new OrderWriteWithOutCustomerDto
            {
                CustomerId = cutsomerId,
                Type = orderDto.Type,
                TotalPrice = Convert.ToDecimal(orderDto.TotalPrice),
                PaidAmount = Convert.ToDecimal(orderDto.PaidAmount),
                RemainAmount = Convert.ToDecimal(orderDto.RemainAmount),
                RentDays = Convert.ToInt32(orderDto.RentDays),
                SuitsIDs = orderDto.SuitsIDs,
                BetAttachment = orderDto.BetAttachment,
                Discount = orderDto.Discount,
                UserName = orderDto.UserName
            };
        }
    }
}
