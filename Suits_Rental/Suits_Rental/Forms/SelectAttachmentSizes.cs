using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Events;
using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    public partial class SelectAttachmentSizes : Form
    {
        List<Attachment_Sizes> selectedAttachmentSizes;
        List<Attachment_Sizes> sizesToRemoved;
        DateTime orderDate;
        public event EventHandler<DataEventArgs> DataSend;
        private readonly ApplicationDbContext context;

        // form layout
        private Button currentButton;

        // form layout
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        public SelectAttachmentSizes(List<Attachment_Sizes> sizesToRemoved, DateTime orderDate)
        {
            InitializeComponent();

            context = new ApplicationDbContext();
            selectedAttachmentSizes = new List<Attachment_Sizes>();
            this.sizesToRemoved = sizesToRemoved;
            this.orderDate = orderDate;
        }

        #region Layout
        private void panelLayout_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Get and Load Data
        private void FillComboAttachments()
        {
            var attachments = context.Suit_Attachments.ToList();
            if (attachments != null)
            {
                comboAttachments.Items.Clear();
                comboAttachments.Items.AddRange(attachments.ToArray());
            }
        }

        private void FillComboAvailableSizes()
        {
            if (comboAttachments.SelectedItem != null)
            {
                Suit_Attachments suit_Attachments = comboAttachments.SelectedItem as Suit_Attachments;
                if (suit_Attachments != null)
                {
                    var allAttachmentsSizes = context.Attachment_Sizes
                        .Where(AS => AS.AttachmentId == suit_Attachments.Id && AS.AvailableStatus != Status.Sale && AS.Size > 0)
                        .OrderBy(AS => AS.Size)
                        .ToList();

                    if (allAttachmentsSizes != null)
                    {
                        var outsideSizes = context.SuitBooks
                        .Include(SB => SB.OrderAttachmentSizes)
                        .ThenInclude(OAS => OAS.Attachment_Size)
                        .Where(SB => SB.OrderDate <= orderDate && SB.ReturnDate >= orderDate && SB.OrderStatus != Status.Inside)
                        .ToList();

                        foreach (var suitBook in outsideSizes)
                        {
                            foreach(var orderAttachmentSize in suitBook.OrderAttachmentSizes)
                            {
                                if(allAttachmentsSizes.Exists(As => As.Id == orderAttachmentSize.Attachment_Size.Id))
                                {
                                    allAttachmentsSizes.RemoveAll(As => As.Id == orderAttachmentSize.Attachment_Size.Id);
                                }
                            }
                        }

                        foreach (var size in sizesToRemoved)
                        {
                            if (allAttachmentsSizes.Exists(As => As.Id == size.Id))
                            {
                                allAttachmentsSizes.RemoveAll(As => As.Id == size.Id);
                            }
                        }

                        comboAvailableSizes.Items.Clear();
                        comboAvailableSizes.Items.AddRange(allAttachmentsSizes.ToArray());
                        comboAvailableSizes.DisplayMember = "Size";
                    }
                }
            }
        }

        private void FillComboSelectedAttachmentSizes()
        {
            if (comboAttachments.SelectedItem != null && comboAvailableSizes.SelectedItem != null)
            {
                Suit_Attachments suit_Attachment = comboAttachments.SelectedItem as Suit_Attachments;
                Attachment_Sizes attachment_Size = comboAvailableSizes.SelectedItem as Attachment_Sizes;

                if (suit_Attachment != null && attachment_Size != null)
                {
                    if (!selectedAttachmentSizes.Exists(S => S.AttachmentId == suit_Attachment.Id))
                    {
                        selectedAttachmentSizes.Add(attachment_Size);
                    }
                    else if(!selectedAttachmentSizes.Contains(attachment_Size))
                    {
                        selectedAttachmentSizes.RemoveAll(S => S.AttachmentId == suit_Attachment.Id);
                        selectedAttachmentSizes.Add(attachment_Size);
                    }
                    comboSelectedSizes.Items.Clear();
                    comboSelectedSizes.Items.AddRange(selectedAttachmentSizes.ToArray());
                }
            }
        }

        private void RemoveItemSelectedSize()
        {
            if (comboSelectedSizes.SelectedItem != null)
            {
                Attachment_Sizes selectedSizeToRemove = comboSelectedSizes.SelectedItem as Attachment_Sizes;
                if (selectedSizeToRemove != null)
                {
                    selectedAttachmentSizes.Remove(selectedSizeToRemove);
                    comboSelectedSizes.Items.Clear();
                    comboSelectedSizes.Items.AddRange(selectedAttachmentSizes.ToArray());
                }
            }
        }
        #endregion

        private void SelectAttachmentSizes_Load(object sender, EventArgs e)
        {
            FillComboAttachments();
        }

        private void comboAttachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboAvailableSizes();
        }

        private void btnAddAttchmentSize_Click(object sender, EventArgs e)
        {
            if(comboAttachments.SelectedItem != null && comboAvailableSizes.SelectedItem !=null)
            {
                FillComboSelectedAttachmentSizes();
                MessageBox.Show("تمت إضافة المقاس بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("برجاء اختيار المرفق والمقاس", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSize_Click(object sender, EventArgs e)
        {
            if(comboSelectedSizes.SelectedItem != null)
                RemoveItemSelectedSize();
            else
            {
                MessageBox.Show("برجاء اختيار المرفق المراد حذفه", "تحديز", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(selectedAttachmentSizes.Count > 0)
            {
                DataSend.Invoke(this, new DataEventArgs(selectedAttachmentSizes));
                this.Close();
            }
            else
            {
                MessageBox.Show("برجاء تحديد مرفقات البدلة", "تحديز", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
