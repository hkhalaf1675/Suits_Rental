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
using System.Net.Mail;
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

            suit = suitsRepository.GetSuit(suitId);

            suitAttachments = suit?.Attachments;

            comboSuitAttachments.DataSource = null;
            comboSuitAttachments.DataSource = suitAttachments;
            txtSuitRentalPrice.Text = suit?.RentalPrice.ToString();
            txtSuitSalePrice.Text = suit?.SalePrice.ToString();

            txtSuitSize1.Text = suit.Size1.ToString();
            txtSuitSize2.Text = suit.Size2.ToString();
            txtSuitSize3.Text = suit.Size3.ToString();
            txtSuitSize4.Text = suit.Size4.ToString();
            txtSuitSize5.Text = suit.Size5.ToString();
            txtSuitSize6.Text = suit.Size6.ToString();
            txtSuitSize7.Text = suit.Size7.ToString();
            txtSuitSize8.Text = suit.Size8.ToString();
        }

        private void btnAddSuitAttachment_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(561, 545);
            //this.btnAddSuitAttachment.Enabled = false;
        }

        private void btnSaveSuitAttachment_Click(object sender, EventArgs e)
        {
            if (txtAttachmentName.Text == "")
            {
                MessageBox.Show("برجاء إدخال اسم المرفق و المقاسات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Attachment_Sizes> attachment_Sizes = new List<Attachment_Sizes>();

                if (int.TryParse(txtAttachmentSizeNum1.Text, out int sizeInt1))
                {
                    if(sizeInt1 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt1
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum2.Text, out int sizeInt2))
                {
                    if(sizeInt2 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt2
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum3.Text, out int sizeInt3))
                {
                    if(sizeInt3 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt3
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum4.Text, out int sizeInt4))
                {
                    if (sizeInt4 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt4
                        });
                    }
                }

                // ----

                if (int.TryParse(txtAttachmentSizeNum5.Text, out int sizeInt5))
                {
                    if (sizeInt5 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt5
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum6.Text, out int sizeInt6))
                {
                    if (sizeInt6 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt6
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum7.Text, out int sizeInt7))
                {
                    if (sizeInt7 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt7
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum8.Text, out int sizeInt8))
                {
                    if (sizeInt8 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt8
                        });
                    }
                }

                suitAttachments.Add(new Suit_Attachments
                {
                    AttachmentName = txtAttachmentName.Text,
                    Attachment_Sizes = attachment_Sizes,
                    Notes = txtNotes.Text,
                });
                txtAttachmentName.Text = "";
                //this.Size = new System.Drawing.Size(561, 300);
                //this.btnAddSuitAttachment.Enabled = true;
            }

            comboSuitAttachments.DataSource = null;
            comboSuitAttachments.DataSource = suitAttachments;
        }

        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            if (comboSuitAttachments.SelectedIndex == -1)
            {
                MessageBox.Show("لا يوجد اي عناصر لحذفها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var item = comboSuitAttachments.SelectedItem as Suit_Attachments;
                suitAttachments.Remove(item);

                comboSuitAttachments.DataSource = null;
                comboSuitAttachments.DataSource = suitAttachments;
            }
        }

        private void btnUpdateSuit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSuitSize1.Text) == 0)
            {
                MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDecimal(txtSuitSalePrice.Text) > 0 || Convert.ToDecimal(txtSuitRentalPrice.Text) > 0)
            {
                suitsRepository.Update(suitId, new Suit
                {
                    Size1 = Convert.ToInt32(txtSuitSize1.Text),
                    Size2 = Convert.ToInt32(txtSuitSize2.Text),
                    Size3 = Convert.ToInt32(txtSuitSize3.Text),
                    Size4 = Convert.ToInt32(txtSuitSize4.Text),
                    Size5 = Convert.ToInt32(txtSuitSize5.Text),
                    Size6 = Convert.ToInt32(txtSuitSize6.Text),
                    Size7 = Convert.ToInt32(txtSuitSize7.Text),
                    Size8 = Convert.ToInt32(txtSuitSize8.Text),
                    RentalPrice = Convert.ToDecimal(txtSuitRentalPrice.Text),
                    SalePrice = Convert.ToDecimal(txtSuitSalePrice.Text),
                    Attachments = suitAttachments
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
