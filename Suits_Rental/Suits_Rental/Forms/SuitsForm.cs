using Suits_Rental.Contexts;
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

namespace Suits_Rental.Forms
{
    public partial class SuitsForm : Form
    {
        private readonly ISuitsRepository suitsRepository;

        public SuitsForm()
        {
            InitializeComponent();
            this.suitsRepository = new SuitsRepository();
        }

        private void SuitsForm_Load(object sender, EventArgs e)
        {
            this.lblAvailableSuits.Text = suitsRepository.GetAvailableSuitsCount().ToString();
            this.lblOutsideSuits.Text = suitsRepository.GetOutsideSuitsCount().ToString();

            FillDataGridAllSuits();

            if (dataGridAllSuits.SelectedRows.Count == 0)
            {
                panelSuitSelect.Visible = false;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ManageSuitForm manageSuitForm = new ManageSuitForm();
            manageSuitForm.Show();
        }

        private void FillDataGridAllSuits()
        {
            dataGridAllSuits.DataSource = null;
            dataGridAllSuits.DataSource = suitsRepository.GetAll();
        }

        #region Show Suits By Code
        //private void DrawAllSuits()
        //{
        //    List<Suit> allSuits = suitsRepository.GetAll();
        //    int x, y;
        //    int counterX = 0;
        //    int counterY = 0;

        //    foreach(var item in allSuits)
        //    {
        //        // location of container
        //        x = 60 + (counterX * 250);
        //        y = 10 + (counterY * 240);

        //        counterX++;
        //        if(counterX == 3)
        //        {
        //            counterX = 0;
        //            counterY++;
        //        }

        //        // the container of suit info
        //        Panel panel = new Panel();
        //        panel.Size = new Size(240, 220);
        //        panel.BackColor = Color.White;
        //        panel.Location = new Point(x, y);

        //        // label for the suit id
        //        Label lblID = new Label();
        //        lblID.Text = item.Id.ToString();
        //        lblID.Location = new Point(105, 5);
        //        panel.Controls.Add(lblID);

        //        // label for the suit size
        //        Label lblSize = new Label();
        //        lblSize.Text = $"مقاس {item.Size}";
        //        lblSize.Location = new Point(80, 50);
        //        panel.Controls.Add(lblSize);

        //        // Lable for price
        //        Label lblPrice = new Label();
        //        lblPrice.Text = (item.RentalPrice > 0) ? $"سعر الإيجار {item.RentalPrice}" : $"سعر البيع {item.SalePrice}";
        //        lblPrice.Location = new Point(70, 90);
        //        panel.Controls.Add(lblPrice);

        //        // combobox for the attachments
        //        ComboBox suitAttachments = new ComboBox();
        //        suitAttachments.DataSource = item.Attachments;
        //        suitAttachments.DisplayMember = "AttachmentName";
        //        suitAttachments.Location = new Point(120, 190);
        //        panel.Controls.Add(suitAttachments);

        //        panelSuitsContainer.Controls.Add(panel);
        //    }
        //} 
        #endregion

        private void dataGridAllSuits_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridAllSuitsClickEvent();
        }

        private void dataGridAllSuits_Click(object sender, EventArgs e)
        {
            DataGridAllSuitsClickEvent();
        }

        private void DataGridAllSuitsClickEvent()
        {
            if (dataGridAllSuits.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridAllSuits.SelectedRows[0];
                int suitId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                Suit? selectedSuit = suitsRepository.GetById(suitId);

                if (selectedSuit != null)
                {
                    panelSuitSelect.Visible = true;

                    lblSuitId.Text = suitId.ToString();
                    lblSuitSize.Text = selectedSuit.Size.ToString();

                    comboSuitAttachments.DataSource = null;
                    comboSuitAttachments.DataSource = selectedSuit.Attachments;
                    comboSuitAttachments.DisplayMember = "AttachmentName";
                }
            }
        }

        private void dataGridAllSuits_DoubleClick(object sender, EventArgs e)
        {
            OpenUpdateForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridAllSuits.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridAllSuits.SelectedRows[0];
                int suitId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var confirmationResult = MessageBox.Show($"حذف البدلة رقم {suitId}", "تحذير", MessageBoxButtons.YesNo);
                if (confirmationResult == DialogResult.OK)
                {
                    bool check = suitsRepository.Delete(suitId);
                    if (check)
                    {
                        MessageBox.Show("تم الحذف بنجاح");
                        panelSuitSelect.Visible = false;
                        FillDataGridAllSuits();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم حذف البدلة");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenUpdateForm();
        }

        private void OpenUpdateForm()
        {
            if (dataGridAllSuits.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridAllSuits.SelectedRows[0];
                int suitId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                UpdateSuit updateSuit = new UpdateSuit(suitId);
                updateSuit.Show();
            }
            else
            {
                MessageBox.Show("برجاء اختيار بدلة");
            }
        }
    }
}
