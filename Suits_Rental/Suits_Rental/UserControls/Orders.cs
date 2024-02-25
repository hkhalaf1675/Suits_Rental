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

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MakeOrder frmMakeOrder = new MakeOrder();
            frmMakeOrder.Show();
        }

        private void btnReturnSuit_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(numericReturnOrderNum.Value);
            if (orderId > 0)
            {
                var order = orderRepository.GetById(orderId);
                if(order != null)
                {
                    ReturnSuit frmReturnSuits = new ReturnSuit(orderId);
                    frmReturnSuits.Show();
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
    }
}
