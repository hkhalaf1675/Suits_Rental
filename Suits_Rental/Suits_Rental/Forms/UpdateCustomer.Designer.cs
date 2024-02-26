namespace Suits_Rental.Forms
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            panel1 = new Panel();
            label1 = new Label();
            btnCloseAddCustomerForm = new PictureBox();
            txtCustomerAddress = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtCustomerPhone = new TextBox();
            label4 = new Label();
            btnUpdateCustomer = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseAddCustomerForm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 78, 82);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCloseAddCustomerForm);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 38);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(125, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 27);
            label1.TabIndex = 3;
            label1.Text = "تعديل بيانات عميل";
            // 
            // btnCloseAddCustomerForm
            // 
            btnCloseAddCustomerForm.Image = (Image)resources.GetObject("btnCloseAddCustomerForm.Image");
            btnCloseAddCustomerForm.Location = new Point(0, 0);
            btnCloseAddCustomerForm.Name = "btnCloseAddCustomerForm";
            btnCloseAddCustomerForm.Size = new Size(36, 38);
            btnCloseAddCustomerForm.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCloseAddCustomerForm.TabIndex = 2;
            btnCloseAddCustomerForm.TabStop = false;
            btnCloseAddCustomerForm.Click += btnCloseAddCustomerForm_Click;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerAddress.Location = new Point(37, 112);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.RightToLeft = RightToLeft.Yes;
            txtCustomerAddress.Size = new Size(234, 27);
            txtCustomerAddress.TabIndex = 19;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(37, 55);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(234, 27);
            txtName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(286, 118);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(42, 21);
            label3.TabIndex = 17;
            label3.Text = "العنوان";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(286, 61);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(36, 21);
            label2.TabIndex = 16;
            label2.Text = "الاسم";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Font = new Font("Arabic Typesetting", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerPhone.Location = new Point(37, 173);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.RightToLeft = RightToLeft.Yes;
            txtCustomerPhone.Size = new Size(234, 27);
            txtCustomerPhone.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(286, 179);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(46, 21);
            label4.TabIndex = 20;
            label4.Text = "الموبايل";
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(0, 192, 192);
            btnUpdateCustomer.FlatStyle = FlatStyle.Flat;
            btnUpdateCustomer.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(142, 225);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(86, 30);
            btnUpdateCustomer.TabIndex = 22;
            btnUpdateCustomer.Text = "تعديل";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // UpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 267);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(txtCustomerPhone);
            Controls.Add(label4);
            Controls.Add(txtCustomerAddress);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCustomer";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseAddCustomerForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseAddCustomerForm;
        private TextBox txtCustomerAddress;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private TextBox txtCustomerPhone;
        private Label label4;
        private Button btnUpdateCustomer;
    }
}