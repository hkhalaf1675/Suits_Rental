using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Core;
using Suits_Rental.Events;
using Suits_Rental.Forms;
using Suits_Rental.Models;
using System;
using System.Data;


namespace Suits_Rental.UserControls
{
    public partial class MakeOrder : UserControl
    {

        List<Suit> selectedSuits;
        List<Attachment_Sizes> allSelectedAttachmentSizes;
        List<SuitSize> selectedSuitSizes;
        List<SuitBook> selectedSuitsBooks;
        Suit selectedSuit;
        SuitSize selectedSuitSize;

        decimal totalPriceAmount;
        private readonly ApplicationDbContext _dbContext;

        public MakeOrder()
        {
            InitializeComponent();

            selectedSuits = new List<Suit>();
            allSelectedAttachmentSizes = new List<Attachment_Sizes>();
            selectedSuitSizes = new List<SuitSize>();
            selectedSuitsBooks = new List<SuitBook>();
            selectedSuit = new Suit();

            totalPriceAmount = 0;
            _dbContext = new ApplicationDbContext();
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
            var availableSuits = _dbContext.Suits.ToList();

            if (availableSuits != null)
            {
                comboAllAvailableSuits.Items.Clear();
                comboAllAvailableSuits.Items.AddRange(availableSuits.ToArray());
                comboAllAvailableSuits.DisplayMember = "Id";
            }
        }

