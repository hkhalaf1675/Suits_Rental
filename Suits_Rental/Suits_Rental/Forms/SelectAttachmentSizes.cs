using Suits_Rental.Dtos;
using Suits_Rental.Events;
using Suits_Rental.IRepositories;
using Suits_Rental.Models;
using Suits_Rental.Repositories;
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
    public partial class SelectAttachmentSizes : Form
    {
        private readonly ISuitsRepository suitsRepository;
        int suitId;
        List<AttachmentSizesDto> sizesDtos;
        List<AttachmentSizesDto> sizesToRemoved;
        public event EventHandler<DataEventArgs> DataSend;

        // form layout
        private Button currentButton;

        // form layout
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        public SelectAttachmentSizes(int id,List<AttachmentSizesDto> sizesToRemoved)
        {
            InitializeComponent();

            suitsRepository = new SuitsRepository();
            suitId = id;
            sizesDtos = new List<AttachmentSizesDto>();
            this.sizesToRemoved = sizesToRemoved;
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
            var attachments = suitsRepository.GetSuitAttachments(suitId);
            if (attachments != null)
            {
                comboAttachments.Items.Clear();
                comboAttachments.Items.AddRange(attachments.ToArray());
                comboAttachments.DisplayMember = "AttachmentName";
            }
        }

        private void FillComboAvailableSizes()
        {
            if (comboAttachments.SelectedItem != null)
            {
                Suit_Attachments suit_Attachments = comboAttachments.SelectedItem as Suit_Attachments;
                if (suit_Attachments != null)
                {
                    var sizes = suitsRepository.GetAvailableSizes(suit_Attachments.Id);
                    
                    if (sizes != null)
                    {
                        foreach (var size in sizesToRemoved)
                        {
                            var checkFound = sizes.FirstOrDefault(S => S.Id == size.SizeId);
                            if(checkFound  != null)
                            {
                                sizes.Remove(checkFound);
                            }
                        }
                        comboAvailableSizes.Items.Clear();
                        comboAvailableSizes.Items.AddRange(sizes.ToArray());
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
                    if(!sizesDtos.Exists(S => S.AttachmentId == suit_Attachment.Id))
                    {
                        sizesDtos.Add(new AttachmentSizesDto
                        {
                            SuitId = suit_Attachment.SuitId,
                            AttachmentId = suit_Attachment.Id,
                            SizeId = attachment_Size.Id,
                            Size = attachment_Size.Size,
                            AttachmentName = suit_Attachment.AttachmentName
                        });
                    }
                    else if(!sizesDtos.Exists(S => S.SizeId == attachment_Size.Id))
                    {
                        var sizeDto = sizesDtos.FirstOrDefault(S => S.AttachmentId == suit_Attachment.Id);
                        if(sizeDto  != null)
                        {
                            sizesDtos.Remove(sizeDto);
                            sizesDtos.Add(new AttachmentSizesDto
                            {
                                SuitId = suit_Attachment.SuitId,
                                AttachmentId = suit_Attachment.Id,
                                SizeId = attachment_Size.Id,
                                Size = attachment_Size.Size,
                                AttachmentName = suit_Attachment.AttachmentName
                            });
                        }
                    }
                    comboSelectedSizes.Items.Clear();
                    comboSelectedSizes.Items.AddRange(sizesDtos.ToArray());
                }
            }
        }

        private void RemoveItemSelectedSize()
        {
            if (comboSelectedSizes.SelectedItem != null)
            {
                AttachmentSizesDto attachmentSizesDto = comboSelectedSizes.SelectedItem as AttachmentSizesDto;
                if (attachmentSizesDto != null)
                {
                    sizesDtos.Remove(attachmentSizesDto);
                    comboSelectedSizes.Items.Clear();
                    comboSelectedSizes.Items.AddRange(sizesDtos.ToArray());
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
            FillComboSelectedAttachmentSizes();
            MessageBox.Show("تمت إضافة المقاس بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteSize_Click(object sender, EventArgs e)
        {
            RemoveItemSelectedSize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSend.Invoke(this,new DataEventArgs(sizesDtos));
            this.Close();
        }
    }
}
