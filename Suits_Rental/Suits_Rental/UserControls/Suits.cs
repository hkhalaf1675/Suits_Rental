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
    public partial class Suits : UserControl
    {
        private readonly ISuitsRepository suitsRepository;
        public Suits()
        {
            InitializeComponent();

            this.suitsRepository = new SuitsRepository();
        }

        private void FillDataGridAllSuits()
        {
            dataGridAllSuits.Rows.Clear();
            foreach (var item in suitsRepository.GetAll())
            {
                dataGridAllSuits.Rows.Add(item.Id, item.Size, item.RentalPrice, item.SalePrice, item.AttachmentsCount, item.Status);
            }
        }
        private void GetData()
        {
            this.lblAvailableSuits.Text = suitsRepository.GetAvailableSuitsCount().ToString();
            this.lblOutsideSuits.Text = suitsRepository.GetOutsideSuitsCount().ToString();

            FillDataGridAllSuits();

            if (dataGridAllSuits.SelectedRows.Count == 0)
            {
                panelSuitSelect.Visible = false;
            }
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
        private void ChildForm_FormCLosed(object sender, FormClosedEventArgs e)
        {
            GetData();
        }
        private void OpenUpdateForm()
        {
            if (dataGridAllSuits.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridAllSuits.SelectedRows[0];
                int suitId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                UpdateSuit updateSuit = new UpdateSuit(suitId);
                updateSuit.FormClosed += ChildForm_FormCLosed;
                updateSuit.Show();
            }
            else
            {
                MessageBox.Show("برجاء اختيار بدلة");
            }
        }

        private void Suits_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ManageSuitForm manageSuitForm = new ManageSuitForm();
            manageSuitForm.Show();
        }

        private void dataGridAllSuits_Click(object sender, EventArgs e)
        {
            DataGridAllSuitsClickEvent();
        }

        private void dataGridAllSuits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridAllSuitsClickEvent();
        }

        private void dataGridAllSuits_DoubleClick(object sender, EventArgs e)
        {
            OpenUpdateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                if (confirmationResult == DialogResult.Yes)
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
    }
}
