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

        private void GetData()
        {
            dataGridAllOrders.Rows.Clear();
            var orders = orderRepository.GetAll();
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    if (order != null)
                    {
                        dataGridAllOrders.Rows.Add(order.Id, order.CustomerName, order.Date.ToString("yyyy/mm/dd"), order.RentDays, order.TotalPrice, order.RemainAmount, order.BetAttachment);
                    }
                }
            }
        }
        private void ChildForm_Closed(object sender, FormClosedEventArgs e)
        {
            GetData();
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
                        frmReturnSuits.Show();
                    }
                    else
                    {
                        MessageBox.Show("تم إسترجاع هذا الأوردر مسبقا");
                    }
                }
                else
                {
                    MessageBox.Show("برجاء التأكد من رقم الأوردر");
                }
            }
            else
            {
                MessageBox.Show("برجاء التأكد من رقم الأوردر");
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            GetData();
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
                    dataGridAllOrders.Rows.Add(order.Id, order.CustomerName, order.Date.ToString("yyyy/mm/dd"), order.RentDays, order.TotalPrice, order.RemainAmount, order.BetAttachment);
                }
                else
                {
                    MessageBox.Show("لا يوجد أوردر مسجل بهذا الرقم");
                }
            }
            else
            {
                MessageBox.Show("برجاء التأكد من رقم الأوردر");
            }
        }

        private void btnGetAllOrders_Click(object sender, EventArgs e)
        {
            GetData();
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
                        dataGridAllOrders.Rows.Add(order.Id, order.CustomerName, order.Date.ToString("yyyy/mm/dd"), order.RentDays, order.TotalPrice, order.RemainAmount, order.BetAttachment);
                    }
                }
            }
        }
    }
}
