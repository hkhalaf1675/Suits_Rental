using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
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
    public partial class UCSuits : UserControl
    {
        private readonly ApplicationDbContext context;

        public UCSuits()
        {
            InitializeComponent();

            context = new ApplicationDbContext();
        }

        private void FillDataGridAllSuits()
        {
            dataGridAllSuits.Rows.Clear();
            var allSuits = context.Suits.Include(S => S.Attachments).ToList();
            foreach (var item in allSuits)
            {
                dataGridAllSuits.Rows.Add(item.Id, item.RentalPrice, item.SalePrice, item.Attachments.Count, item.AvailableCounter);
            }
        }

        private void FillSuitPanelInfo(int suidId)
        {
            var suit = context.Suits
                .Include(S => S.Attachments)
                .ThenInclude(At => At.Attachment_Sizes)
                .SingleOrDefault(S => S.Id == suidId);

            if (suit != null)
            {
                lblSuitId.Text = $"رقم البدلة {suidId}";
                comboSuitAttachments.Items.Clear();
                comboSuitAttachments.Items.AddRange(suit.Attachments.ToArray());
                tlpSuitInfo.Visible = true;
            }
        }

        private void GetData()
        {
            var availableSuitsCount = context.Suits
                    .Where(S => S.AvailableCounter > 0)
                    .Select(S => S.AvailableCounter)
                    .ToList().Sum();

            var outsideSuitsCount = context.Orders
                    .Where(O => O.Status == Models.Status.Outside)
                    .Select(O => O.ItemsCount).ToList().Sum();

            this.lblAvailableSuits.Text = availableSuitsCount.ToString();
            this.lblOutsideSuits.Text = outsideSuitsCount.ToString();

            FillDataGridAllSuits();
        }

        private void ChildForm_FormCLosed(object sender, FormClosedEventArgs e)
        {
            GetData();
        }

        private void OpenUpdateForm(int suitId)
        {
            var suit = context.Suits.FirstOrDefault(S => S.Id == suitId);
            if (suit != null)
            {
                UpdateSuit updateSuit = new UpdateSuit(suitId);
                updateSuit.FormClosed += ChildForm_FormCLosed;
                updateSuit.ShowDialog();
            }
            else
            {
                MessageBox.Show("برجاء التاكد من رقم الأوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCSuits_Load(object sender, EventArgs e)
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
            if (dataGridAllSuits.SelectedCells.Count > 0)
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

                var suit = context.Suits.FirstOrDefault(S => S.Id == suitId);
                if (suit != null)
                {
                    var confirmationResult = MessageBox.Show($"حذف البدلة رقم {suitId}", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmationResult == DialogResult.Yes)
                    {
                        context.Suits.Remove(suit);
                        try
                        {
                            context.SaveChanges();
                            MessageBox.Show("تم الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            lblSuitId.Text = "0";
                            comboSuitAttachments.Items.Clear();

                            GetData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("لم يتم حذف البدلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("برجاء التاكد من رقم الأوردر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridAllSuits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int suitId = Convert.ToInt32(dataGridAllSuits.Rows[e.RowIndex].Cells[0].Value);

                if (e.ColumnIndex == dataGridAllSuits.Columns["btnDetails"].Index)
                {
                    SuitDetails frmSuitDetails = new SuitDetails(suitId);
                    frmSuitDetails.ShowDialog();
                }
            }
        }
    }
}
