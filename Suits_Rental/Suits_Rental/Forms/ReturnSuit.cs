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
    public partial class ReturnSuit : Form
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
        public ReturnSuit(int id)
        {
            InitializeComponent();

            context = new ApplicationDbContext();
            orderId = id;
            order = new Order();
        }

        private void PanelLayout_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GetData()
        {
            order = context.Orders
                .Include(O => O.Customer)
                .FirstOrDefault(O => O.Id == orderId);

            if (order != null)
            {
                lblOrderNum.Text = $"#No {orderId}";
                lblCustomerName.Text = order.Customer.Name;
                lblOrderDate.Text = order.Date.ToString("yyyy/MM/dd");
                lblPhoneNumber.Text = order.Customer.Phone;
                lblAddress.Text = order.Customer.Address;
                lblTotalPrice.Text = $"{order.TotalPrice}";
                lblRemainAmount.Text = $"{order.RemainAmount}";
                lblItemsCount.Text = $"{order.ItemsCount}";
                lblBetAttachment.Text = $"{order.BetAttachment}";

                if (order.RemainAmount > 0)
                {
                    btnGetRemainAmount.Visible = true;
                }
                else
                {
                    btnGetRemainAmount.Visible = false;
                }
                if(order.RentDays > 0)
                {
                    btnReturnSuit.Visible = true;
                }
                else
                {
                    btnReturnSuit.Visible = false;
                }
            }
        }

        private void ReturnSuit_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnMinmize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnReturnSuit_Click(object sender, EventArgs e)
        {
            if (order.RemainAmount > 0)
            {
                var checkResult = MessageBox.Show($"يوجد مبلغ {order.RemainAmount} متبقي من هذا الأوردر", "تأكيد إرجاع البدل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (checkResult == DialogResult.Yes)
                {
                    ReturnOrderSuits(orderId);
                }
            }
            else
            {
                ReturnOrderSuits(orderId);
            }
        }

        void ReturnOrderSuits(int orderId)
        {
            var order = context.Orders
                .Include(O => O.OrderSuits)
                .Include(O => O.SuitBooks)
                .ThenInclude(SB => SB.OrderAttachmentSizes)
                .FirstOrDefault(O => O.Id == orderId);

            if (order == null)
            {
                MessageBox.Show("برجاء مراجعة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var orderSuit in order.OrderSuits)
            {
                if (orderSuit is null)
                {
                    continue;
                }

                var suit = context.Suits
                    .FirstOrDefault(S => S.Id == orderSuit.SuitId);
                if (suit is null)
                {
                    continue;
                }

                if (order.Status == Status.Outside || order.Status == Status.Sale)
                {
                    suit.AvailableCounter++;
                }

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("برجاء مراجعة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (var suitBook in order.SuitBooks)
            {
                if (suitBook is null)
                {
                    continue;
                }

                foreach (var orderAttachmentSize in suitBook.OrderAttachmentSizes)
                {
                    if (orderAttachmentSize is null)
                    {
                        continue;
                    }

                    var attachmentSize = context.Attachment_Sizes.FirstOrDefault(AS => AS.Id == orderAttachmentSize.AttachmentSizeId);
                    if (attachmentSize is null)
                    {
                        continue;
                    }
                    attachmentSize.AvailableStatus = Status.Inside;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("برجاء مراجعة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                var suitSize = context.SuitSizes.FirstOrDefault(SS => SS.Id == suitBook.SuitSizeId);
                if (suitSize is not null)
                {
                    suitSize.AvailableStatus = Status.Inside;
                }
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("برجاء مراجعة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            order.Status = Status.Inside;
            order.RemainAmount = 0;
            order.PaidAmount = order.TotalPrice;

            try
            {
                context.SaveChanges();

                MessageBox.Show("تم إرجاع البدل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء مراجعة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
