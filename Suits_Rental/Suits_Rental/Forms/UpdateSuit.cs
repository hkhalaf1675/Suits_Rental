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
        List<SuitAttachmentDto> suitAttachments;
        private readonly ISuitsRepository suitsRepository;
        int suitId;
        SuitDto? suit;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelLayout_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtBoxMinZero_Leave(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if(txtBox.Text.Length ==  0 )
            {
                txtBox.Text = "0";
            }
        }

        private void TxtBoxPreventNonNumberic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxSelectAll_TabIndex_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.SelectAll();
        }

        private void UpdateSuit_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"تعديل البدلة رقم {suitId}";

            suit = suitsRepository.GetById(suitId);

            suitAttachments = suit?.SuitAttachments;

            comboSuitAttachments.DataSource = null;
            comboSuitAttachments.DataSource = suitAttachments;
            comboSuitAttachments.DisplayMember = "AttachmentName";
            txtSuitSize.Text = suit?.SuitSize.ToString();
            txtSuitRentalPrice.Text = suit?.RentalPrice.ToString();
            txtSuitSalePrice.Text = suit?.SalePrice.ToString();
        }

        private void btnSaveSuitAttachment_Click(object sender, EventArgs e)
        {
            if (txtAttachmentName.Text == "")
            {
                MessageBox.Show("برجاء إدخال اسم المرفق و المقاسات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                suitAttachments.Add(new SuitAttachmentDto
                {
                    AttachmentName = txtAttachmentName.Text,
                    AttachmentSize1 = Convert.ToInt32(txtAttachmentSizeNum1.Text),
                    AttachmentSize2 = Convert.ToInt32(txtAttachmentSizeNum2.Text),
                    AttachmentSize3 = Convert.ToInt32(txtAttachmentSizeNum3.Text),
                    AttachmentSize4 = Convert.ToInt32(txtAttachmentSizeNum4.Text),
                    AttachmentSize5 = Convert.ToInt32(txtAttachmentSizeNum5.Text),
                    AttachmentSize6 = Convert.ToInt32(txtAttachmentSizeNum6.Text),
                    AttachmentSize7 = Convert.ToInt32(txtAttachmentSizeNum7.Text),
                    AttachmentSize8 = Convert.ToInt32(txtAttachmentSizeNum8.Text),
                    AttachmentNotes = txtNotes.Text,
                });
            }

            comboSuitAttachments.DataSource = null;
            comboSuitAttachments.DataSource = suitAttachments;
            comboSuitAttachments.DisplayMember = "AttachmentName";
        }

        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            if (comboSuitAttachments.SelectedIndex == -1)
            {
                MessageBox.Show("لا يوجد اي عناصر لحذفها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var item = comboSuitAttachments.SelectedItem as SuitAttachmentDto;
                suitAttachments.Remove(item);

                comboSuitAttachments.DataSource = null;
                comboSuitAttachments.DataSource = suitAttachments;
                comboSuitAttachments.DisplayMember = "AttachmentName";
            }
        }

        private void btnUpdateSuit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSuitSize.Text) == 0)
            {
                MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDecimal(txtSuitSalePrice.Text) > 0 || Convert.ToDecimal(txtSuitRentalPrice.Text) > 0)
            {
                suitsRepository.Update(suitId, new SuitDto
                {
                    SuitSize = Convert.ToInt32(txtSuitSize.Text),
                    RentalPrice = Convert.ToDecimal(txtSuitRentalPrice.Text),
                    SalePrice = Convert.ToDecimal(txtSuitSalePrice.Text),
                    SuitAttachments = suitAttachments
                });

                MessageBox.Show("تمت تعديل البدلة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
