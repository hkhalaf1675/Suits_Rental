using Suits_Rental.Contexts;
using Suits_Rental.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suits_Rental.Forms
{
    public partial class UpdateCustomer : Form
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomDialogResult CustomResult { get; private set; }
        public int CustomerId;
        public UpdateCustomer(int customerId)
        {
            _dbContext = new ApplicationDbContext();
            CustomResult = CustomDialogResult.Cancel;
            CustomerId = customerId;
            InitializeComponent();
            GetCustomerData(customerId);
        }
        private void GetCustomerData(int customerId)
        {
            var customer = _dbContext.Customers.First(c => c.Id == customerId);
            txtName.Text = customer.Name;
            txtCustomerAddress.Text = customer.Address;
            txtCustomerPhone.Text = customer.Phone;
        }

        private void btnCloseAddCustomerForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            var customer = _dbContext.Customers.First(c=>c.Id==CustomerId);
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCustomerAddress.Text)
                || string.IsNullOrEmpty(txtCustomerPhone.Text))
            {
                MessageBox.Show("!برجاء إدخال قيم صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                customer.Name = txtName.Text;
                customer.Address = txtCustomerAddress.Text;
                customer.Phone = txtCustomerPhone.Text;
                if (await _dbContext.SaveChangesAsync() > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("تمت تعديل بيانات العميل بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
                    {
                        CustomResult = CustomDialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}
