using Suits_Rental.Dtos;
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
    public partial class UpdateSuit : Form
    {
        List<Suit_Attachments> suitAttachments;
        private readonly ISuitsRepository suitsRepository;
        int suitId;
        Suit? suit;

        // form layout
        private Button currentButton;

        // form layout
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        public UpdateSuit(int id)
        {
            InitializeComponent();
            suitId = id;
            suitsRepository = new SuitsRepository();
        }

        private void btnAddSuitAttachment_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(561, 545);
            this.btnAddSuitAttachment.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelLayout_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSaveSuitAttachment_Click(object sender, EventArgs e)
        {
            if (txtAttachmentName.Text == "" || numericAttachmentSize.Value <= 0)
            {
                MessageBox.Show("برجاء إدخال اسم المرفق و المقاس");
            }
            else
            {
                suitAttachments.Add(new Suit_Attachments
                {
                    AttachmentName = txtAttachmentName.Text,
                    Size = Convert.ToInt32(numericAttachmentSize.Value),
                    Notes = txtNotes.Text,
                });

                this.Size = new System.Drawing.Size(561, 325);
                this.btnAddSuitAttachment.Enabled = true;
            }

            comboSuitAttachments.DataSource = null;
            comboSuitAttachments.DataSource = suitAttachments;
            comboSuitAttachments.DisplayMember = "AttachmentName";
        }

        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            if (comboSuitAttachments.SelectedIndex == -1)
            {
                MessageBox.Show("لا يوجد اي عناصر لحذفها");
            }
            else
            {
                var item = comboSuitAttachments.SelectedItem as Suit_Attachments;
                suitAttachments.Remove(item);

                comboSuitAttachments.DataSource = null;
                comboSuitAttachments.DataSource = suitAttachments;
                comboSuitAttachments.DisplayMember = "AttachmentName";
            }
        }

        private void UpdateSuit_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"تعديل البدلة رقم {suitId}";

            suit = suitsRepository.GetById(suitId);

            suitAttachments = suit?.Attachments;

            comboSuitAttachments.DataSource = null;
            comboSuitAttachments.DataSource = suitAttachments;
            comboSuitAttachments.DisplayMember = "AttachmentName";
            numericSuitSize.Value = Convert.ToDecimal(suit?.Size);
            numericSuitRentPrice.Value = Convert.ToDecimal(suit?.RentalPrice);
            numericSuitSalePrice.Value = Convert.ToDecimal(suit?.SalePrice);
        }

        private void btnUpdateSuit_Click(object sender, EventArgs e)
        {
            if (numericSuitSize.Value <= 0)
            {
                MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع");
            }
            else if (numericSuitSalePrice.Value > 0 || numericSuitRentPrice.Value > 0)
            {
                suitsRepository.Update(suitId,new Suit
                {
                    Size = Convert.ToInt32(numericSuitSize.Value),
                    RentalPrice = numericSuitRentPrice.Value,
                    SalePrice = numericSuitSalePrice.Value,
                    Attachments = suitAttachments
                });

                MessageBox.Show("تمت تعديل البدلة بنجاح");
                Close();
            }
            else
            {
                MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع");
            }
        }
    }
}
