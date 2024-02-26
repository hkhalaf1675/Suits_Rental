using Suits_Rental.Dtos;
using Suits_Rental.IRepositories;
using Suits_Rental.Models;
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
    public partial class MakeOrder : Form
    {
        private readonly ISuitsRepository suitsRepository;
        private readonly IOrderRepository orderRepository;
        private readonly ICustomerRepository customerRepository;
        List<int> selectedSuits;
        decimal totalPriceAmount;

        // form layout
        private Button currentButton;

        // form layout
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);
        public MakeOrder()
        {
            InitializeComponent();

            suitsRepository = new SuitsRepository();
            orderRepository = new OrderRepository();
            customerRepository = new CustomerRepository();
            selectedSuits = new List<int>();
            totalPriceAmount = 0;
        }

        private void PanelLayout_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
        private void FillComboCustomerName(List<Customer> customers)
        {
            comboCustomerName.DataSource = null;

            comboCustomerName.DataSource = customers;

            comboCustomerName.DisplayMember = "Name";
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
                            totalPrice += Convert.ToDecimal(rentalPrice) * numericRentDays.Value;
                        }
                        else
                        {
                            MessageBox.Show($"البدلة رقم {suitId} ليس لها سعر إيجار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show($"البدلة رقم {suitId} ليس لها سعر بيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return totalPrice;
        }
        private void FillPricesLables(int orderType)
        {
            totalPriceAmount = CalcuateTotalPrice(orderType);
            lblTotalPrice.Text = $"{totalPriceAmount}";
            lblRmainAmount.Text = $"{totalPriceAmount}";
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            FillComboSuits();
            FillComboCustomerName(customerRepository.GetLastTen());

            panelRentType.Visible = false;
            lblDeleteSuitText.Visible = false;
            comboSelectedDeleteSuit.Visible = false;
            btnEnsureDeleteSuit.Visible = false;
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

            if (comboOrderType.SelectedIndex == 0)
            {
                panelRentType.Visible = true;

                FillPricesLables(0);
            }
            else if (comboOrderType.SelectedIndex == 1)
            {
                panelRentType.Visible = false;

                FillPricesLables(1);
            }
        }

        private void btnEnsureDeleteSuit_Click(object sender, EventArgs e)
        {
            if (comboSelectedDeleteSuit.SelectedIndex == -1)
            {
                MessageBox.Show("برجاء اختيار بدلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var selectedSuit = comboSelectedDeleteSuit.SelectedItem as int?;
                if (selectedSuit != null)
                {
                    selectedSuits.Remove(Convert.ToInt32(selectedSuit));
                    FillComboSelectedDeleteSuits();
                    lblSelectedSuits.Text = $"عدد البدل المختارة : {selectedSuits.Count}";
                    comboSuits.SelectedIndex = -1;
                }
            }
        }

        private void comboOrderType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboOrderType.SelectedIndex == 0)
            {
                panelRentType.Visible = true;

                FillPricesLables(0);
            }
            else if (comboOrderType.SelectedIndex == 1)
            {
                panelRentType.Visible = false;

                FillPricesLables(1);
            }
        }

        private void numericDiscount_ValueChanged(object sender, EventArgs e)
        {
            totalPriceAmount = totalPriceAmount - (totalPriceAmount * (numericDiscount.Value / 100));
            lblRmainAmount.Text = totalPriceAmount.ToString("F2");
        }

        private void numericPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            if (numericPaidAmount.Value <= totalPriceAmount)
            {
                lblRmainAmount.Text = $"{(totalPriceAmount - numericPaidAmount.Value).ToString("F2")}";

            }
            else
            {
                MessageBox.Show("هذا المبلغ أكبر من المبلغ الكلي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericPaidAmount.Value = totalPriceAmount;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (selectedSuits.Count > 0)
            {
                if (comboOrderType.SelectedIndex == -1)
                {
                    MessageBox.Show("برجاء اختار نوع الاوردر تأجير أو بيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int orderType = comboOrderType.SelectedIndex;

                    if ((txtBetAttachment.Text.Length > 0 && numericRentDays.Value > 0) || orderType == 1)
                    {
                        if (comboCustomerName.SelectedIndex == -1)
                        {
                            if(txtCustomerName.Text.Length == 0 || txtCustomerAddress.Text.Length == 0 || txtCustomerPhone.Text.Length == 0)
                            {
                                MessageBox.Show("برجاء ادخال بيانات العميل كاملة", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                            }
                            else
                            {
                                bool check = orderRepository.MakeWithNewCustomer(new OrderDto
                                {
                                    Type = (orderType == 0) ? "تأجير" : "بيع",
                                    RentDays = Convert.ToInt32(numericRentDays.Value),
                                    TotalPrice = totalPriceAmount,
                                    PaidAmount = numericPaidAmount.Value,
                                    RemainAmount = totalPriceAmount - numericPaidAmount.Value,
                                    BetAttachment = txtBetAttachment.Text,
                                    CustomerName = txtCustomerName.Text,
                                    Address = txtCustomerAddress.Text,
                                    PhoneNumber = txtCustomerPhone.Text,
                                    SuitsIDs = selectedSuits
                                });
                                if (!check)
                                {
                                    MessageBox.Show("برجاء مراجعة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    Invoice frmInvoice = new Invoice(orderRepository.GetLastOrderId());
                                    frmInvoice.FormClosed += Invoice_FormClosed;
                                    frmInvoice.ShowDialog();
                                }
                            }
                        }
                        else
                        {
                            bool check = orderRepository.MakeWithOldCustomer(new OrderWriteWithOutCustomerDto
                            {
                                CustomerId = ((Customer)comboCustomerName.SelectedItem).Id,
                                Type = (orderType == 0) ? "تأجير" : "بيع",
                                RentDays = Convert.ToInt32(numericRentDays.Value),
                                TotalPrice = totalPriceAmount,
                                PaidAmount = numericPaidAmount.Value,
                                RemainAmount = totalPriceAmount - numericPaidAmount.Value,
                                BetAttachment = txtBetAttachment.Text,
                                SuitsIDs = selectedSuits
                            });
                            if (!check)
                            {
                                MessageBox.Show("برجاء مراجعة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                Invoice frmInvoice = new Invoice(orderRepository.GetLastOrderId());
                                frmInvoice.FormClosed += Invoice_FormClosed;
                                frmInvoice.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال المرفق المرهن وعدد ايام الرهن","بيانات ناقصة",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("برجاء اختيار بدلة علي الأقل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Invoice_FormClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillCustomerData();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Length > 0)
            {
                FillComboCustomerName(customerRepository.SearchByName(txtCustomerName.Text));
            }
            if(txtCustomerName.Text.Length > 0 && comboCustomerName.SelectedIndex == -1)
            {
                txtCustomerAddress.Text = "";
                txtCustomerPhone.Text = "";
            }
        }

        private void comboCustomerName_TextChanged(object sender, EventArgs e)
        {
            FillCustomerData();
        }

        private void FillCustomerData()
        {
            if (comboCustomerName.SelectedIndex >= 0)
            {
                Customer selectedCustomer = (Customer)comboCustomerName.SelectedItem;
                if (selectedCustomer != null)
                {
                    txtCustomerPhone.Text = selectedCustomer.Phone;
                    txtCustomerAddress.Text = selectedCustomer.Address;
                }
            }
        }

        private void numericRentDays_ValueChanged(object sender, EventArgs e)
        {
            FillPricesLables(0);
        }
    }
}
