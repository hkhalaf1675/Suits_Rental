namespace Suits_Rental.Forms
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            panelInfo = new Panel();
            panelDisCountSection = new Panel();
            label2 = new Label();
            lblDiscount = new Label();
            label4 = new Label();
            lblCustomerName = new Label();
            label10 = new Label();
            label5 = new Label();
            lblRemainAmount = new Label();
            lblItemsCount = new Label();
            label8 = new Label();
            lblPaidAmount = new Label();
            label3 = new Label();
            label6 = new Label();
            lblOrderType = new Label();
            lblTotalPrice = new Label();
            label1 = new Label();
            lblOrderDate = new Label();
            lblOrderNum = new Label();
            pictureBox1 = new PictureBox();
            btnPrint = new Button();
            btnCancel = new Button();
            label7 = new Label();
            lblCashierName = new Label();
            panelInfo.SuspendLayout();
            panelDisCountSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(panelDisCountSection);
            panelInfo.Controls.Add(label4);
            panelInfo.Controls.Add(lblCustomerName);
            panelInfo.Controls.Add(label7);
            panelInfo.Controls.Add(label10);
            panelInfo.Controls.Add(label5);
            panelInfo.Controls.Add(lblCashierName);
            panelInfo.Controls.Add(lblRemainAmount);
            panelInfo.Controls.Add(lblItemsCount);
            panelInfo.Controls.Add(label8);
            panelInfo.Controls.Add(lblPaidAmount);
            panelInfo.Controls.Add(label3);
            panelInfo.Controls.Add(label6);
            panelInfo.Controls.Add(lblOrderType);
            panelInfo.Controls.Add(lblTotalPrice);
            panelInfo.Controls.Add(label1);
            panelInfo.Controls.Add(lblOrderDate);
            panelInfo.Controls.Add(lblOrderNum);
            panelInfo.Controls.Add(pictureBox1);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(418, 379);
            panelInfo.TabIndex = 0;
            // 
            // panelDisCountSection
            // 
            panelDisCountSection.Controls.Add(label2);
            panelDisCountSection.Controls.Add(lblDiscount);
            panelDisCountSection.Dock = DockStyle.Bottom;
            panelDisCountSection.Location = new Point(0, 343);
            panelDisCountSection.Name = "panelDisCountSection";
            panelDisCountSection.Size = new Size(418, 36);
            panelDisCountSection.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(276, 4);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(124, 27);
            label2.TabIndex = 3;
            label2.Text = "الخصم : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            lblDiscount.Location = new Point(12, 4);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(266, 27);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "0.0";
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(276, 91);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(124, 27);
            label4.TabIndex = 2;
            label4.Text = "الأسم : ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(12, 91);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.RightToLeft = RightToLeft.Yes;
            lblCustomerName.Size = new Size(266, 27);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "حسن توفيق";
            lblCustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Location = new Point(276, 275);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(124, 27);
            label10.TabIndex = 2;
            label10.Text = "المبلغ المتبقي : ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(276, 181);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(124, 27);
            label5.TabIndex = 2;
            label5.Text = "عدد القطع : ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainAmount
            // 
            lblRemainAmount.Location = new Point(12, 275);
            lblRemainAmount.Name = "lblRemainAmount";
            lblRemainAmount.Size = new Size(266, 27);
            lblRemainAmount.TabIndex = 2;
            lblRemainAmount.Text = "0.0";
            lblRemainAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemsCount
            // 
            lblItemsCount.Location = new Point(12, 181);
            lblItemsCount.Name = "lblItemsCount";
            lblItemsCount.Size = new Size(266, 27);
            lblItemsCount.TabIndex = 2;
            lblItemsCount.Text = "2";
            lblItemsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(276, 245);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(124, 27);
            label8.TabIndex = 2;
            label8.Text = "المبلغ المدفوع : ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.Location = new Point(12, 245);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(266, 27);
            lblPaidAmount.TabIndex = 2;
            lblPaidAmount.Text = "700.0";
            lblPaidAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(276, 151);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(124, 27);
            label3.TabIndex = 2;
            label3.Text = "نوع الاوردر : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(276, 215);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(124, 27);
            label6.TabIndex = 2;
            label6.Text = "المبلغ الكلي : ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderType
            // 
            lblOrderType.Location = new Point(12, 151);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.RightToLeft = RightToLeft.Yes;
            lblOrderType.Size = new Size(266, 27);
            lblOrderType.TabIndex = 2;
            lblOrderType.Text = "تأجير";
            lblOrderType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Location = new Point(12, 215);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(266, 27);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "1010.5";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(276, 121);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(124, 27);
            label1.TabIndex = 2;
            label1.Text = "التاريخ : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderDate
            // 
            lblOrderDate.Location = new Point(12, 121);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.RightToLeft = RightToLeft.Yes;
            lblOrderDate.Size = new Size(266, 27);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = "24/8/2024";
            lblOrderDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderNum
            // 
            lblOrderNum.AutoSize = true;
            lblOrderNum.ForeColor = Color.FromArgb(192, 0, 0);
            lblOrderNum.Location = new Point(235, 29);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(67, 27);
            lblOrderNum.TabIndex = 1;
            lblOrderNum.Text = "#No 13";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Teal;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(235, 385);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(165, 60);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "طباعة الفاتورة";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(12, 385);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 60);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.Location = new Point(276, 307);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(124, 27);
            label7.TabIndex = 2;
            label7.Text = "اسم الكاشير : ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCashierName
            // 
            lblCashierName.Location = new Point(12, 307);
            lblCashierName.Name = "lblCashierName";
            lblCashierName.Size = new Size(266, 27);
            lblCashierName.TabIndex = 2;
            lblCashierName.Text = "hassan13";
            lblCashierName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(10F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(418, 452);
            Controls.Add(btnCancel);
            Controls.Add(btnPrint);
            Controls.Add(panelInfo);
            Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            Load += Invoice_Load;
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelDisCountSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private Label lblOrderNum;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblCustomerName;
        private Label label3;
        private Label lblOrderType;
        private Label label1;
        private Label lblOrderDate;
        private Label label10;
        private Label label5;
        private Label lblRemainAmount;
        private Label lblItemsCount;
        private Label label8;
        private Label lblPaidAmount;
        private Label label6;
        private Label lblTotalPrice;
        private Button btnPrint;
        private Button btnCancel;
        private Panel panelDisCountSection;
        private Label label2;
        private Label lblDiscount;
        private Label label7;
        private Label lblCashierName;
    }
}