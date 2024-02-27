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

        private void FillSuitPanelInfo(int suidId)
        {
            var suit = suitsRepository.GetById(suidId);
            if(suit != null)
            {
                lblSuitId.Text = suidId.ToString();
                lblSuitSize.Text = suit.Size.ToString();
                comboSuitAttachments.Items.Clear();
                comboSuitAttachments.Items.AddRange(suit.Attachments.ToArray());
                panelSuitSelect.Visible = true;
            }
        }

        private void GetData()
        {
            this.lblAvailableSuits.Text = suitsRepository.GetAvailableSuitsCount().ToString();
            this.lblOutsideSuits.Text = suitsRepository.GetOutsideSuitsCount().ToString();

            FillDataGridAllSuits();
        }

        private void ChildForm_FormCLosed(object sender, FormClosedEventArgs e)
        {
            GetData();
        }

        private void OpenUpdateForm(int suitId)
        {
            UpdateSuit updateSuit = new UpdateSuit(suitId);
            updateSuit.FormClosed += ChildForm_FormCLosed;
            updateSuit.ShowDialog();
        }

        private void Suits_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridAllSuits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < dataGridAllSuits.Columns.Count)
            {
                dataGridAllSuits.Rows[e.RowIndex].Selected = true;
                int suitId = Convert.ToInt32(dataGridAllSuits.SelectedRows[0].Cells["Id"].Value);
                FillSuitPanelInfo(suitId);
            }
        }

        private void dataGridAllSuits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < dataGridAllSuits.Columns.Count)
            {
                int suitId = Convert.ToInt32(dataGridAllSuits.Rows[e.RowIndex].Cells["Id"].Value);
                OpenUpdateForm(suitId);
            }
            else
            {
                MessageBox.Show("برجاء اختيار بدلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ManageSuitForm manageSuitForm = new ManageSuitForm();
            manageSuitForm.FormClosed += ChildForm_FormCLosed;
            manageSuitForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridAllSuits.SelectedCells.Count > 0)
            {
                int suitId = Convert.ToInt32(dataGridAllSuits.SelectedRows[0].Cells["Id"].Value);
                OpenUpdateForm(suitId);
            }
            else
            {
                MessageBox.Show("برجاء اختيار بدلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridAllSuits.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridAllSuits.SelectedRows[0];
                int suitId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var confirmationResult = MessageBox.Show($"حذف البدلة رقم {suitId}", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmationResult == DialogResult.Yes)
                {
                    bool check = suitsRepository.Delete(suitId);
                    if (check)
                    {
                        MessageBox.Show("تم الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panelSuitSelect.Visible = false;
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم حذف البدلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
