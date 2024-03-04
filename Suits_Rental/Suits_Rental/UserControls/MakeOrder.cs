using Suits_Rental.Core;
using Suits_Rental.Dtos;
using Suits_Rental.Events;
using Suits_Rental.Forms;
using Suits_Rental.IRepositories;
using Suits_Rental.Models;
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
        private readonly ICustomerRepository customerRepository;
        private readonly IOrderRepository orderRepository;
        List<SuitReadDto> selectedSuits;
        List<AttachmentSizesDto> attachmentSizes;
        decimal totalPriceAmount;

        public MakeOrder()
        {
            InitializeComponent();

            suitsRepository = new SuitsRepository();
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            selectedSuits = new List<SuitReadDto>();
            attachmentSizes = new List<AttachmentSizesDto>();
            totalPriceAmount = 0;
        }

        #region Txt Box Events
        private void TxtBoxMinZero_Leave(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text.Length == 0)
            {
                txtBox.Text = "0";
            }
            if (comboOrderType.SelectedIndex == 0)
            {
                FillPricesLables(0);
            }
            else if (comboOrderType.SelectedIndex == 1)
            {
                FillPricesLables(1);
            }
        }

        private void TxtBoxPreventNonNumberic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtPaidAmount.Text.Length > 0)
            {
                lblRmainAmount.Text = $"{totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text)}";
            }
        }

        private void TxtBoxSelectAll_ClickTapIndex(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.SelectAll();
        }
        #endregion

        #region Get and Load Data
        private void FillComboAllAvailableSuits()
        {
            var availableSuits = suitsRepository.GetAllAvailable();
            if (availableSuits != null)
            {
                comboAllAvailableSuits.Items.Clear();
                comboAllAvailableSuits.Items.AddRange(availableSuits.ToArray());
                comboAllAvailableSuits.DisplayMember = "Id";
            }
        }

        private void FillComboCustomers()
        {
            var customers = customerRepository.GetLastTen();
            if (customers != null)
            {
                comboCustomterName.Items.Clear();
                comboCustomterName.Items.AddRange(customers.ToArray());
                comboCustomterName.DisplayMember = "Name";
            }
        }

        private void FillCustomerInfo()
        {
            if (comboCustomterName.SelectedItem != null)
            {
                Customer customer = comboCustomterName.SelectedItem as Customer;
                if (customer != null)
                {
                    txtCustomerName.Text = customer.Name;
                    txtCustomerAddress.Text = customer.Address;
                    txtCustomerPhone.Text = customer.Phone;
                }
            }
        }

        private void ClearCustomerInfo()
        {
            if (comboCustomterName.SelectedItem != null)
            {
                Customer customer = comboCustomterName.SelectedItem as Customer;
                if (customer != null)
                {
                    if (customer.Name != txtCustomerName.Text)
                    {
                        txtCustomerAddress.Text = "";
                        txtCustomerPhone.Text = "";
                    }
                }
            }
        }

        private void FillComboSelectedSuits()
        {
            if (selectedSuits.Count > 0)
            {
                comboSelectedSuits.Items.Clear();
                comboSelectedSuits.Items.AddRange(selectedSuits.ToArray());
                comboAllAvailableSuits.DisplayMember = "Id";

                lblSelectedSuitsCount.Text = selectedSuits.Count.ToString();
            }
            else
            {
                comboSelectedSuits.Items.Clear();
                lblSelectedSuitsCount.Text = "0";
            }
        }

        private void FillComboAttachmentsAndSizes()
        {
            if (attachmentSizes.Count > 0)
            {
                comboAttachmentAndSizes.Items.Clear();
                comboAttachmentAndSizes.Items.AddRange(attachmentSizes.ToArray());
            }
            else
            {
                comboAttachmentAndSizes.Items.Clear();
            }
        }

        private void RemoveSuitAttachments()
        {
            if (comboSelectedSuits.SelectedItem != null)
            {
                SuitReadDto suitReadDto = comboSelectedSuits.SelectedItem as SuitReadDto;
                if (suitReadDto != null)
                {
                    var suitAttachments = attachmentSizes.Where(S => S.SuitId == suitReadDto.Id).ToList();
                    foreach (var suitAttachment in suitAttachments)
                    {
                        attachmentSizes.Remove(suitAttachment);
                    }
                    selectedSuits.Remove(suitReadDto);
                    FillComboAttachmentsAndSizes();
                    FillComboSelectedSuits();
                }
            }
        }

        private decimal CalCulateTotalPrice(int orderType)
        {
            decimal totalPrice = 0;

            if (orderType == 0)
            {
                int rentalDays = Convert.ToInt32(txtRentDays.Text);
                foreach (var item in selectedSuits)
                {
                    decimal rentalPrice = (item.RentalPrice is null) ? 0 : Convert.ToDecimal(item.RentalPrice);
                    totalPrice += rentalDays * rentalPrice;
                }
            }
            else if (orderType == 1)
            {
                foreach (var item in selectedSuits)
                {
                    decimal salePrice = (item.SalePrice is null) ? 0 : Convert.ToDecimal(item.SalePrice);
                    totalPrice += salePrice;
                }
            }
            totalPrice = totalPrice - (totalPrice * (Convert.ToDecimal(txtDiscount.Text) / 100));

            return totalPrice;
        }

        private void FillPricesLables(int orderType)
        {
            totalPriceAmount = CalCulateTotalPrice(orderType);
            lblTotalPrice.Text = totalPriceAmount.ToString("F2");
            lblRmainAmount.Text = (totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text)).ToString("F2");

            if (Convert.ToDecimal(txtPaidAmount.Text) > totalPriceAmount)
            {
                MessageBox.Show("هذا المبلغ أكبر من المبلغ الكلي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaidAmount.Text = totalPriceAmount.ToString("F2");
                lblRmainAmount.Text = "0";
            }
        }

        private void ClearData()
        {
            selectedSuits.Clear();
            attachmentSizes.Clear();
            totalPriceAmount = 0;
            comboSelectedSuits.Items.Clear();
            comboAttachmentAndSizes.Items.Clear();
            txtPaidAmount.Text = "0";
            txtDiscount.Text = "0";
            txtCustomerAddress.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtBetAttachment.Text = "";
            comboAllAvailableSuits.SelectedIndex = -1;
            lblRmainAmount.Text = "0";
            lblTotalPrice.Text = "0";
            lblSelectedSuitsCount.Text = "0";
            txtNotes.Text = "";
            txtRentDays.Text = "0";
        }
        #endregion

        private void ChildForm_DataSend(object sender, DataEventArgs e)
        {
            attachmentSizes.AddRange(e.AttachmentSizesDtos);
        }

        private void OpenSelectSizesForm(SuitReadDto suitReadDto)
        {
            selectedSuits.Add(suitReadDto);
            FillComboSelectedSuits();
            lblSelectedSuitsCount.Text = selectedSuits.Count.ToString();

            SelectAttachmentSizes frmAttachmentSizes = new SelectAttachmentSizes(suitReadDto.Id, attachmentSizes);
            frmAttachmentSizes.DataSend += ChildForm_DataSend;
            frmAttachmentSizes.ShowDialog();

            FillComboAttachmentsAndSizes();

            if (comboOrderType.SelectedIndex == 0)
            {
                FillPricesLables(0);
            }
            else if (comboOrderType.SelectedIndex == 1)
            {
                FillPricesLables(1);
            }
        }

        #region UC Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void UCMakeOrder_Load(object sender, EventArgs e)
        {
            FillComboAllAvailableSuits();
            FillComboCustomers();
            FillCustomerInfo();
        }

        private void comboAllAvailableSuits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAllAvailableSuits.SelectedItem != null)
            {
                SuitReadDto suitReadDto = comboAllAvailableSuits.SelectedItem as SuitReadDto;

                if (suitReadDto != null)
                {
                    if (!selectedSuits.Exists(S => S.Id == suitReadDto.Id))
                    {
                        OpenSelectSizesForm(suitReadDto);
                    }
                    else
                    {
                        var dialoagResult = MessageBox.Show("تم اختيار هذه البدلة مسبقا, هل تريد إضافتها مرة أخري للأوردر ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialoagResult == DialogResult.Yes)
                        {
                            OpenSelectSizesForm(suitReadDto);
                        }
                    }
                }

            }
        }

        private void btnDeleteSuit_Click(object sender, EventArgs e)
        {
            RemoveSuitAttachments();
            if (comboOrderType.SelectedIndex == 0)
            {
                FillPricesLables(0);
            }
            else if (comboOrderType.SelectedIndex == 1)
            {
                FillPricesLables(1);
            }
        }

        private void comboCustomterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCustomerInfo();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            ClearCustomerInfo();
        }

        private void comboOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOrderType.SelectedIndex == 0)
            {
                tlpRentalType.Visible = true;
                FillPricesLables(0);
            }
            else if (comboOrderType.SelectedIndex == 1)
            {
                tlpRentalType.Visible = false;
                FillPricesLables(1);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (selectedSuits.Count == 0)
            {
                MessageBox.Show("برجاء اختيار بدلة واحدة علي الأقل", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboOrderType.SelectedIndex == -1)
                {
                    MessageBox.Show("برجاء اختيار نوع الأوردر", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int orderType = comboOrderType.SelectedIndex;
                    // to check that the user even select sale type or must enter bet attachment and rent days if type is rental
                    if ((txtBetAttachment.Text.Length > 1 && Convert.ToDecimal(txtRentDays.Text) > 1) || orderType == 1)
                    {
                        // to check if there is no selectable customer or the selectable cutomer phone is not the same of the entered phone 
                        // will add new customer if one of them
                        // else will add the order to selectable customer
                        if (comboCustomterName.SelectedIndex == -1 || ((Customer)comboCustomterName.SelectedItem).Phone != txtCustomerPhone.Text)
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
                                    SuitsDto = selectedSuits,
                                    AttachmentsSizes = attachmentSizes,
                                    UserName = CurrentUser.Txtusername,
                                    Discount = Convert.ToInt32(txtDiscount.Text),
                                    Notes = txtNotes.Text,
                                    Date = dateTimeOrderDate.Value
                                });
                                if (!check)
                                {
                                    MessageBox.Show("برجاء مراجعة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    Invoice frmInvoice = new Invoice(orderRepository.GetLastOrderId());
                                    frmInvoice.ShowDialog();
                                    ClearData();
                                    FillComboCustomers();
                                }
                            }
                        }
                        else
                        {
                            bool check = orderRepository.MakeWithOldCustomer(new OrderDto
                            {
                                CustomerId = ((Customer)comboCustomterName.SelectedItem).Id,
                                Type = (orderType == 0) ? "تأجير" : "بيع",
                                RentDays = Convert.ToInt32(txtRentDays.Text),
                                TotalPrice = totalPriceAmount,
                                PaidAmount = Convert.ToDecimal(txtPaidAmount.Text),
                                RemainAmount = totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text),
                                BetAttachment = txtBetAttachment.Text,
                                SuitsDto = selectedSuits,
                                AttachmentsSizes = attachmentSizes,
                                UserName = CurrentUser.Txtusername,
                                Discount = Convert.ToInt32(txtDiscount.Text),
                                Notes = txtNotes.Text,
                                Date = dateTimeOrderDate.Value
                            });
                            if (!check)
                            {
                                MessageBox.Show("برجاء مراجعة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                Invoice frmInvoice = new Invoice(orderRepository.GetLastOrderId());
                                frmInvoice.ShowDialog();
                                ClearData();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال المرفق المرهن وعدد أيام الرهن", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }
}
