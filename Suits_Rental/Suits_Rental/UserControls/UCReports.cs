using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Models;
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
    public partial class UCReports : UserControl
    {
        private readonly ApplicationDbContext context;

        public UCReports()
        {
            InitializeComponent();

            context = new ApplicationDbContext();
        }

        private void GetData(List<Order> orders)
        {
            decimal totalIncome = 0;
            decimal totalRemain = 0;

            dataGridReportData.Rows.Clear();

            foreach (var order in orders)
            {
                dataGridReportData.Rows.Add(order.Id, order.Customer.Name, order.Date.ToString("yyyy/MM/dd"), order.RentDays, order.TotalPrice, order.RemainAmount);
                totalIncome += order.TotalPrice;
                totalRemain += order.RemainAmount;
            }

            lblTotalIncome.Text = $"{(totalIncome - totalRemain)}";
            lblTotalRemain.Text = totalRemain.ToString("F2");
        }

        private void UCReports_Load(object sender, EventArgs e)
        {
            GetData(GetReport(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(30)));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetData(GetReport(dateTimeStart.Value, dateTimeEnd.Value));
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var allOrders = context.Orders
                .Include(O => O.Customer)
                .OrderByDescending(O => O.Date)
                .Take(20)
                .ToList();

            GetData(allOrders);
        }

        private List<Order> GetReport(DateTime start, DateTime end)
        {
            return context.Orders
                .Include(O => O.Customer)
                .Where(O => O.Date >= start && O.Date <= end)
                .OrderByDescending(O => O.Date)
                .ToList();
        }
    }
}
