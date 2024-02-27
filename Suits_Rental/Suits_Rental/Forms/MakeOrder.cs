using Suits_Rental.Core;
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

        #region Layout and Cancel Events
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
        #endregion

        #region Fill Components Methods
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
            comboCustomerName.Items.Clear();
            comboCustomerName.Items.Add("");
            comboCustomerName.Items.AddRange(customers.ToArray());
            comboCustomerName.DisplayMember = "Name";
            if (customers.Count > 0)
            {
                comboCustomerName.SelectedIndex = 1;
            }
        }

        private void FillPricesLables(int orderType)
        {
            totalPriceAmount = CalcuateTotalPrice(orderType);
            lblTotalPrice.Text = $"{totalPriceAmount}";
            lblRmainAmount.Text = $"{totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text)}";

            if (Convert.ToDecimal(txtPaidAmount.Text) > totalPriceAmount)
            {
                MessageBox.Show("هذا المبلغ أكبر من المبلغ الكلي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaidAmount.Text = totalPriceAmount.ToString("F2");
                lblRmainAmount.Text = "0";
            }
        }
        private void FillCustomerData()
        {
            if (comboCustomerName.SelectedIndex > 0)
            {
                Customer selectedCustomer = (Customer)comboCustomerName.SelectedItem;
                if (selectedCustomer != null)
                {
                    txtCustomerPhone.Text = selectedCustomer.Phone;
                    txtCustomerAddress.Text = selectedCustomer.Address;
                }
            }
        }
        #endregion

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
                        if (rentalPrice != null && rentalPrice > 0)
                        {
                            totalPrice += Convert.ToDecimal(rentalPrice) * Convert.ToDecimal(txtRentDays.Text);
                        }
                        else
                        {
                            MessageBox.Show($"البدلة رقم {suitId} ليس لها سعر إيجار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (indexType == 1)
                    {
                        var salePrice = item.SalePrice;
                        if (salePrice != null && salePrice > 0)
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
            decimal discount = Convert.ToDecimal(txtDiscount.Text);
            totalPrice = totalPrice - (totalPrice * (discount / 100));

            return totalPrice;
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

        #region Suits Components Events
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
        #endregion

        #region Customer Components Events
        private void comboCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboCustomerName.SelectedIndex > 0)
            {
                FillCustomerData();
            }
            else
            {
                txtCustomerAddress.Text = "";
                txtCustomerPhone.Text = "";
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Length > 0)
            {
                FillComboCustomerName(customerRepository.SearchByName(txtCustomerName.Text));
            }
            if (txtCustomerName.Text.Length > 0 && comboCustomerName.SelectedIndex == 0)
            {
                txtCustomerAddress.Text = "";
                txtCustomerPhone.Text = "";
            }
        }

        private void comboCustomerName_TextChanged(object sender, EventArgs e)
        {
            FillCustomerData();
        }
        #endregion

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

        #region Text Box Events 
        private void TxtBoxPreventNonNumberic_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit or a control key (like Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If not a digit, cancel the keypress event
                e.Handled = true;
            }
        }

        private void TxtBoxSelectAll_Click_TabIndexChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.SelectAll();
        }

        private void TxtBoxMinZero_Leave(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text.Length == 0)
            {
                txtBox.Text = "0";
            }
            else
            {
                if (comboOrderType.SelectedIndex == 0)
                {
                    FillPricesLables(0);
                }
                else if (comboOrderType.SelectedIndex == 1)
                {
                    FillPricesLables(1);
                }
            }
        }
        private void txtPaidAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPaidAmount.Text.Length > 0)
            {
                lblRmainAmount.Text = $"{totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text)}";
            }
        }
        #endregion

        private void Invoice_FormClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // to check that the user already select one suit at least
            if (selectedSuits.Count > 0)
            {
                // to check that user select the type of order
                if (comboOrderType.SelectedIndex == -1)
                {
                    MessageBox.Show("برجاء اختار نوع الاوردر تأجير أو بيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // store the order type index to store the type in the data
                    int orderType = comboOrderType.SelectedIndex;

                    // to check that the user even select sale type or must enter bet attachment and rent days if type is rental
                    if ((txtBetAttachment.Text.Length > 1 && Convert.ToDecimal(txtRentDays.Text) > 1) || orderType == 1)
                    {
                        // to check if there is no selectable customer or the selectable cutomer phone is not the same of the entered phone 
                        // will add new customer if one of them
                        // else will add the order to selectable customer
                        if (comboCustomerName.SelectedIndex == -1 || ((Customer)comboCustomerName.SelectedItem).Phone != txtCustomerPhone.Text)
                        {
                            if (txtCustomerName.Text.Length == 0 || txtCustomerAddress.Text.Length == 0 || txtCustomerPhone.Text.Length == 0)
                            {
                                MessageBox.Show("برجاء ادخال بيانات العميل كاملة", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                bool check = orderRepository.MakeWithNewCustomer(new OrderDto
                                {
                                    Type = (orderType == 0) ? "تأجير" : "بيع",
                                    RentDays = Convert.ToInt32(txtRentDays.Text),
                                    TotalPrice = totalPriceAmount,
                                    PaidAmount = Convert.ToDecimal(txtPaidAmount.Text),
                                    RemainAmount = totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text),
                                    BetAttachment = txtBetAttachment.Text,
                                    CustomerName = txtCustomerName.Text,
                                    Address = txtCustomerAddress.Text,
                                    PhoneNumber = txtCustomerPhone.Text,
                                    SuitsIDs = selectedSuits,
                                    UserName = CurrentUser.Txtusername,
                                    Discount = Convert.ToInt32(txtDiscount.Text)
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
                                RentDays = Convert.ToInt32(txtRentDays.Text),
                                TotalPrice = totalPriceAmount,
                                PaidAmount = Convert.ToDecimal(txtPaidAmount.Text),
                                RemainAmount = totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text),
                                BetAttachment = txtBetAttachment.Text,
                                SuitsIDs = selectedSuits,
                                UserName = CurrentUser.Txtusername,
                                Discount = Convert.ToInt32(txtDiscount.Text)
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
                        MessageBox.Show("برجاء ادخال المرفق المرهن وعدد ايام الرهن", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("برجاء اختيار بدلة علي الأقل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
