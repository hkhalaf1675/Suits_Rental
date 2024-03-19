using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suits_Rental.Forms
{
    public partial class Invoice : Form
    {
        private readonly ApplicationDbContext context;
        int orderId;
        public Invoice(int id)
        {
            InitializeComponent();

            context = new ApplicationDbContext();
            orderId = id;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            var order = context.Orders
                .Include(O => O.Customer)
                .Where(O => O.Id == orderId)
                .FirstOrDefault();

            if (order != null)
            {
                lblOrderNum.Text = $"#No {order.Id}";
                lblCustomerName.Text = order.Customer.Name;
                lblOrderDate.Text = $"{order.Date.ToString("yyyy/MM/dd")}";
                lblOrderType.Text = order.Type;
                lblItemsCount.Text = $"{order.ItemsCount}";
                lblTotalPrice.Text = $"{order.TotalPrice}";
                lblPaidAmount.Text = $"{order.PaidAmount}";
                lblRemainAmount.Text = $"{order.RemainAmount}";
                //lblCashierName.Text = order.UserName;

                if (order.Discount > 0)
                {
                    panelDisCountSection.Visible = true;
                    lblDiscount.Text = $"%{order.Discount}";
                }
                else
                {
                    panelDisCountSection.Visible = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(panelInfo.Width, panelInfo.Height);

            panelInfo.DrawToBitmap(bitmap, new Rectangle(0, 0, panelInfo.Width, panelInfo.Height));

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            };

            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            this.Close();
        }

        
    }
}
