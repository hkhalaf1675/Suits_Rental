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
    public partial class MakeOrder : UserControl
    {
        private readonly ISuitsRepository suitsRepository;
        private readonly IOrderRepository orderRepository;
        List<int> selectedSuits;
        decimal totalPriceAmount;

        public MakeOrder()
        {
            InitializeComponent();
            suitsRepository = new SuitsRepository();
            orderRepository = new OrderRepository();
            selectedSuits = new List<int>();
            totalPriceAmount = 0;
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            FillComboSuits();
            panelRentType.Visible = false;

            lblDeleteSuitText.Visible = false;
            comboSelectedDeleteSuit.Visible = false;
            btnEnsureDeleteSuit.Visible = false;
        }
        private void FillComboSuits()
        {
            comboSuits.DataSource = null;
            comboSuits.DataSource = suitsRepository.GetAllAvailable();
            comboSuits.DisplayMember = "Id";
            comboSuits.ValueMember = "Id";
            comboSuits.SelectedIndex = -1;
        }
        private void FillComboSelectedDeleteSuits()
        {
            comboSelectedDeleteSuit.DataSource = null;
            comboSelectedDeleteSuit.DataSource = selectedSuits;
        }

        private void comboOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOrderType.SelectedIndex == 0)
            {
                panelRentType.Visible = true;

                totalPriceAmount = CalcuateTotalPrice(0);
                lblTotalPrice.Text = $"{totalPriceAmount}";
                lblRmainAmount.Text = $"{totalPriceAmount}";
            }
            else if (comboOrderType.SelectedIndex == 1)
            {
                panelRentType.Visible = false;

                totalPriceAmount = CalcuateTotalPrice(1);
                lblTotalPrice.Text = $"{totalPriceAmount}";
                lblRmainAmount.Text = $"{totalPriceAmount}";
            }
        }

        private decimal CalcuateTotalPrice(int indexType)
        {
            decimal totalPrice = 0;
            foreach (int suitId in selectedSuits)
            {
                var item = suitsRepository.GetById(suitId);
                if (item != null)
                {
                    if (indexType == 0)
                    {
                        var rentalPrice = item.RentalPrice;
                        if (rentalPrice != null)
                        {
                            totalPrice += Convert.ToDecimal(rentalPrice);
                        }
                        else
                        {
                            MessageBox.Show($"البدلة رقم {suitId} ليس لها سعر إيجار");
                        }
                    }
                    else if (indexType == 1)
                    {
                        var salePrice = item.SalePrice;
                        if (salePrice != null)
                        {
                            totalPrice += Convert.ToDecimal(salePrice);
                        }
                        else
                        {
                            MessageBox.Show($"البدلة رقم {suitId} ليس لها سعر بيع");
                        }
                    }
                }
            }
            return totalPrice;
        }

        private void numericDiscount_ValueChanged(object sender, EventArgs e)
        {
            totalPriceAmount = totalPriceAmount - (totalPriceAmount * (numericDiscount.Value / 100));
            lblRmainAmount.Text = $"{totalPriceAmount}";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= totalPriceAmount)
            {
                lblRmainAmount.Text = $"{totalPriceAmount - numericUpDown1.Value}";

            }
            else
            {
                MessageBox.Show("هذا المبلغ أكبر من المبلغ الكلي");
                numericUpDown1.Value = totalPriceAmount;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (selectedSuits.Count > 0)
            {
                if (comboOrderType.SelectedIndex == -1)
                {
                    MessageBox.Show("برجاء اختار نوع الاوردر تأجير أو بيع");
                }
                else
                {
                    int orderType = comboOrderType.SelectedIndex;
                    bool check = orderRepository.Make(new OrderDto
                    {
                        Type = (orderType == 0) ? "تأجير" : "بيع",
                        RentDays = Convert.ToInt32(numericRentDays.Value),
                        TotalPrice = totalPriceAmount,
                        PaidAmount = numericUpDown1.Value,
                        RemainAmount = totalPriceAmount - numericUpDown1.Value,
                        BetAttachment = txtBetAttachment.Text,
                        CustomerName = txtCustomerName.Text,
                        Address = txtCustomerAddress.Text,
                        PhoneNumber = txtCustomerPhone.Text,
                        SuitsIDs = selectedSuits
                    });

                    if (!check)
                    {
                        MessageBox.Show("برجاء مراجعة البيانات المدخلة");
                    }
                    else
                    {
                        Invoice frmInvoice = new Invoice();
                        frmInvoice.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("برجاء اختيار بدلة علي الأقل");
            }
        }

        private void btnEnsureDeleteSuit_Click(object sender, EventArgs e)
        {
            if (comboSelectedDeleteSuit.SelectedIndex == -1)
            {
                MessageBox.Show("برجاء اختيار بدلة");
            }
            else
            {
                var selectedSuit = comboSelectedDeleteSuit.SelectedItem as int?;
                if (selectedSuit != null)
                {
                    selectedSuits.Remove(Convert.ToInt32(selectedSuit));
                    MessageBox.Show("suit deleted");
                    FillComboSelectedDeleteSuits();
                    lblSelectedSuits.Text = $"عدد البدل المختارة : {selectedSuits.Count}";
                    comboSuits.SelectedIndex = -1;
                }
            }
        }

        private void comboSuits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedItem = comboSuits.SelectedItem as SuitReadDto;
            if (selectedItem != null)
            {
                if (!selectedSuits.Contains(selectedItem.Id))
                {
                    selectedSuits.Add(selectedItem.Id);
                    lblSelectedSuits.Text = $"عدد البدل المختارة : {selectedSuits.Count}";
                }
            }
            FillComboSelectedDeleteSuits();
            lblDeleteSuitText.Visible = true;
            comboSelectedDeleteSuit.Visible = true;
            btnEnsureDeleteSuit.Visible = true;
        }
    }
}
