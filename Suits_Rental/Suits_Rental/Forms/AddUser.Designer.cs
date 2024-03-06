namespace Suits_Rental.Forms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            panel1 = new Panel();
            label1 = new Label();
            btnCloseAddUserForm = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSaveNewUser = new Button();
            txtName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            cmbUserPermission = new ComboBox();
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
            panel1.Size = new Size(378, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 27);
            label1.TabIndex = 3;
            label1.Text = "إضافة مستخدم";
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
            btnCloseAddUserForm.Click += btnCloseLoginForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(277, 81);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(36, 21);
            label2.TabIndex = 1;
            label2.Text = "الاسم";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(268, 134);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "اسم المستخدم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(280, 195);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(63, 21);
            label4.TabIndex = 3;
            label4.Text = "كلمة المرور";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(280, 251);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(52, 21);
            label5.TabIndex = 4;
            label5.Text = "الصلاحية";
            // 
            // btnSaveNewUser
            // 
            btnSaveNewUser.BackColor = Color.FromArgb(0, 192, 192);
            btnSaveNewUser.FlatStyle = FlatStyle.Flat;
            btnSaveNewUser.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveNewUser.ForeColor = Color.White;
            btnSaveNewUser.Location = new Point(141, 291);
            btnSaveNewUser.Name = "btnSaveNewUser";
            btnSaveNewUser.Size = new Size(86, 30);
            btnSaveNewUser.TabIndex = 5;
            btnSaveNewUser.Text = "حفظ";
            btnSaveNewUser.UseVisualStyleBackColor = false;
            btnSaveNewUser.Click += btnSaveNewUser_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(28, 75);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(234, 27);
            txtName.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(28, 132);
            txtUserName.Name = "txtUserName";
            txtUserName.RightToLeft = RightToLeft.Yes;
            txtUserName.Size = new Size(234, 27);
            txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(28, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.Size = new Size(234, 27);
            txtPassword.TabIndex = 8;
            // 
            // cmbUserPermission
            // 
            cmbUserPermission.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserPermission.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUserPermission.FormattingEnabled = true;
            cmbUserPermission.Items.AddRange(new object[] { "أدمن", "موظف" });
            cmbUserPermission.Location = new Point(28, 244);
            cmbUserPermission.Name = "cmbUserPermission";
            cmbUserPermission.RightToLeft = RightToLeft.Yes;
            cmbUserPermission.Size = new Size(234, 28);
            cmbUserPermission.TabIndex = 9;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 336);
            Controls.Add(cmbUserPermission);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtName);
            Controls.Add(btnSaveNewUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseAddUserForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btnCloseAddUserForm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSaveNewUser;
        private TextBox txtName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private ComboBox cmbUserPermission;
    }
}