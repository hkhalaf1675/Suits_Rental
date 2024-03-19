using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Dtos;
using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suits_Rental.Forms
{
    public partial class SuitDetails : Form
    {
        private readonly ApplicationDbContext context;
        int suitId;

        // form layout
        private Button currentButton;

        // form layout
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);


        public SuitDetails(int id)
        {
            InitializeComponent();

            context = new ApplicationDbContext();
            suitId = id;
        }

        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuitDetails_Load(object sender, EventArgs e)
        {
            var suit = context.Suits
                .Include(S => S.SuitSizes)
                .Include(S => S.Attachments)
                .ThenInclude(At => At.Attachment_Sizes)
                .FirstOrDefault(S => S.Id == suitId);

            var suitBooks = context.SuitBooks
                .Include(Sb => Sb.SuitSize)
                .Where(Sb => Sb.SuitSize.SuitId == suitId)
                .ToList();

            var suitBooksAttachments = context.SuitBooks
                .Include(Sb => Sb.OrderAttachmentSizes)
                .ThenInclude(OAS => OAS.Attachment_Size)
                .Where(Sb => Sb.SuitSize.SuitId == suitId)
                .ToList();

            if (suit != null)
            {
                lblSuitNoHeader.Text = $"تفاصيل البدلة رقم {suitId}";
                lblRentalPrice.Text = (suit.RentalPrice == null) ? "0" : Convert.ToString(suit.RentalPrice);
                lblSalePrice.Text = (suit.SalePrice == null) ? "0" : Convert.ToString(suit.SalePrice);

                comboSuitAvailableSizes.Items.Clear();
                comboSuitOutsideSizes.Items.Clear();

                List<SuitSize> outsideSizes = new List<SuitSize>();
                if (suitBooks is not null)
                {
                    outsideSizes = suitBooks.Where(Sb => Sb.OrderDate <= DateTime.UtcNow && Sb.ReturnDate >= DateTime.UtcNow)
                        .Select(Sb => Sb.SuitSize).ToList();
                }

                foreach(var suitSize in outsideSizes)
                {
                    if(suit.SuitSizes.Exists(Ss => Ss.Id == suitSize.Id))
                    {
                        suit.SuitSizes.RemoveAll(Ss => Ss.Id == suitSize.Id);
                    }
                }

                comboSuitAvailableSizes.Items.AddRange(
                        suit.SuitSizes.ToArray()
                    );

               comboSuitOutsideSizes.Items.AddRange(
                        outsideSizes.ToArray()
                    );

                List<AttachmentSizesDto> AvailableAttachments = new List<AttachmentSizesDto>();
                List<AttachmentSizesDto> OutsideAttachments = new List<AttachmentSizesDto>();

                List<List<OrderAttachmentSize>> outsideAttachments = new List<List<OrderAttachmentSize>>();
                if(suitBooksAttachments is not null)
                {
                    outsideAttachments = suitBooksAttachments.Where(Sb => Sb.OrderDate <= DateTime.UtcNow && Sb.ReturnDate >= DateTime.UtcNow)
                        .Select(Sb => Sb.OrderAttachmentSizes).ToList();
                }

                if(suit.Attachments != null)
                {
                    foreach(var parentItem in outsideAttachments)
                    {
                        foreach(var childItem in parentItem)
                        {
                            foreach(var attchment in suit.Attachments)
                            {
                                if (attchment.Attachment_Sizes.Exists(At => At.Id == childItem.AttachmentSizeId))
                                {
                                    OutsideAttachments.Add(new AttachmentSizesDto
                                    {
                                        SuitId = suitId,
                                        AttachmentName = attchment.AttachmentName,
                                        Size = childItem.Attachment_Size.Size,
                                    });
                                }
                                else
                                {
                                    AvailableAttachments.Add(new AttachmentSizesDto
                                    {
                                        SuitId = suitId,
                                        AttachmentName = attchment.AttachmentName,
                                        Size = childItem.Attachment_Size.Size,
                                    });
                                }
                            }
                        }
                    }
                }
                if(outsideAttachments.Count == 0 || outsideAttachments is null)
                {
                    foreach(var attchment in suit.Attachments)
                    {
                        foreach(var item in attchment.Attachment_Sizes)
                        {
                            AvailableAttachments.Add(new AttachmentSizesDto
                            {
                                SuitId = suitId,
                                AttachmentName = attchment.AttachmentName,
                                Size = item.Size,
                            });
                        }
                    }
                }

                comboAvailableAttachments.Items.Clear();
                comboAvailableAttachments.Items.AddRange(AvailableAttachments.ToArray());

                comboOutsideAttachments.Items.Clear();
                comboOutsideAttachments.Items.AddRange(OutsideAttachments.ToArray());
            }
        }
    }
}
