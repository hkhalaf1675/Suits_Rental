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
    public partial class ReturnSuit : Form
    {
        private readonly IOrderRepository orderRepository;
        int orderId;
        OrderReadDto order;

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
            orderRepository = new OrderRepository();
            orderId = id;
        }

        private void PanelLayout_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GetData()
        {
            order = orderRepository.GetById(orderId);
            if (order != null)
            {
                lblOrderNum.Text = $"#No {orderId}";
                lblCustomerName.Text = order.CustomerName;
                lblOrderDate.Text = order.Date.ToString("yyyy/MM/dd");
                lblPhoneNumber.Text = order.PhoneNumber;
                lblAddress.Text = order.Address;
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
            bool check = orderRepository.GetRemainAmount(orderId);
            if (check)
            {
                MessageBox.Show("تم تصفير المبلغ المتبقي");
                GetData();
            }
        }

        private void btnReturnSuit_Click(object sender, EventArgs e)
        {
            if (order.RemainAmount > 0)
            {
                var checkResult = MessageBox.Show($"يوجد مبلغ {order.RemainAmount} متبقي من هذا الأوردر", "تأكيد إرجاع البدل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (checkResult == DialogResult.Yes)
                {
                    bool check = orderRepository.ReturnOrderSuits(orderId);
                    if (check)
                    {
                        MessageBox.Show("تم إرجاع البدل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                bool check = orderRepository.ReturnOrderSuits(orderId);
                if (check)
                {
                    MessageBox.Show("تم إرجاع البدل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void PanelLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
