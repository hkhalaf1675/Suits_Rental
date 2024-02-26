using Suits_Rental.Dtos;
using Suits_Rental.IRepositories;
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
    public partial class ManageSuitForm : Form
    {
        List<SuitAttachmentDto> suitAttachments;
        private readonly ISuitsRepository suitsRepository;

        // form layout
        private Button currentButton;

        // form layout
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        public ManageSuitForm()
        {
            InitializeComponent();
            suitAttachments = new List<SuitAttachmentDto>();
            suitsRepository = new SuitsRepository();
        }

        private void btnAddSuitAttachment_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(560, 600);
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

        private void ManageSuitForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveSuitAttachment_Click(object sender, EventArgs e)
        {
            if (txtAttachmentName.Text == "" || numericAttachmentSize.Value <= 0)
            {
                MessageBox.Show("برجاء إدخال اسم المرفق و المقاس", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                suitAttachments.Add(new SuitAttachmentDto
                {
                    AttachmentName = txtAttachmentName.Text,
                    AttachmentSize = Convert.ToInt32(numericAttachmentSize.Value),
                    AttachmentNotes = txtNotes.Text,
                });

                this.Size = new System.Drawing.Size(560, 375);
                this.btnAddSuitAttachment.Enabled = true;
            }

            comboSuitAttachments.DataSource = null;
            comboSuitAttachments.DataSource = suitAttachments;
            comboSuitAttachments.DisplayMember = "AttachmentName";
        }

        private void btnSaveSuit_Click(object sender, EventArgs e)
        {
            if (numericSuitNum.Value <= 0)
            {
                MessageBox.Show("برجاء ادخال الرقم التعريفي للبدلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int suitId = Convert.ToInt32(numericSuitNum.Value);
                var checkExists = suitsRepository.GetById(suitId);
                if (checkExists != null)
                {
                    MessageBox.Show("هذا الرقم التعريفي موجود, برجاء اختيار رقم أخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (numericSuitSize.Value <= 0)
                    {
                        MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (numericSuitSalePrice.Value > 0 || numericSuitRentPrice.Value > 0)
                    {
                        suitsRepository.AddNew(new SuitDto
                        {
                            Id = suitId,
                            SuitSize = Convert.ToInt32(numericSuitSize.Value),
                            RentalPrice = numericSuitRentPrice.Value,
                            SalePrice = numericSuitSalePrice.Value,
                            SuitAttachments = suitAttachments
                        });

                        MessageBox.Show("تمت إضافة البدلة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void txtAttachmentName_Enter(object sender, EventArgs e)
        {
            txtAttachmentName.SelectAll();
        }
    }
}
