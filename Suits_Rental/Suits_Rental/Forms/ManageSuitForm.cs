using Suits_Rental.Contexts;
using Suits_Rental.Models;
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
        List<Suit_Attachments> suitAttachments;
        List<SuitSize> suitSizes;
        private readonly ApplicationDbContext context;

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
            suitAttachments = new List<Suit_Attachments>();
            suitSizes = new List<SuitSize>();
            context = new ApplicationDbContext();
        }

        //private void btnAddSuitAttachment_Click(object sender, EventArgs e)
        //{
        //    //this.Size = new System.Drawing.Size(560, 590);
        //    //this.btnAddSuitAttachment.Enabled = false;
        //}

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
            if (txtBox.Text.Length == 0)
            {
                txtBox.Text = "0";
            }
        }

        private void TxtBoxPreventNonNumberic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxSelectAll_TabIndex_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.SelectAll();
        }

        private void btnAddSuitSize_Click(object sender, EventArgs e)
        {
            if (txtAddSuitSize.Text.Length == 0 || Convert.ToInt32(txtAddSuitSize.Text) == 0)
            {
                MessageBox.Show("برجاء إدخال المقاس", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                suitSizes.Add(new SuitSize
                {
                    Size = Convert.ToInt32(txtAddSuitSize.Text),
                    AvailableStatus = Status.Inside
                });

                comboSuitSizes.Items.Clear();
                comboSuitSizes.Items.AddRange(suitSizes.ToArray());
                comboSuitSizes.DisplayMember = "Size";

                MessageBox.Show("تم حفظ المقاس بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteSuitSize_Click(object sender, EventArgs e)
        {
            if (comboSuitSizes.SelectedItem is null)
            {
                MessageBox.Show("برجاء اختيار المقاس المراد حذفه", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SuitSize selectedSize = comboSuitSizes.SelectedItem as SuitSize;
                if (selectedSize is not null)
                {
                    suitSizes.Remove(selectedSize);
                    comboSuitSizes.Items.Clear();
                    comboSuitSizes.Items.AddRange(suitSizes.ToArray());
                    comboSuitSizes.DisplayMember = "Size";

                    MessageBox.Show("تم حذف المقاس بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
                    if (sizeInt1 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt1,
                            AvailableStatus = Status.Inside
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum2.Text, out int sizeInt2))
                {
                    if (sizeInt2 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt2,
                            AvailableStatus = Status.Inside
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum3.Text, out int sizeInt3))
                {
                    if (sizeInt3 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt3,
                            AvailableStatus = Status.Inside
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum4.Text, out int sizeInt4))
                {
                    if (sizeInt4 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt4,
                            AvailableStatus = Status.Inside
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
                            Size = sizeInt5,
                            AvailableStatus = Status.Inside
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum6.Text, out int sizeInt6))
                {
                    if (sizeInt6 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt6,
                            AvailableStatus = Status.Inside
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum7.Text, out int sizeInt7))
                {
                    if (sizeInt7 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt7,
                            AvailableStatus = Status.Inside
                        });
                    }
                }

                if (int.TryParse(txtAttachmentSizeNum8.Text, out int sizeInt8))
                {
                    if (sizeInt8 > 0)
                    {
                        attachment_Sizes.Add(new Attachment_Sizes()
                        {
                            Size = sizeInt8,
                            AvailableStatus = Status.Inside
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

                comboSuitAttachments.Items.Clear();
                comboSuitAttachments.Items.AddRange(suitAttachments.ToArray());
                comboSuitAttachments.DisplayMember = "AttachmentName";

                //this.Size = new System.Drawing.Size(561, 300);
                //this.btnAddSuitAttachment.Enabled = true;
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
                var item = comboSuitAttachments.SelectedItem as Suit_Attachments;
                suitAttachments.Remove(item);

                comboSuitAttachments.Items.Clear();
                comboSuitAttachments.Items.AddRange(suitAttachments.ToArray());
            }
        }

        private void btnSaveSuit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSuitId.Text) <= 0)
            {
                MessageBox.Show("برجاء ادخال الرقم التعريفي للبدلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int suitId = Convert.ToInt32(txtSuitId.Text);
                var checkExists = context.Suits.FirstOrDefault(S => S.Id == suitId);
                if (checkExists != null)
                {
                    MessageBox.Show("هذا الرقم التعريفي موجود, برجاء اختيار رقم أخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (suitSizes.Count == 0)
                    {
                        MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Convert.ToDecimal(txtSuitRentalPrice.Text) > 0 || Convert.ToDecimal(txtSuitSalePrice.Text) > 0)
                    {
                        context.Suits.Add(new Suit
                        {
                            Id = suitId,
                            RentalPrice = Convert.ToDecimal(txtSuitRentalPrice.Text),
                            SalePrice = Convert.ToDecimal(txtSuitSalePrice.Text),
                            AvailableCounter = suitSizes.Count,
                            Attachments = suitAttachments,
                            SuitSizes = suitSizes,
                        });

                        try
                        {
                            context.SaveChanges();
                            MessageBox.Show("تمت إضافة البدلة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(" برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع ومقاسات و مرفقات البدلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال مقاس البدلة وسعر الإيجار أو البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
