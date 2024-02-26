using Suits_Rental.Contexts;
using Suits_Rental.Core;
using Suits_Rental.Forms;
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
    public partial class Customser : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        public Customser()
        {
            _dbContext = new ApplicationDbContext();
            InitializeComponent();
            GetAllCustomers();
        }
        private void GetAllCustomers()
        {
            dgvCustomers.Invalidate();
            dgvCustomers.Rows.Clear();
            var customers = _dbContext.Customers.Take(15).ToList();
            foreach (var customer in customers)
            {
                int ordersCount = _dbContext.Orders.Where(o => o.CustomerId == customer.Id).ToList().Count;
                dgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Address, customer.Phone, ordersCount);
            }
            //dgvCustomers.Refresh();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.Rows.Clear();
            var customers = _dbContext.Customers.Where(c => c.Name.Contains(txtCustomerSearch.Text)
            || c.Address.Contains(txtCustomerSearch.Text) || c.Phone.Contains(txtCustomerSearch.Text)).ToList();
            foreach (var customer in customers)
            {
                int ordersCount = _dbContext.Orders.Where(o => o.CustomerId == customer.Id).ToList().Count;
                dgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Address, customer.Phone, ordersCount);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if you want to delete user
            if (e.ColumnIndex == dgvCustomers.Columns["editCustomer"].Index && e.RowIndex >= 0)
            {
                var customerId =Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value);
                UpdateCustomer updateCustomer = new UpdateCustomer(customerId);
                updateCustomer.ShowDialog();
                CustomDialogResult customDialogResult = updateCustomer.CustomResult;
                //refresh Data Grid View With updated data
                GetAllCustomers();
            }
        }
    }
}
