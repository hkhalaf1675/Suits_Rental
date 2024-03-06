namespace Suits_Rental.Forms
{
    partial class OrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            panelHead = new Panel();
            label1 = new Label();
            btnClose = new PictureBox();
            panelBottom = new Panel();
            btnReturnOrder = new Button();
            panelContent = new Panel();
            comboAttachmentsAndSizes = new ComboBox();
            btnGetRemainAmount = new Button();
            lblOrderNo = new Label();
            panelRentalType = new Panel();
            label12 = new Label();
            label11 = new Label();
            lblBetAttachment = new Label();
            lblRentDays = new Label();
            label13 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblDiscount = new Label();
            lblRemainAmount = new Label();
            lblTotalPrice = new Label();
            lblNotes = new Label();
            lblCustomerAddress = new Label();
            lblCustomerPhone = new Label();
            lblCustomerName = new Label();
            lblOrderDate = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelBottom.SuspendLayout();
            panelContent.SuspendLayout();
            panelRentalType.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.BackColor = Color.FromArgb(73, 78, 82);
            panelHead.Controls.Add(label1);
            panelHead.Controls.Add(btnClose);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(761, 50);
            panelHead.TabIndex = 0;
            panelHead.MouseDown += panelHead_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(458, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 1;
            label1.Text = "تفاصيل الأوردر";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Left;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(0, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(button1);
            panelBottom.Controls.Add(btnReturnOrder);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelBottom.Location = new Point(0, 517);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(761, 63);
            panelBottom.TabIndex = 1;
            // 
            // btnReturnOrder
            // 
            btnReturnOrder.FlatStyle = FlatStyle.Flat;
            btnReturnOrder.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturnOrder.ForeColor = Color.Teal;
            btnReturnOrder.Location = new Point(440, 6);
            btnReturnOrder.Name = "btnReturnOrder";
            btnReturnOrder.Size = new Size(272, 50);
            btnReturnOrder.TabIndex = 0;
            btnReturnOrder.Text = "إرجاع البدل";
            btnReturnOrder.UseVisualStyleBackColor = true;
            btnReturnOrder.Click += btnReturnOrder_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(comboAttachmentsAndSizes);
            panelContent.Controls.Add(btnGetRemainAmount);
            panelContent.Controls.Add(lblOrderNo);
            panelContent.Controls.Add(panelRentalType);
            panelContent.Controls.Add(label13);
            panelContent.Controls.Add(label10);
            panelContent.Controls.Add(label9);
            panelContent.Controls.Add(label8);
            panelContent.Controls.Add(label7);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(label4);
            panelContent.Controls.Add(lblDiscount);
            panelContent.Controls.Add(lblRemainAmount);
            panelContent.Controls.Add(lblTotalPrice);
            panelContent.Controls.Add(lblNotes);
            panelContent.Controls.Add(lblCustomerAddress);
            panelContent.Controls.Add(lblCustomerPhone);
            panelContent.Controls.Add(lblCustomerName);
            panelContent.Controls.Add(lblOrderDate);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(label2);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelContent.Location = new Point(0, 50);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(761, 467);
            panelContent.TabIndex = 2;
            // 
            // comboAttachmentsAndSizes
            // 
            comboAttachmentsAndSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAttachmentsAndSizes.FlatStyle = FlatStyle.Flat;
            comboAttachmentsAndSizes.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboAttachmentsAndSizes.FormattingEnabled = true;
            comboAttachmentsAndSizes.Location = new Point(213, 342);
            comboAttachmentsAndSizes.Name = "comboAttachmentsAndSizes";
            comboAttachmentsAndSizes.RightToLeft = RightToLeft.Yes;
            comboAttachmentsAndSizes.Size = new Size(296, 28);
            comboAttachmentsAndSizes.TabIndex = 3;
            // 
            // btnGetRemainAmount
            // 
            btnGetRemainAmount.FlatStyle = FlatStyle.Flat;
            btnGetRemainAmount.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetRemainAmount.ForeColor = Color.Green;
            btnGetRemainAmount.Location = new Point(22, 255);
            btnGetRemainAmount.Name = "btnGetRemainAmount";
            btnGetRemainAmount.Size = new Size(185, 50);
            btnGetRemainAmount.TabIndex = 0;
            btnGetRemainAmount.Text = "إستلام المبلغ";
            btnGetRemainAmount.UseVisualStyleBackColor = true;
            btnGetRemainAmount.Click += btnGetRemainAmount_Click;
            // 
            // lblOrderNo
            // 
            lblOrderNo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderNo.ForeColor = Color.Maroon;
            lblOrderNo.Location = new Point(213, 14);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new Size(296, 38);
            lblOrderNo.TabIndex = 2;
            lblOrderNo.Text = "#NO 101";
            lblOrderNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRentalType
            // 
            panelRentalType.Controls.Add(label12);
            panelRentalType.Controls.Add(label11);
            panelRentalType.Controls.Add(lblBetAttachment);
            panelRentalType.Controls.Add(lblRentDays);
            panelRentalType.Dock = DockStyle.Bottom;
            panelRentalType.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelRentalType.Location = new Point(0, 377);
            panelRentalType.Name = "panelRentalType";
            panelRentalType.Size = new Size(761, 90);
            panelRentalType.TabIndex = 1;
            // 
            // label12
            // 
            label12.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(515, 44);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(240, 41);
            label12.TabIndex = 0;
            label12.Text = "المرفق المرهن : ";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(515, 3);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(240, 41);
            label11.TabIndex = 0;
            label11.Text = "عدد أيام الرهن : ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBetAttachment
            // 
            lblBetAttachment.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBetAttachment.Location = new Point(213, 44);
            lblBetAttachment.Name = "lblBetAttachment";
            lblBetAttachment.RightToLeft = RightToLeft.Yes;
            lblBetAttachment.Size = new Size(296, 41);
            lblBetAttachment.TabIndex = 0;
            lblBetAttachment.Text = "البطاقة الشخصية";
            lblBetAttachment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRentDays
            // 
            lblRentDays.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRentDays.Location = new Point(213, 3);
            lblRentDays.Name = "lblRentDays";
            lblRentDays.RightToLeft = RightToLeft.Yes;
            lblRentDays.Size = new Size(296, 41);
            lblRentDays.TabIndex = 0;
            lblRentDays.Text = "3";
            lblRentDays.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(515, 395);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(240, 41);
            label13.TabIndex = 0;
            label13.Text = "الملاحظات : ";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(515, 342);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(240, 41);
            label10.TabIndex = 0;
            label10.Text = "المرفقات والمقاسات : ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(515, 301);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(240, 41);
            label9.TabIndex = 0;
            label9.Text = "الخصم : ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(515, 260);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(240, 41);
            label8.TabIndex = 0;
            label8.Text = "المبلغ المتبقي : ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(515, 219);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(240, 41);
            label7.TabIndex = 0;
            label7.Text = "المبلغ الكلي : ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(515, 178);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(240, 41);
            label6.TabIndex = 0;
            label6.Text = "العنوان : ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(515, 137);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(240, 41);
            label5.TabIndex = 0;
            label5.Text = "رقم التليفون : ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(515, 96);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(240, 41);
            label4.TabIndex = 0;
            label4.Text = "اسم العميل : ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            lblDiscount.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscount.Location = new Point(213, 301);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(296, 41);
            lblDiscount.TabIndex = 0;
            lblDiscount.Text = "10 %";
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainAmount
            // 
            lblRemainAmount.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRemainAmount.Location = new Point(213, 260);
            lblRemainAmount.Name = "lblRemainAmount";
            lblRemainAmount.RightToLeft = RightToLeft.Yes;
            lblRemainAmount.Size = new Size(296, 41);
            lblRemainAmount.TabIndex = 0;
            lblRemainAmount.Text = "0.0";
            lblRemainAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(213, 219);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.Yes;
            lblTotalPrice.Size = new Size(296, 41);
            lblTotalPrice.TabIndex = 0;
            lblTotalPrice.Text = "1000.00";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            lblNotes.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotes.Location = new Point(22, 395);
            lblNotes.Name = "lblNotes";
            lblNotes.RightToLeft = RightToLeft.Yes;
            lblNotes.Size = new Size(487, 41);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "لا يوجد";
            lblNotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerAddress.Location = new Point(213, 178);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.RightToLeft = RightToLeft.Yes;
            lblCustomerAddress.Size = new Size(296, 41);
            lblCustomerAddress.TabIndex = 0;
            lblCustomerAddress.Text = "سوهاج";
            lblCustomerAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerPhone.Location = new Point(213, 137);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.RightToLeft = RightToLeft.No;
            lblCustomerPhone.Size = new Size(296, 41);
            lblCustomerPhone.TabIndex = 0;
            lblCustomerPhone.Text = "01099774951";
            lblCustomerPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            lblCustomerName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerName.Location = new Point(213, 96);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.RightToLeft = RightToLeft.Yes;
            lblCustomerName.Size = new Size(296, 41);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "حسن توفيق";
            lblCustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderDate
            // 
            lblOrderDate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderDate.Location = new Point(213, 55);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.RightToLeft = RightToLeft.Yes;
            lblOrderDate.Size = new Size(296, 41);
            lblOrderDate.TabIndex = 0;
            lblOrderDate.Text = "2024/09/24";
            lblOrderDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(515, 55);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(240, 41);
            label3.TabIndex = 0;
            label3.Text = "تاريخ الأوردر : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(515, 14);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(240, 41);
            label2.TabIndex = 0;
            label2.Text = "رقم الأوردر : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(22, 6);
            button1.Name = "button1";
            button1.Size = new Size(208, 50);
            button1.TabIndex = 0;
            button1.Text = "إلغاء";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClose_Click;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(761, 580);
            Controls.Add(panelContent);
            Controls.Add(panelBottom);
            Controls.Add(panelHead);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(200, 100);
            Margin = new Padding(5, 7, 5, 7);
            Name = "OrderDetails";
            StartPosition = FormStartPosition.Manual;
            Text = "OrderDetails";
            Load += OrderDetails_Load;
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelBottom.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelRentalType.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private PictureBox btnClose;
        private Label label1;
        private Panel panelBottom;
        private Button btnReturnOrder;
        private Panel panelContent;
        private Label label2;
        private Panel panelRentalType;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblOrderNo;
        private Label lblRemainAmount;
        private Label lblTotalPrice;
        private Label lblCustomerAddress;
        private Label lblCustomerPhone;
        private Label lblCustomerName;
        private Label lblOrderDate;
        private ComboBox comboAttachmentsAndSizes;
        private Label lblBetAttachment;
        private Label lblRentDays;
        private Label lblDiscount;
        private Button btnGetRemainAmount;
        private Label label13;
        private Label lblNotes;
        private Button button1;
    }
}