namespace Suits_Rental.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            btnCloseLoginForm = new PictureBox();
            pictureBox2 = new PictureBox();
            btnHideLoginForm = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblErrorMsg = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)btnCloseLoginForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHideLoginForm).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 53);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 0;
            label1.Text = "تسجيل الدخول";
            // 
            // btnCloseLoginForm
            // 
            btnCloseLoginForm.Image = (Image)resources.GetObject("btnCloseLoginForm.Image");
            btnCloseLoginForm.Location = new Point(2, 2);
            btnCloseLoginForm.Name = "btnCloseLoginForm";
            btnCloseLoginForm.Size = new Size(36, 32);
            btnCloseLoginForm.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCloseLoginForm.TabIndex = 1;
            btnCloseLoginForm.TabStop = false;
            btnCloseLoginForm.Click += btnCloseLoginForm_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2024_02_16_at_8_02_05_AM;
            pictureBox2.Location = new Point(132, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnHideLoginForm
            // 
            btnHideLoginForm.Image = (Image)resources.GetObject("btnHideLoginForm.Image");
            btnHideLoginForm.Location = new Point(44, 2);
            btnHideLoginForm.Name = "btnHideLoginForm";
            btnHideLoginForm.Size = new Size(40, 32);
            btnHideLoginForm.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHideLoginForm.TabIndex = 3;
            btnHideLoginForm.TabStop = false;
            btnHideLoginForm.Click += btnHideLoginForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(263, 94);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 4;
            label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arabic Typesetting", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(267, 160);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 5;
            label3.Text = "كلمة المرور";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(114, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.RightToLeft = RightToLeft.Yes;
            txtUsername.Size = new Size(209, 29);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(114, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.Size = new Size(209, 29);
            txtPassword.TabIndex = 7;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(132, 283);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(172, 21);
            lblErrorMsg.TabIndex = 8;
            lblErrorMsg.Text = "اسم المستخدم أو كلمة المرور خطأ";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 192, 192);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(149, 224);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 35);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 320);
            Controls.Add(btnLogin);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnHideLoginForm);
            Controls.Add(pictureBox2);
            Controls.Add(btnCloseLoginForm);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)btnCloseLoginForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHideLoginForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox btnCloseLoginForm;
        private PictureBox pictureBox2;
        private PictureBox btnHideLoginForm;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblErrorMsg;
        private Button btnLogin;
    }
}