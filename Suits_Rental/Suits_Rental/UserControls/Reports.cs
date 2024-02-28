using Suits_Rental.Dtos;
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
    public partial class Reports : UserControl
    {
        private readonly IOrderRepository orderRepository;
        public Reports()
        {
            InitializeComponent();

            orderRepository = new OrderRepository();
        }

        private void GetData(List<OrderReadDto> orders)
        {
            decimal totalIncome = 0;
            decimal totalRemain = 0;

            dataGridReportData.Rows.Clear();

            foreach (var order in orders)
            {
                dataGridReportData.Rows.Add(order.Id, order.CustomerName, order.Date.ToString("yyyy/MM/dd"), order.RentDays, order.TotalPrice, order.RemainAmount);
                totalIncome += order.TotalPrice;
                totalRemain += order.RemainAmount;
            }

            lblTotalIncome.Text = $"{(totalIncome - totalRemain)}";
            lblTotalRemain.Text = totalRemain.ToString("F2");
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            GetData(orderRepository.GetReport(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(1)));
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            GetData(orderRepository.GetAll());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetData(orderRepository.GetReport(dateTimeStart.Value, dateTimeEnd.Value));
        }
    }
}
