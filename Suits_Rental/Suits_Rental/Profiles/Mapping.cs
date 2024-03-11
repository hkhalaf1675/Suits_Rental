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

            foreach (var item in suitDto.SuitAttachments)
            {
                suit_Attachments.Add(MapDtoToSuitAttachment(item));
            }

            int counter = 0;
            if(suitDto.Size1 > 0)
            {
                counter++;
            }
            if(suitDto.Size2 > 0)
            {
                counter++;
            }
            if(suitDto.Size3 > 0)
            {
                counter++;
            }
            if (suitDto.Size4 > 0)
            {
                counter++;
            }
            if (suitDto.Size5 > 0)
            {
                counter++;
            }
            if (suitDto.Size6 > 0)
            {
                counter++;
            }
            if (suitDto.Size7 > 0)
            {
                counter++;
            }
            if (suitDto.Size8 > 0)
            {
                counter++;
            }

            return new Suit
            {
                Id = suitDto.Id,
                RentalPrice = suitDto.RentalPrice,
                SalePrice = suitDto.SalePrice,
                Size1 = suitDto.Size1,
                Size2 = suitDto.Size2,
                Size3 = suitDto.Size3,
                Size4 = suitDto.Size4,
                Size5 = suitDto.Size5,
                Size6 = suitDto.Size6,
                Size7 = suitDto.Size7,
                Size8 = suitDto.Size8,
                ReservedSizes = "",
                AvailableCounter = counter,
                Attachments = suit_Attachments
            };
        }

        public static Suit_Attachments MapDtoToSuitAttachment(SuitAttachmentDto suitAttachmentDto)
        {
            List<Attachment_Sizes> attachment_Sizes = new List<Attachment_Sizes>();
            attachment_Sizes.Add(new Attachment_Sizes
            {
                Size = suitAttachmentDto.AttachmentSize1
            });
            attachment_Sizes.Add(new Attachment_Sizes
            {
                Size = suitAttachmentDto.AttachmentSize2
            });
            attachment_Sizes.Add(new Attachment_Sizes
            {
                Size = suitAttachmentDto.AttachmentSize3
            });
            attachment_Sizes.Add(new Attachment_Sizes
            {
                Size = suitAttachmentDto.AttachmentSize4
            });
            attachment_Sizes.Add(new Attachment_Sizes
            {
                Size = suitAttachmentDto.AttachmentSize5
            });
            attachment_Sizes.Add(new Attachment_Sizes
            {
                Size = suitAttachmentDto.AttachmentSize6
            });
            attachment_Sizes.Add(new Attachment_Sizes
            {
                Size = suitAttachmentDto.AttachmentSize7
            });
            attachment_Sizes.Add(new Attachment_Sizes
            {
                Size = suitAttachmentDto.AttachmentSize8
            });
            return new Suit_Attachments
            {
                AttachmentName = suitAttachmentDto.AttachmentName,
                Attachment_Sizes = attachment_Sizes,
                Notes = suitAttachmentDto.AttachmentNotes
            };
        }

        public static SuitDto SuitToDto(Suit suit)
        {
            List<SuitAttachmentDto> attachments = new List<SuitAttachmentDto>();
            foreach(var item in suit.Attachments)
            {
                attachments.Add(new SuitAttachmentDto
                {
                    AttachmentName = item.AttachmentName
                });
            }
            return new SuitDto
            {
                Id = suit.Id,
                RentalPrice = suit.RentalPrice,
                SalePrice = suit.SalePrice,
                Available = suit.AvailableCounter,
                Size1 = suit.Size1,
                Size2 = suit.Size2,
                Size3 = suit.Size3,
                Size4 = suit.Size4,
                Size5 = suit.Size5,
                Size6 = suit.Size6,
                Size7 = suit.Size7,
                Size8 = suit.Size8,
                SuitAttachments = attachments
            };
        }

        public static SuitReadDto SuitToReadDto(Suit suit)
        {
            return new SuitReadDto
            {
                Id = suit.Id,
                RentalPrice = suit.RentalPrice,
                SalePrice = suit.SalePrice,
                AttachmentsCount = suit.Attachments.Count,
                AvailableCount = suit.AvailableCounter
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
                Discount = order.Discount,
                Date = (order.Date == null) ? DateTime.Now : Convert.ToDateTime(order.Date)            };
        }

        public static OrderReadDto OrderToReadDto(Order order)
        {
            List<AttachmentSizesDto> sizes = new List<AttachmentSizesDto>();
            if (order.OrderSuits != null)
            {
                foreach (var orderSuit in order.OrderSuits)
                {
                    if (orderSuit != null)
                    {
                        if (orderSuit.OrderAttachmentSizes != null)
                        {
                            foreach (var attachmentSize in orderSuit.OrderAttachmentSizes)
                            {
                                if (attachmentSize != null)
                                {
                                    if (attachmentSize.Attachment_Size != null)
                                    {
                                        sizes.Add(new AttachmentSizesDto
                                        {
                                            AttachmentId = (attachmentSize.Attachment_Size.AttachmentId == null) ? 0 : Convert.ToInt32(attachmentSize.Attachment_Size.AttachmentId),
                                            SizeId = attachmentSize.Attachment_Size.Id,
                                            SuitId = (orderSuit.SuitId == null) ? 0 : Convert.ToInt32(orderSuit.SuitId),
                                            Size = attachmentSize.Attachment_Size.Size,
                                            AttachmentName = attachmentSize?.Attachment_Size?.Attachment?.AttachmentName
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
            }
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
                UserName = order.UserName,
                Notes = order.Notes,
                AttachmentsSizes = sizes
            };
        }
    }
}
