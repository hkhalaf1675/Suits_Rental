using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Forms;
using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suits_Rental.UserControls
{
    public partial class UCOrders : UserControl
    {
        private readonly ApplicationDbContext context;

        public UCOrders()
        {
            InitializeComponent();

            context = new ApplicationDbContext();
        }

        private void GetData(List<Order> orders)
        {
            dataGridAllOrders.Rows.Clear();

            if (orders != null)
            {
                foreach (var order in orders)
                {
                    if (order != null)
                    {
                        dataGridAllOrders.Rows.Add(order.Id, order.Customer.Name, order.Date.ToString("yyyy/MM/dd"), order.RentDays, order?.TotalPrice, order?.RemainAmount, (order?.BetAttachment != null) ? order.BetAttachment : "N/A");
                    }
                }
            }
        }

        private void ChildForm_Closed(object sender, FormClosedEventArgs e)
        {
            GetData(getOrders());
        }

        private void btnReturnSuit_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(txtOrderId.Text);
            if (orderId > 0)
            {
                var order = context.Orders.FirstOrDefault(O => O.Id == orderId);
                if (order != null)
                {
                    if (order.Status == Models.Status.Outside)
                    {
                        ReturnSuit frmReturnSuits = new ReturnSuit(orderId);
                        frmReturnSuits.FormClosed += ChildForm_Closed;
                        frmReturnSuits.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("هذا الأوردر تم إسترجاعه مسبقاً أو بيع لا يمكن إسترجاعه يمكن إلغاه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UCOrders_Load(object sender, EventArgs e)
        {
            GetData(getOrders());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(txtOrderId.Text);
            if (orderId > 0)
            {
                var order = context.Orders
                    .Include(O => O.OrderSuits)
                    .Include(O => O.Customer)
                    .Where(O => O.Id == orderId)
                    .FirstOrDefault();
                if (order != null)
                {
                    dataGridAllOrders.Rows.Clear();
                    dataGridAllOrders.Rows.Add(order.Id, order.Customer.Name, order.Date.ToString("yyyy/MM/dd"), (order?.RentDays != null) ? order.RentDays : "0", order?.TotalPrice, order?.RemainAmount, (order?.BetAttachment != null) ? order.BetAttachment : "N/A");
                }
                else
                {
                    MessageBox.Show("لا يوجد أوردر مسجل بهذا الرقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("برجاء التأكد من رقم الأوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetAllOrders_Click(object sender, EventArgs e)
        {
            var allOrders = context.Orders
                .Include(O => O.Customer)
                .OrderByDescending(O => O.Date)
                .Take(20)
                .ToList();

            GetData(allOrders);
        }

        private void btnGetAllOutside_Click(object sender, EventArgs e)
        {
            dataGridAllOrders.Rows.Clear();

            var outsideOrders = context.Orders
                .Include(O => O.Customer)
                .Where(O => O.Status == Models.Status.Outside)
                .OrderByDescending(O => O.Date)
                .ToList();

            if (outsideOrders != null)
            {
                foreach (var order in outsideOrders)
                {
                    if (order != null)
                    {
                        dataGridAllOrders.Rows.Add(order.Id, order.Customer.Name, order.Date.ToString("yyyy/mm/dd"), order.RentDays , order?.TotalPrice, order?.RemainAmount, (order?.BetAttachment != null) ? order.BetAttachment : "N/A");
                    }
                }
            }
        }

        private void dataGridAllOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridAllOrders.Rows[e.RowIndex].Cells[0].Value);

                if (e.ColumnIndex == dataGridAllOrders.Columns["btnPrintInvoice"].Index)
                {
                    Invoice frmInvoice = new Invoice(orderId);
                    frmInvoice.ShowDialog();
                }
                else if (e.ColumnIndex == dataGridAllOrders.Columns["btnDeleteOrder"].Index)
                {
                    var deleteOrderCheck = MessageBox.Show($"هل تريد حذف الأوردر رقم {orderId}", "تأكيد حذف الأوردر", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (deleteOrderCheck == DialogResult.Yes)
                    {
                         DeleteOrder(orderId);
                    }
                }
                else if (e.ColumnIndex == dataGridAllOrders.Columns["btnDetails"].Index)
                {
                    OrderDetails frmOrderDetails = new OrderDetails(orderId);
                    frmOrderDetails.ShowDialog();
                }
            }
        }

        private void dataGridAllOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < dataGridAllOrders.Columns.Count)
            {
                dataGridAllOrders.Rows[e.RowIndex].Selected = true;
                txtOrderId.Text = dataGridAllOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void txtOrderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOrderId_Leave(object sender, EventArgs e)
        {
            if (txtOrderId.Text.Length == 0)
            {
                txtOrderId.Text = "0";
            }
        }

        private List<Order> getOrders()
        {
            return context.Orders
                .Include(O => O.Customer)
                .Where(O => O.Date >= DateTime.Now.AddDays(-7) && O.Date <= DateTime.Now.AddDays(30))
                .OrderByDescending(O => O.Date)
                .ToList();
        }

        void DeleteOrder(int orderId)
        {
            var order = context.Orders
                .Include(O => O.OrderSuits)
                .Include(O => O.SuitBooks)
                .ThenInclude(SB => SB.OrderAttachmentSizes)
                .FirstOrDefault(O => O.Id == orderId);

            if (order == null)
            {
                MessageBox.Show("برجاء التأكد من الاوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("برجاء التأكد من الاوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("برجاء التأكد من الاوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("برجاء التأكد من الاوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            context.SuitOrders.RemoveRange(order.OrderSuits);
            context.Orders.Remove(order);
            try
            {
                context.SaveChanges();

                MessageBox.Show(" تم إلغاء الأوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData(getOrders());
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء التأكد من الاوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