        private void FillComboCustomers()
        {
            var customers = _dbContext.Customers
                .OrderByDescending(C => C.Id)
                .Take(10).ToList();

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
            if (allSelectedAttachmentSizes.Count > 0)
            {
                comboAttachmentAndSizes.Items.Clear();
                comboAttachmentAndSizes.Items.AddRange(allSelectedAttachmentSizes.ToArray());
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
                Suit suit = comboSelectedSuits.SelectedItem as Suit;
                if (suit != null)
                {
                    var suitAttachments = allSelectedAttachmentSizes.Where(S => S.Attachment.SuitId == suit.Id).ToList();
                    foreach (var suitAttachment in suitAttachments)
                    {
                        allSelectedAttachmentSizes.Remove(suitAttachment);
                    }
                    selectedSuits.Remove(suit);
                    selectedSuitSizes.RemoveAll(SS => SS.SuitId == suit.Id);
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
            allSelectedAttachmentSizes.Clear();
            totalPriceAmount = 0;
            cmbAvailableSuitSizes.Items.Clear();
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
            allSelectedAttachmentSizes.AddRange(e.Attachment_Sizes);

            List<OrderAttachmentSize> selectedOrderSuitSizes = new List<OrderAttachmentSize>();
            foreach(var attachmentSize in e.Attachment_Sizes)
            {
                selectedOrderSuitSizes.Add(new OrderAttachmentSize
                {
                    Attachment_Size = attachmentSize,
                });
            }

            selectedSuitsBooks.Add(new SuitBook
            {
                SuitSize = selectedSuitSize,
                OrderAttachmentSizes = selectedOrderSuitSizes
            });
        }

        private void OpenSelectSizesForm(SuitSize suitSize)
        {
            selectedSuitSize = suitSize;

            SelectAttachmentSizes frmAttachmentSizes = new SelectAttachmentSizes(allSelectedAttachmentSizes, dateTimeOrderDate.Value);
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
            if (comboAllAvailableSuits is not null)
            {
                Suit selectedSuit = comboAllAvailableSuits.SelectedItem as Suit;
                if (selectedSuit is not null)
                {
                    if (selectedSuits.Contains(selectedSuit))
                    {
                        var dialoagResult = MessageBox.Show("تم اختيار هذه البدلة مسبقا, هل تريد إضافتها مرة أخري للأوردر ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }

                    DateTime selectedDate = dateTimeOrderDate.Value;

                    var outsideSuits = _dbContext.SuitBooks
                        .Include(SB => SB.SuitSize)
                        .Where(SB => SB.OrderDate >= selectedDate && SB.ReturnDate <= selectedDate && SB.SuitSize.SuitId == selectedSuit.Id)
                        .Select(SB => SB.SuitSize).ToList();

                    var allSuitSizes = _dbContext.SuitSizes
                        .Where(SS => SS.SuitId == selectedSuit.Id)
                        .ToList();

                    foreach (var item in outsideSuits)
                    {
                        if (allSuitSizes.Contains(item))
                        {
                            allSuitSizes.Remove(item);
                        }
                    }

                    cmbAvailableSuitSizes.Items.Clear();
                    cmbAvailableSuitSizes.Items.AddRange(allSuitSizes.ToArray());
                }
            }
        }

        private void cmbAvailableSuitSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAvailableSuitSizes.SelectedItem != null)
            {
                SuitSize selectedSuitSize = cmbAvailableSuitSizes.SelectedItem as SuitSize;

                if (selectedSuitSize != null)
                {
                    if (selectedSuitSizes.Contains(selectedSuitSize))
                    {
                        MessageBox.Show("تم اختيار هذا المقاس مسبقا!", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {

                        selectedSuits.Add(selectedSuit);
                        FillComboSelectedSuits();
                        lblSelectedSuitsCount.Text = selectedSuits.Count.ToString();

                        selectedSuitSizes.Add(selectedSuitSize);

                        OpenSelectSizesForm(selectedSuitSize);
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
                    if (((txtBetAttachment.Text.Length > 1 && Convert.ToDecimal(txtRentDays.Text) >= 1) || orderType == 1 )&&
                        dateTimeOrderDate.Value>=DateTime.UtcNow)
                    {
                        List<SuitOrder> orderSuits = new List<SuitOrder>();
                        foreach(var suit in selectedSuits)
                        {
                            orderSuits.Add(new SuitOrder
                            {
                                Suit = suit,
                            });
                        }

                        foreach(var selectedSuitBook in selectedSuitsBooks)
                        {
                            selectedSuitBook.OrderDate = dateTimeOrderDate.Value;
                            selectedSuitBook.ReturnDate = dateTimeOrderDate.Value.AddDays(Convert.ToInt32(txtRentDays.Text));
                        }
                        // to check if there is no selectable customer or the selectable cutomer phone is not the same of the entered phone 
                        // will add new customer if one of them
                        // else will add the order to select
                        // able customer
                        if (comboCustomterName.SelectedIndex == -1 || ((Customer)comboCustomterName.SelectedItem).Phone != txtCustomerPhone.Text)
                        {
                            if (txtCustomerName.Text.Length == 0 || txtCustomerAddress.Text.Length == 0 || txtCustomerPhone.Text.Length == 0)
                            {
                                MessageBox.Show("برجاء ادخال بيانات العميل كاملة", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                foreach (var suitBook in selectedSuitsBooks)
                                {
                                    foreach (var orderAttachmentSize in suitBook.OrderAttachmentSizes)
                                    {
                                        var attachmentSize = _dbContext.Attachment_Sizes.FirstOrDefault(AS => AS.Id == orderAttachmentSize.AttachmentSizeId);
                                        if (attachmentSize is not null)
                                        {
                                            attachmentSize.AvailableStatus = (orderType == 0) ? Status.Outside : Status.Sale;
                                            try
                                            {
                                                _dbContext.SaveChanges();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("خطا في ادخال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }

                                    var suitSize = _dbContext.SuitSizes.FirstOrDefault(SS => SS.Id == suitBook.SuitSizeId);
                                    if (suitSize is not null)
                                    {
                                        suitSize.AvailableStatus = (orderType == 0) ? Status.Outside : Status.Sale;
                                        try
                                        {
                                            _dbContext.SaveChanges();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("خطا في ادخال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }

                                foreach (var selectedSuit in selectedSuits)
                                {
                                    var suit = _dbContext.Suits.FirstOrDefault(S => S.Id == selectedSuit.Id);
                                    if (suit is not null)
                                    {
                                        suit.AvailableCounter--;
                                        try
                                        {
                                            _dbContext.SaveChanges();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("خطا في ادخال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }

                                if(orderType == 1)
                                {
                                    selectedSuitsBooks.Clear();
                                }

                                _dbContext.Orders.Add(new Order
                                {
                                    Type = (orderType == 0) ? "تأجير" : "بيع",
                                    Status = (orderType == 0) ? Status.Outside : Status.Sale,
                                    RentDays = Convert.ToInt32(txtRentDays.Text),
                                    TotalPrice = totalPriceAmount,
                                    PaidAmount = Convert.ToDecimal(txtPaidAmount.Text),
                                    RemainAmount = totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text),
                                    BetAttachment = txtBetAttachment.Text,
                                    UserName = CurrentUser.Txtusername,
                                    Discount = Convert.ToInt32(txtDiscount.Text),
                                    Notes = txtNotes.Text,
                                    Date = dateTimeOrderDate.Value,
                                    SuitBooks = selectedSuitsBooks,
                                    OrderSuits = orderSuits,
                                    ItemsCount = selectedSuitsBooks.Count,
                                    Customer = new Customer
                                    {
                                        Name = txtCustomerName.Text,
                                        Address = txtCustomerAddress.Text,
                                        Phone = txtCustomerPhone.Text,
                                    }
                                });

                                try
                                {
                                    _dbContext.SaveChanges();
                                    
                                    int lastOrderId = _dbContext.Orders
                                        .OrderByDescending(O => O.Id)
                                        .ToList()[0].Id;

                                    Invoice frmInvoice = new Invoice(lastOrderId);
                                    frmInvoice.ShowDialog();
                                    ClearData();
                                    FillComboCustomers();
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("برجاء مراجعة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            foreach (var suitBook in selectedSuitsBooks)
                            {
                                foreach (var orderAttachmentSize in suitBook.OrderAttachmentSizes)
                                {
                                    var attachmentSize = _dbContext.Attachment_Sizes.FirstOrDefault(AS => AS.Id == orderAttachmentSize.AttachmentSizeId);
                                    if (attachmentSize is not null)
                                    {
                                        attachmentSize.AvailableStatus = (orderType == 0) ? Status.Outside : Status.Sale;
                                        try
                                        {
                                            _dbContext.SaveChanges();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("خطا في ادخال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }

                                var suitSize = _dbContext.SuitSizes.FirstOrDefault(SS => SS.Id == suitBook.SuitSizeId);
                                if (suitSize is not null)
                                {
                                    suitSize.AvailableStatus = (orderType == 0) ? Status.Outside : Status.Sale;
                                    try
                                    {
                                        _dbContext.SaveChanges();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("خطا في ادخال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            foreach (var selectedSuit in selectedSuits)
                            {
                                var suit = _dbContext.Suits.FirstOrDefault(S => S.Id == selectedSuit.Id);
                                if (suit is not null)
                                {
                                    suit.AvailableCounter--;
                                    try
                                    {
                                        _dbContext.SaveChanges();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("خطا في ادخال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            if (orderType == 1)
                            {
                                selectedSuitsBooks.Clear();
                            }

                            _dbContext.Orders.Add(new Order
                            {
                                Type = (orderType == 0) ? "تأجير" : "بيع",
                                Status = (orderType == 0) ? Status.Outside : Status.Sale,
                                RentDays = Convert.ToInt32(txtRentDays.Text),
                                TotalPrice = totalPriceAmount,
                                PaidAmount = Convert.ToDecimal(txtPaidAmount.Text),
                                RemainAmount = totalPriceAmount - Convert.ToDecimal(txtPaidAmount.Text),
                                BetAttachment = txtBetAttachment.Text,
                                UserName = CurrentUser.Txtusername,
                                Discount = Convert.ToInt32(txtDiscount.Text),
                                Notes = txtNotes.Text,
                                Date = dateTimeOrderDate.Value,
                                SuitBooks = selectedSuitsBooks,
                                OrderSuits = orderSuits,
                                ItemsCount = selectedSuitsBooks.Count,
                                CustomerId = ((Customer)comboCustomterName.SelectedItem).Id
                            });

                            try
                            {
                                _dbContext.SaveChanges();

                                int lastOrderId = _dbContext.Orders
                                        .OrderByDescending(O => O.Id)
                                        .ToList()[0].Id;

                                Invoice frmInvoice = new Invoice(lastOrderId);
                                frmInvoice.ShowDialog();
                                ClearData();
                                FillComboCustomers();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("برجاء مراجعة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال المرفق المرهن وعدد أيام الرهن أو تأكد من تاريخ الحجز", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }
}
