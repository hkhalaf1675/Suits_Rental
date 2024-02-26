﻿using Suits_Rental.Dtos;
using Suits_Rental.Forms;
using Suits_Rental.IRepositories;
using Suits_Rental.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suits_Rental.UserControls
{
    public partial class MainScreen : UserControl
    {
        private readonly ISuitsRepository suitsRepository;
        private readonly IOrderRepository orderRepository;
        public MainScreen()
        {
            InitializeComponent();

            suitsRepository = new SuitsRepository();
            orderRepository = new OrderRepository();
        }

        private void FillDataGridSuits(List<SuitReadDto> suits)
        {
            dataGridSuits.Rows.Clear();

            foreach (var suit in suits)
            {
                dataGridSuits.Rows.Add(suit.Id, suit.Size, suit.RentalPrice, suit.SalePrice, suit.AttachmentsCount, suit.Status);
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            FillDataGridSuits(suitsRepository.GetAll());

            lblAvailableSuits.Text = suitsRepository.GetAvailableSuitsCount().ToString();
            lblOutsideSuits.Text = suitsRepository.GetOutsideSuitsCount().ToString();
        }

        private void btnSuitSearch_Click(object sender, EventArgs e)
        {
            var suit = suitsRepository.GetById(Convert.ToInt32(numericSuitId.Value));
            if (suit == null)
            {
                MessageBox.Show("لا يوجد بدلة بهذا الرقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridSuits.Rows.Clear();
                dataGridSuits.Rows.Add(suit.Id, suit.Size, suit.RentalPrice, suit.SalePrice, suit.Attachments.Count, (suit.AvailableStatus) ? "موجودة" : "غير موجودة");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            MakeOrder frmMakeOrder = new MakeOrder();
            frmMakeOrder.ShowDialog();
        }

        private void btnReturnSuit_Click(object sender, EventArgs e)
        {
            int orderId = (int)numericOrderId.Value;
            var order = orderRepository.GetById(orderId);

            if (order == null)
            {
                MessageBox.Show("لا يوجد أوردر بهذا الرقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReturnSuit frmReturnSuit = new ReturnSuit(orderId);
                frmReturnSuit.ShowDialog();
            }
        }

        private void btnAddNewSuit_Click(object sender, EventArgs e)
        {
            ManageSuitForm frmSuit = new ManageSuitForm();
            frmSuit.FormClosed += ChildForm_FormCLosed;
            frmSuit.ShowDialog();
        }

        private void ChildForm_FormCLosed(object? sender, FormClosedEventArgs e)
        {
            FillDataGridSuits(suitsRepository.GetAll());
        }

    }
}