using Suits_Rental.Dtos;
using Suits_Rental.Forms;
using Suits_Rental.IRepositories;
using Suits_Rental.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suits_Rental.UserControls
{
    public partial class MainScreen : UserControl
    {
        private readonly ISuitsRepository suitsRepository;
        private readonly IOrderRepository orderRepository;
        public MainScreen()
        {
            InitializeComponent();

            suitsRepository = new SuitsRepository();
            orderRepository = new OrderRepository();
        }

        private void FillDataGridSuits(List<SuitReadDto> suits)
        {
            dataGridSuits.Rows.Clear();

            foreach (var suit in suits)
            {
                dataGridSuits.Rows.Add(suit.Id, suit.Size, suit.RentalPrice, suit.SalePrice, suit.AttachmentsCount, suit.AvailableCount);
            }
        }
        private void GetData()
        {
            FillDataGridSuits(suitsRepository.GetAll());

            lblAvailableSuits.Text = suitsRepository.GetAvailableSuitsCount().ToString();
            lblOutsideSuits.Text = suitsRepository.GetOutsideSuitsCount().ToString();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnSuitSearch_Click(object sender, EventArgs e)
        {
            int suitId = Convert.ToInt32(txtSuitId.Text);
            if (suitId == 0)
            {
                FillDataGridSuits(suitsRepository.GetAll());
            }
            else
            {
                var suit = suitsRepository.GetById(suitId);
                if (suit == null)
                {
                    MessageBox.Show("لا توجد بدلة بهذا الرقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridSuits.Rows.Clear();
                    dataGridSuits.Rows.Add(suit.Id, suit.SuitSize, suit.RentalPrice, suit.SalePrice, suit.SuitAttachments.Count, suit.Available );
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            MakeOrder frmMakeOrder = new MakeOrder();
            frmMakeOrder.FormClosed += ChildForm_FormCLosed;
            frmMakeOrder.ShowDialog();
        }

        private void btnReturnSuit_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(txtOrderId.Text);
            var order = orderRepository.GetById(orderId);

            if (order == null)
            {
                MessageBox.Show("لا يوجد أوردر بهذا الرقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (order.Status == true)
                {
                    MessageBox.Show("تم استرجاع هذا الأوردر مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ReturnSuit frmReturnSuit = new ReturnSuit(orderId);
                    frmReturnSuit.ShowDialog();
                }
            }
        }

        private void btnAddNewSuit_Click(object sender, EventArgs e)
        {
            ManageSuitForm frmSuit = new ManageSuitForm();
            frmSuit.FormClosed += ChildForm_FormCLosed;
            frmSuit.ShowDialog();
        }

        private void ChildForm_FormCLosed(object? sender, FormClosedEventArgs e)
        {
            GetData();
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
            // Check if the pressed key is not a digit or a control key (like Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If not a digit, cancel the keypress event
                e.Handled = true;
            }
        }
    }
}
