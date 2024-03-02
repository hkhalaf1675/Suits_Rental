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
    public partial class OrderDetails : Form
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


        public OrderDetails(int id)
        {
            InitializeComponent();

            orderRepository = new OrderRepository();
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
            var order = orderRepository.GetById(orderId);
            if (order != null)
            {
                lblOrderNo.Text = $"#NO {orderId}";
                lblOrderDate.Text = order.Date.ToString("yyyy/MM/dd");

                lblCustomerName.Text = order.CustomerName;
                lblCustomerPhone.Text = order.PhoneNumber;
                lblCustomerAddress.Text = order.Address;

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

                if (order.AttachmentsSizes != null)
                {
                    comboAttachmentsAndSizes.Items.Clear();
                    comboAttachmentsAndSizes.Items.AddRange(order.AttachmentsSizes.ToArray());
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
            bool check = orderRepository.GetRemainAmount(orderId);
            if (check)
            {
                MessageBox.Show("تم تصفير المبلغ المتبقي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData();
            }
        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
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
    }
}
