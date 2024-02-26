namespace Suits_Rental.UserControls
{
    partial class Customser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvCustomers = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            ordersCount = new DataGridViewTextBoxColumn();
            editCustomer = new DataGridViewButtonColumn();
            panel1 = new Panel();
            label1 = new Label();
            txtCustomerSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.ColumnHeadersHeight = 35;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { id, name, address, phone, ordersCount, editCustomer });
            dgvCustomers.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvCustomers.Location = new Point(0, 63);
            dgvCustomers.Margin = new Padding(0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RightToLeft = RightToLeft.Yes;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCustomers.RowTemplate.Height = 25;
            dgvCustomers.ScrollBars = ScrollBars.Vertical;
            dgvCustomers.ShowCellErrors = false;
            dgvCustomers.ShowRowErrors = false;
            dgvCustomers.Size = new Size(1150, 607);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            id.DefaultCellStyle = dataGridViewCellStyle2;
            id.HeaderText = "الرقم التعريفي";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.DefaultCellStyle = dataGridViewCellStyle3;
            name.HeaderText = "الاسم";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "العنوان";
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // phone
            // 
            phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            phone.DefaultCellStyle = dataGridViewCellStyle4;
            phone.HeaderText = "الموبايل";
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // ordersCount
            // 
            ordersCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            ordersCount.DefaultCellStyle = dataGridViewCellStyle5;
            ordersCount.HeaderText = "عدد الاوردرات";
            ordersCount.Name = "ordersCount";
            ordersCount.ReadOnly = true;
            ordersCount.Resizable = DataGridViewTriState.True;
            ordersCount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // editCustomer
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle6.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            editCustomer.DefaultCellStyle = dataGridViewCellStyle6;
            editCustomer.FlatStyle = FlatStyle.Flat;
            editCustomer.HeaderText = "تعديل";
            editCustomer.Name = "editCustomer";
            editCustomer.ReadOnly = true;
            editCustomer.Text = "تعديل";
            editCustomer.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCustomerSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 63);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1046, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(33, 24);
            label1.TabIndex = 1;
            label1.Text = "بحث";
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Font = new Font("Arabic Typesetting", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerSearch.Location = new Point(857, 16);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.RightToLeft = RightToLeft.Yes;
            txtCustomerSearch.Size = new Size(183, 32);
            txtCustomerSearch.TabIndex = 0;
            txtCustomerSearch.TextAlign = HorizontalAlignment.Center;
            txtCustomerSearch.TextChanged += txtCustomerSearch_TextChanged;
            // 
            // Customser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dgvCustomers);
            Name = "Customser";
            Size = new Size(1150, 670);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomers;
        private Panel panel1;
        private Label label1;
        private TextBox txtCustomerSearch;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn ordersCount;
        private DataGridViewButtonColumn editCustomer;
    }
}
