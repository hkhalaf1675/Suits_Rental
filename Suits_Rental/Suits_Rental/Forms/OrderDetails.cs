using Microsoft.EntityFrameworkCore;
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
    public partial class OrderDetails : Form
    {
        private readonly ApplicationDbContext context;
        int orderId;
        Order order;

        // form layout
        private Button currentButton;

        // form layout
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);


        public OrderDetails(int id)
        {
            InitializeComponent();

            context = new ApplicationDbContext();
            orderId = id;
        }

        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetData()
        {
            var order = context.Orders
                .Include(O => O.OrderSuits)
                .Include(O => O.Customer)
                .Where(O => O.Id == orderId)
                .FirstOrDefault();

            if (order != null)
            {
                lblOrderNo.Text = $"#NO {orderId}";
                lblOrderDate.Text = order.Date.ToString("yyyy/MM/dd");

                lblCustomerName.Text = order.Customer.Name;
                lblCustomerPhone.Text = order.Customer.Phone;
                lblCustomerAddress.Text = order.Customer.Address;

                lblTotalPrice.Text = order.TotalPrice.ToString("F2");
                lblRemainAmount.Text = order.RemainAmount.ToString("F2");
                if (order.RemainAmount > 0)
                {
                    btnGetRemainAmount.Visible = true;
                }
                else
                {
                    btnGetRemainAmount.Visible = false;
                }
                lblDiscount.Text = $"{order.Discount} %";

                var suitBooks = context.SuitBooks
                    .Include(SB => SB.OrderAttachmentSizes)
                    .ThenInclude(OAS => OAS.Attachment_Size)
                    .ThenInclude(As => As.Attachment)
                    .Where(SB => SB.OrderId == orderId)
                    .ToList();

                comboAttachmentsAndSizes.Items.Clear();
                foreach (var suitBook in suitBooks)
                {
                    if(suitBook is null)
                    {
                        continue;
                    }
                    foreach(var orderAttachmentSize in suitBook.OrderAttachmentSizes)
                    {
                        if(orderAttachmentSize is null)
                        {
                            continue;
                        }
                        if(orderAttachmentSize.Attachment_Size is null)
                        {
                            continue;
                        }
                        comboAttachmentsAndSizes.Items.Add(orderAttachmentSize.Attachment_Size);
                    }
                }

                lblNotes.Text = order.Notes;

                if (order.RentDays > 0)
                {
                    btnReturnOrder.Visible = true;
                    panelRentalType.Visible = true;
                    lblRentDays.Text = order.RentDays.ToString();
                    lblBetAttachment.Text = order.BetAttachment;
                }
                else
                {
                    btnReturnOrder.Visible = false;
                    panelRentalType.Visible = false;
                }
            }
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnGetRemainAmount_Click(object sender, EventArgs e)
        {
            var order = context.Orders.Where(O => O.Id == orderId).FirstOrDefault();
            if (order != null)
            {
                order.PaidAmount = order.TotalPrice;
                order.RemainAmount = 0;

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("تم تصفير المبلغ المتبقي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("لم يتم تصفير المبلغ المتبقي ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {
            if (orderId > 0)
            {
                var order = context.Orders.FirstOrDefault(O => O.Id == orderId);
                if (order != null)
                {
                    if (order.Status == Models.Status.Outside)
                    {
                        ReturnSuit frmReturnSuits = new ReturnSuit(orderId);
                        frmReturnSuits.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(" هذا الأوردر تم إسترجاعه مسبقاً أو بيع لا يمكن إسترجاعه يمكن إلغاه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("برجاء التأكد من رقم الأوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("برجاء التأكد من رقم الأوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
