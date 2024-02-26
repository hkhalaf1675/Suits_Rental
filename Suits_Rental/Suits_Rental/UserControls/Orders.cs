using Suits_Rental.Dtos;
using Suits_Rental.Forms;
using Suits_Rental.IRepositories;
using Suits_Rental.Repositories;
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
    public partial class Orders : UserControl
    {
        private readonly IOrderRepository orderRepository;
        public Orders()
        {
            InitializeComponent();

            orderRepository = new OrderRepository();
        }

        private void GetData(List<OrderReadDto> orders)
        {
            dataGridAllOrders.Rows.Clear();

            if (orders != null)
            {
                foreach (var order in orders)
                {
                    if (order != null)
                    {
                        dataGridAllOrders.Rows.Add(order.Id, order.CustomerName, order.Date.ToString("yyyy/mm/dd"), (order?.RentDays != null) ? order.RentDays : "0", order?.TotalPrice, order?.RemainAmount, (order?.BetAttachment != null) ? order.BetAttachment : "N/A");
                    }
                }
            }
        }
        private void ChildForm_Closed(object sender, FormClosedEventArgs e)
        {
            GetData(orderRepository.GetReport(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1)));
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MakeOrder frmMakeOrder = new MakeOrder();
            frmMakeOrder.FormClosed += ChildForm_Closed;
            frmMakeOrder.ShowDialog();
        }

        private void btnReturnSuit_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(numericSearchOrderNum.Value);
            if (orderId > 0)
            {
                var order = orderRepository.GetById(orderId);
                if (order != null)
                {
                    if (order.Status == false)
                    {
                        ReturnSuit frmReturnSuits = new ReturnSuit(orderId);
                        frmReturnSuits.FormClosed += ChildForm_Closed;
                        frmReturnSuits.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("تم إسترجاع هذا الأوردر مسبقا","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void Orders_Load(object sender, EventArgs e)
        {
            GetData(orderRepository.GetReport(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1)));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(numericSearchOrderNum.Value);
            if (orderId > 0)
            {
                var order = orderRepository.GetById(orderId);
                if (order != null)
                {
                    dataGridAllOrders.Rows.Clear();
                    dataGridAllOrders.Rows.Add(order.Id, order.CustomerName, order.Date.ToString("yyyy/mm/dd"), (order?.RentDays != null) ? order.RentDays : "0", order?.TotalPrice, order?.RemainAmount, (order?.BetAttachment != null) ? order.BetAttachment : "N/A");
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
            GetData(orderRepository.GetAll());
        }

        private void btnGetAllOutside_Click(object sender, EventArgs e)
        {
            dataGridAllOrders.Rows.Clear();
            var orders = orderRepository.GetUnreturned();
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    if (order != null)
                    {
                        dataGridAllOrders.Rows.Add(order.Id, order.CustomerName, order.Date.ToString("yyyy/mm/dd"), (order?.RentDays != null)? order.RentDays: "0", order?.TotalPrice, order?.RemainAmount, (order?.BetAttachment != null)? order.BetAttachment :"N/A");
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
                        var checkProcessSuccess = orderRepository.Delete(orderId);
                        if (checkProcessSuccess)
                        {
                            MessageBox.Show(" تم إلغاء الأوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetData(orderRepository.GetReport(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1)));
                        }
                        else
                        {
                            MessageBox.Show("برجاء التأكد من الاوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dataGridAllOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex < dataGridAllOrders.Columns.Count)
            {
                dataGridAllOrders.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
