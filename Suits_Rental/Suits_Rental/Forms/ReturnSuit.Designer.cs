namespace Suits_Rental.Forms
{
    partial class ReturnSuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnSuit));
            PanelLayout = new Panel();
            label1 = new Label();
            btnMinmize = new PictureBox();
            btnClose = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnReturnSuit = new Button();
            btnCancel = new Button();
            lblOrderNum = new Label();
            lblCustomerName = new Label();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            lblTotalPrice = new Label();
            lblRemainAmount = new Label();
            lblItemsCount = new Label();
            lblBetAttachment = new Label();
            label10 = new Label();
            label11 = new Label();
            lblOrderDate = new Label();
            lblRentDays = new Label();
            btnGetRemainAmount = new Button();
            PanelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinmize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // PanelLayout
            // 
            PanelLayout.BackColor = Color.FromArgb(73, 78, 82);
            PanelLayout.Controls.Add(label1);
            PanelLayout.Controls.Add(btnMinmize);
            PanelLayout.Controls.Add(btnClose);
            PanelLayout.Dock = DockStyle.Top;
            PanelLayout.Location = new Point(0, 0);
            PanelLayout.Name = "PanelLayout";
            PanelLayout.Size = new Size(711, 50);
            PanelLayout.TabIndex = 0;
            PanelLayout.Paint += PanelLayout_Paint;
            PanelLayout.MouseDown += PanelLayout_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(499, 4);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(110, 42);
            label1.TabIndex = 5;
            label1.Text = "إرجاع بدل";
            // 
            // btnMinmize
            // 
            btnMinmize.Dock = DockStyle.Left;
            btnMinmize.Image = (Image)resources.GetObject("btnMinmize.Image");
            btnMinmize.Location = new Point(48, 0);
            btnMinmize.Margin = new Padding(0);
            btnMinmize.Name = "btnMinmize";
            btnMinmize.Size = new Size(48, 50);
            btnMinmize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinmize.TabIndex = 4;
            btnMinmize.TabStop = false;
            btnMinmize.Click += btnMinmize_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Left;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(0, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 50);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 70);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(115, 34);
            label2.TabIndex = 1;
            label2.Text = "رقم الأوردر : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 109);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(127, 34);
            label3.TabIndex = 1;
            label3.Text = "أسم المستأجر : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 147);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(113, 34);
            label4.TabIndex = 1;
            label4.Text = "رقم التليفون : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 188);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(82, 34);
            label5.TabIndex = 1;
            label5.Text = "العنوان : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 317);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(107, 34);
            label6.TabIndex = 1;
            label6.Text = "المبلغ الكلي : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(499, 359);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(112, 34);
            label7.TabIndex = 1;
            label7.Text = "المبلغ المتبقي : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 397);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(104, 34);
            label8.TabIndex = 1;
            label8.Text = "عدد القطع : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(499, 439);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(123, 34);
            label9.TabIndex = 1;
            label9.Text = "المرفق المرهن : ";
            // 
            // btnReturnSuit
            // 
            btnReturnSuit.FlatStyle = FlatStyle.Flat;
            btnReturnSuit.ForeColor = Color.Teal;
            btnReturnSuit.Location = new Point(432, 496);
            btnReturnSuit.Name = "btnReturnSuit";
            btnReturnSuit.Size = new Size(167, 46);
            btnReturnSuit.TabIndex = 2;
            btnReturnSuit.Text = "إرجاع البدل";
            btnReturnSuit.UseVisualStyleBackColor = true;
            btnReturnSuit.Click += btnReturnSuit_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.DarkRed;
            btnCancel.Location = new Point(48, 496);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(167, 46);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "إالغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblOrderNum
            // 
            lblOrderNum.ForeColor = Color.FromArgb(192, 0, 0);
            lblOrderNum.Location = new Point(223, 70);
            lblOrderNum.Name = "lblOrderNum";
            lblOrderNum.Size = new Size(286, 34);
            lblOrderNum.TabIndex = 3;
            lblOrderNum.Text = "#No 13";
            lblOrderNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(223, 109);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.RightToLeft = RightToLeft.Yes;
            lblCustomerName.Size = new Size(286, 34);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "حسن خلف حسن توفيق";
            lblCustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Location = new Point(223, 147);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.RightToLeft = RightToLeft.Yes;
            lblPhoneNumber.Size = new Size(286, 34);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "01099774951";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(223, 188);
            lblAddress.Name = "lblAddress";
            lblAddress.RightToLeft = RightToLeft.Yes;
            lblAddress.Size = new Size(286, 34);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "سوهاج المنشاه العيساوية";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Location = new Point(223, 317);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.Yes;
            lblTotalPrice.Size = new Size(286, 34);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "1000.0";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainAmount
            // 
            lblRemainAmount.Location = new Point(223, 353);
            lblRemainAmount.Name = "lblRemainAmount";
            lblRemainAmount.RightToLeft = RightToLeft.Yes;
            lblRemainAmount.Size = new Size(286, 34);
            lblRemainAmount.TabIndex = 3;
            lblRemainAmount.Text = "0.0";
            lblRemainAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemsCount
            // 
            lblItemsCount.Location = new Point(223, 397);
            lblItemsCount.Name = "lblItemsCount";
            lblItemsCount.RightToLeft = RightToLeft.Yes;
            lblItemsCount.Size = new Size(286, 34);
            lblItemsCount.TabIndex = 3;
            lblItemsCount.Text = "5";
            lblItemsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBetAttachment
            // 
            lblBetAttachment.Location = new Point(223, 439);
            lblBetAttachment.Name = "lblBetAttachment";
            lblBetAttachment.RightToLeft = RightToLeft.Yes;
            lblBetAttachment.Size = new Size(286, 34);
            lblBetAttachment.TabIndex = 3;
            lblBetAttachment.Text = "البطاقة الشخصية";
            lblBetAttachment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(499, 228);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(126, 34);
            label10.TabIndex = 1;
            label10.Text = "تارخ الأوردر : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(499, 273);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(140, 34);
            label11.TabIndex = 1;
            label11.Text = "عدد أيام الرهن : ";
            // 
            // lblOrderDate
            // 
            lblOrderDate.Location = new Point(223, 228);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.RightToLeft = RightToLeft.Yes;
            lblOrderDate.Size = new Size(286, 34);
            lblOrderDate.TabIndex = 3;
            lblOrderDate.Text = "2024/08/23";
            lblOrderDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRentDays
            // 
            lblRentDays.Location = new Point(223, 273);
            lblRentDays.Name = "lblRentDays";
            lblRentDays.RightToLeft = RightToLeft.Yes;
            lblRentDays.Size = new Size(286, 34);
            lblRentDays.TabIndex = 3;
            lblRentDays.Text = "10";
            lblRentDays.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGetRemainAmount
            // 
            btnGetRemainAmount.FlatStyle = FlatStyle.Flat;
            btnGetRemainAmount.ForeColor = Color.Green;
            btnGetRemainAmount.Location = new Point(48, 353);
            btnGetRemainAmount.Name = "btnGetRemainAmount";
            btnGetRemainAmount.Size = new Size(167, 46);
            btnGetRemainAmount.TabIndex = 2;
            btnGetRemainAmount.Text = "إستلام المبلغ ";
            btnGetRemainAmount.UseVisualStyleBackColor = true;
            btnGetRemainAmount.Click += btnGetRemainAmount_Click;
            // 
            // ReturnSuit
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 554);
            Controls.Add(lblRentDays);
            Controls.Add(lblBetAttachment);
            Controls.Add(lblOrderDate);
            Controls.Add(lblItemsCount);
            Controls.Add(lblRemainAmount);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCustomerName);
            Controls.Add(lblOrderNum);
            Controls.Add(btnCancel);
            Controls.Add(label11);
            Controls.Add(btnGetRemainAmount);
            Controls.Add(btnReturnSuit);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PanelLayout);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 7, 5, 7);
            Name = "ReturnSuit";
            Text = "ReturnSuit";
            Load += ReturnSuit_Load;
            PanelLayout.ResumeLayout(false);
            PanelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinmize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelLayout;
        private PictureBox btnClose;
        private PictureBox btnMinmize;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnReturnSuit;
        private Button btnCancel;
        private Label lblOrderNum;
        private Label lblCustomerName;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private Label lblTotalPrice;
        private Label lblRemainAmount;
        private Label lblItemsCount;
        private Label lblBetAttachment;
        private Label label10;
        private Label label11;
        private Label lblOrderDate;
        private Label lblRentDays;
        private Button btnGetRemainAmount;
    }
}