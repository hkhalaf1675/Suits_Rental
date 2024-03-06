namespace Suits_Rental.UserControls
{
    partial class AdminUserControl
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
            dgvAdmins = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            editAdmin = new DataGridViewButtonColumn();
            deleteAdmin = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnAddAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAdmins
            // 
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.AllowUserToResizeColumns = false;
            dgvAdmins.AllowUserToResizeRows = false;
            dgvAdmins.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdmins.ColumnHeadersHeight = 50;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAdmins.Columns.AddRange(new DataGridViewColumn[] { id, name, username, role, editAdmin, deleteAdmin });
            dgvAdmins.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvAdmins.Location = new Point(0, 56);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.ReadOnly = true;
            dgvAdmins.RightToLeft = RightToLeft.Yes;
            dgvAdmins.RowHeadersVisible = false;
            dgvAdmins.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAdmins.RowTemplate.Height = 25;
            dgvAdmins.ScrollBars = ScrollBars.Vertical;
            dgvAdmins.ShowCellErrors = false;
            dgvAdmins.ShowRowErrors = false;
            dgvAdmins.Size = new Size(900, 550);
            dgvAdmins.TabIndex = 0;
            dgvAdmins.CellClick += dgvAdmins_CellClick;
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
            // username
            // 
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username.HeaderText = "اسم المستخدم";
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            role.DefaultCellStyle = dataGridViewCellStyle4;
            role.HeaderText = "الصلاحية";
            role.Name = "role";
            role.ReadOnly = true;
            // 
            // editAdmin
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            editAdmin.DefaultCellStyle = dataGridViewCellStyle5;
            editAdmin.FlatStyle = FlatStyle.Flat;
            editAdmin.HeaderText = "تعديل";
            editAdmin.Name = "editAdmin";
            editAdmin.ReadOnly = true;
            editAdmin.Text = "تعديل";
            editAdmin.UseColumnTextForButtonValue = true;
            editAdmin.Width = 48;
            // 
            // deleteAdmin
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle6.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            deleteAdmin.DefaultCellStyle = dataGridViewCellStyle6;
            deleteAdmin.FlatStyle = FlatStyle.Flat;
            deleteAdmin.HeaderText = "حذف";
            deleteAdmin.Name = "deleteAdmin";
            deleteAdmin.ReadOnly = true;
            deleteAdmin.Text = "حذف";
            deleteAdmin.UseColumnTextForButtonValue = true;
            deleteAdmin.Width = 45;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 50);
            panel1.TabIndex = 1;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.FromArgb(0, 192, 192);
            btnAddAdmin.Dock = DockStyle.Right;
            btnAddAdmin.FlatStyle = FlatStyle.Flat;
            btnAddAdmin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Location = new Point(760, 0);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(140, 50);
            btnAddAdmin.TabIndex = 0;
            btnAddAdmin.Text = "إضافة مستخدم";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // AdminUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dgvAdmins);
            Name = "AdminUserControl";
            Size = new Size(900, 670);
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdmins;
        private Panel panel1;
        private Button btnAddAdmin;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn role;
        private DataGridViewButtonColumn editAdmin;
        private DataGridViewButtonColumn deleteAdmin;
    }
}
