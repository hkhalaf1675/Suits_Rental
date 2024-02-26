namespace Suits_Rental.Forms
{
    partial class UpdateUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUser));
            panel1 = new Panel();
            label1 = new Label();
            btnCloseAddUserForm = new PictureBox();
            cmbUserPermission = new ComboBox();
            txtUserName = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            btnUpdateUser = new Button();
            lblCurrentUserPermission = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseAddUserForm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 78, 82);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCloseAddUserForm);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 38);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 3;
            label1.Text = "تعديل مستخدم";
            // 
            // btnCloseAddUserForm
            // 
            btnCloseAddUserForm.Image = (Image)resources.GetObject("btnCloseAddUserForm.Image");
            btnCloseAddUserForm.Location = new Point(0, 0);
            btnCloseAddUserForm.Name = "btnCloseAddUserForm";
            btnCloseAddUserForm.Size = new Size(36, 38);
            btnCloseAddUserForm.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCloseAddUserForm.TabIndex = 2;
            btnCloseAddUserForm.TabStop = false;
            btnCloseAddUserForm.Click += btnCloseAddUserForm_Click;
            // 
            // cmbUserPermission
            // 
            cmbUserPermission.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserPermission.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUserPermission.FormattingEnabled = true;
            cmbUserPermission.Items.AddRange(new object[] { "أدمن", "موظف" });
            cmbUserPermission.Location = new Point(19, 203);
            cmbUserPermission.Name = "cmbUserPermission";
            cmbUserPermission.RightToLeft = RightToLeft.Yes;
            cmbUserPermission.Size = new Size(234, 28);
            cmbUserPermission.TabIndex = 17;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(20, 113);
            txtUserName.Name = "txtUserName";
            txtUserName.RightToLeft = RightToLeft.Yes;
            txtUserName.Size = new Size(234, 27);
            txtUserName.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(20, 56);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(234, 27);
            txtName.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(268, 210);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(52, 21);
            label5.TabIndex = 13;
            label5.Text = "الصلاحية";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(269, 119);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(74, 21);
            label3.TabIndex = 11;
            label3.Text = "اسم المستخدم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(269, 62);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(36, 21);
            label2.TabIndex = 10;
            label2.Text = "الاسم";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(257, 164);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(85, 21);
            label6.TabIndex = 18;
            label6.Text = "الصلاحية الحالية";
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.FromArgb(0, 192, 192);
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(136, 256);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(86, 30);
            btnUpdateUser.TabIndex = 19;
            btnUpdateUser.Text = "تعديل";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // lblCurrentUserPermission
            // 
            lblCurrentUserPermission.AutoSize = true;
            lblCurrentUserPermission.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentUserPermission.ForeColor = Color.Black;
            lblCurrentUserPermission.Location = new Point(136, 164);
            lblCurrentUserPermission.Name = "lblCurrentUserPermission";
            lblCurrentUserPermission.RightToLeft = RightToLeft.Yes;
            lblCurrentUserPermission.Size = new Size(85, 21);
            lblCurrentUserPermission.TabIndex = 20;
            lblCurrentUserPermission.Text = "الصلاحية الحالية";
            // 
            // UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 306);
            Controls.Add(lblCurrentUserPermission);
            Controls.Add(btnUpdateUser);
            Controls.Add(label6);
            Controls.Add(cmbUserPermission);
            Controls.Add(txtUserName);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseAddUserForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseAddUserForm;
        private ComboBox cmbUserPermission;
        private TextBox txtUserName;
        private TextBox txtName;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button btnUpdateUser;
        private Label lblCurrentUserPermission;
    }
}