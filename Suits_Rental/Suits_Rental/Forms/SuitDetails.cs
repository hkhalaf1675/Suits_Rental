using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            if(suit != null)
            {
                lblSuitNoHeader.Text = $"تفاصيل البدلة رقم {suitId}";
                lblRentalPrice.Text = (suit.RentalPrice == null) ? "0" : Convert.ToString(suit.RentalPrice);
                lblSalePrice.Text = (suit.SalePrice == null) ? "0" : Convert.ToString(suit.SalePrice);

                comboSuitAvailableSizes.Items.Clear();
                comboSuitOutsideSizes.Items.Clear();

                comboSuitAvailableSizes.Items.AddRange(
                        suit.SuitSizes
                        .Where(SS => SS.AvailableStatus == Models.Status.Inside)
                        .ToArray()
                    );

               comboSuitOutsideSizes.Items.AddRange(
                        suit.SuitSizes
                        .Where(SS => SS.AvailableStatus == Models.Status.Outside)
                        .ToArray()
                    );

                List<AttachmentSizesDto> AvailableAttachments = new List<AttachmentSizesDto>();
                List<AttachmentSizesDto> OutsideAttachments = new List<AttachmentSizesDto>();

                if(suit.Attachments != null)
                {
                    foreach(var attachment in suit.Attachments)
                    {
                        if(attachment.Attachment_Sizes != null)
                        {
                            foreach(var size in attachment.Attachment_Sizes)
                            {
                                if(size.AvailableStatus == Models.Status.Inside)
                                {
                                    if(size.Size > 0)
                                    {
                                        AvailableAttachments.Add(new AttachmentSizesDto
                                        {
                                            SuitId = suitId,
                                            AttachmentName = attachment.AttachmentName,
                                            Size = size.Size,
                                        });
                                    }
                                }
                                else if(size.AvailableStatus == Models.Status.Outside)
                                {
                                    OutsideAttachments.Add(new AttachmentSizesDto
                                    {
                                        SuitId = suitId,
                                        AttachmentName = attachment.AttachmentName,
                                        Size = size.Size,
                                    });
                                }
                            }
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
