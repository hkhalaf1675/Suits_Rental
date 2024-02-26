namespace Suits_Rental.Forms
{
    partial class MakeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrder));
            PanelLayout = new Panel();
            label1 = new Label();
            btnMinmize = new PictureBox();
            btnClose = new PictureBox();
            panelSuitsSelect = new Panel();
            btnEnsureDeleteSuit = new Button();
            lblSelectedSuits = new Label();
            comboSelectedDeleteSuit = new ComboBox();
            lblDeleteSuitText = new Label();
            comboSuits = new ComboBox();
            label2 = new Label();
            panelCustomerInfo = new Panel();
            comboCustomerName = new ComboBox();
            comboOrderType = new ComboBox();
            txtCustomerAddress = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new TextBox();
            label3 = new Label();
            label12 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            panelRentType = new Panel();
            numericRentDays = new NumericUpDown();
            label7 = new Label();
            txtBetAttachment = new TextBox();
            label8 = new Label();
            panelPrices = new Panel();
            numericDiscount = new NumericUpDown();
            lblRmainAmount = new Label();
            label11 = new Label();
            label13 = new Label();
            numericPaidAmount = new NumericUpDown();
            lblTotalPrice = new Label();
            label10 = new Label();
            label9 = new Label();
            panelButtons = new Panel();
            btnCancel = new Button();
            btnAddOrder = new Button();
            PanelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinmize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelSuitsSelect.SuspendLayout();
            panelCustomerInfo.SuspendLayout();
            panelRentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRentDays).BeginInit();
            panelPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPaidAmount).BeginInit();
            panelButtons.SuspendLayout();
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
            PanelLayout.Size = new Size(900, 50);
            PanelLayout.TabIndex = 1;
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
            label1.Size = new Size(128, 42);
            label1.TabIndex = 5;
            label1.Text = "إضافة أوردر";
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
            // panelSuitsSelect
            // 
            panelSuitsSelect.Controls.Add(btnEnsureDeleteSuit);
            panelSuitsSelect.Controls.Add(lblSelectedSuits);
            panelSuitsSelect.Controls.Add(comboSelectedDeleteSuit);
            panelSuitsSelect.Controls.Add(lblDeleteSuitText);
            panelSuitsSelect.Controls.Add(comboSuits);
            panelSuitsSelect.Controls.Add(label2);
            panelSuitsSelect.Dock = DockStyle.Top;
            panelSuitsSelect.Location = new Point(0, 50);
            panelSuitsSelect.Name = "panelSuitsSelect";
            panelSuitsSelect.Size = new Size(900, 123);
            panelSuitsSelect.TabIndex = 2;
            // 
            // btnEnsureDeleteSuit
            // 
            btnEnsureDeleteSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnsureDeleteSuit.FlatStyle = FlatStyle.Flat;
            btnEnsureDeleteSuit.ForeColor = Color.FromArgb(192, 0, 0);
            btnEnsureDeleteSuit.Location = new Point(171, 63);
            btnEnsureDeleteSuit.Name = "btnEnsureDeleteSuit";
            btnEnsureDeleteSuit.Size = new Size(179, 46);
            btnEnsureDeleteSuit.TabIndex = 3;
            btnEnsureDeleteSuit.Text = "حذف البدلة";
            btnEnsureDeleteSuit.UseVisualStyleBackColor = true;
            btnEnsureDeleteSuit.Click += btnEnsureDeleteSuit_Click;
            // 
            // lblSelectedSuits
            // 
            lblSelectedSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSelectedSuits.AutoSize = true;
            lblSelectedSuits.Location = new Point(171, 16);
            lblSelectedSuits.Name = "lblSelectedSuits";
            lblSelectedSuits.RightToLeft = RightToLeft.Yes;
            lblSelectedSuits.Size = new Size(179, 37);
            lblSelectedSuits.TabIndex = 8;
            lblSelectedSuits.Text = "عدد البدل المختارة : 0";
            // 
            // comboSelectedDeleteSuit
            // 
            comboSelectedDeleteSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboSelectedDeleteSuit.BackColor = Color.White;
            comboSelectedDeleteSuit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSelectedDeleteSuit.FlatStyle = FlatStyle.Flat;
            comboSelectedDeleteSuit.FormattingEnabled = true;
            comboSelectedDeleteSuit.Location = new Point(423, 63);
            comboSelectedDeleteSuit.Name = "comboSelectedDeleteSuit";
            comboSelectedDeleteSuit.RightToLeft = RightToLeft.Yes;
            comboSelectedDeleteSuit.Size = new Size(321, 45);
            comboSelectedDeleteSuit.TabIndex = 2;
            // 
            // lblDeleteSuitText
            // 
            lblDeleteSuitText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDeleteSuitText.AutoSize = true;
            lblDeleteSuitText.Location = new Point(750, 71);
            lblDeleteSuitText.Name = "lblDeleteSuitText";
            lblDeleteSuitText.Size = new Size(133, 37);
            lblDeleteSuitText.TabIndex = 4;
            lblDeleteSuitText.Text = "حذف البدلة رقم";
            // 
            // comboSuits
            // 
            comboSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboSuits.BackColor = Color.White;
            comboSuits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuits.FlatStyle = FlatStyle.Flat;
            comboSuits.FormattingEnabled = true;
            comboSuits.Location = new Point(423, 8);
            comboSuits.Name = "comboSuits";
            comboSuits.RightToLeft = RightToLeft.Yes;
            comboSuits.Size = new Size(321, 45);
            comboSuits.TabIndex = 1;
            comboSuits.SelectionChangeCommitted += comboSuits_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(750, 16);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 5;
            label2.Text = "اختار رقم البدلة";
            // 
            // panelCustomerInfo
            // 
            panelCustomerInfo.Controls.Add(comboCustomerName);
            panelCustomerInfo.Controls.Add(comboOrderType);
            panelCustomerInfo.Controls.Add(txtCustomerAddress);
            panelCustomerInfo.Controls.Add(txtCustomerName);
            panelCustomerInfo.Controls.Add(txtCustomerPhone);
            panelCustomerInfo.Controls.Add(label3);
            panelCustomerInfo.Controls.Add(label12);
            panelCustomerInfo.Controls.Add(label4);
            panelCustomerInfo.Controls.Add(label6);
            panelCustomerInfo.Controls.Add(label5);
            panelCustomerInfo.Dock = DockStyle.Top;
            panelCustomerInfo.Location = new Point(0, 173);
            panelCustomerInfo.Name = "panelCustomerInfo";
            panelCustomerInfo.Size = new Size(900, 194);
            panelCustomerInfo.TabIndex = 3;
            // 
            // comboCustomerName
            // 
            comboCustomerName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCustomerName.FlatStyle = FlatStyle.Flat;
            comboCustomerName.FormattingEnabled = true;
            comboCustomerName.Location = new Point(378, 46);
            comboCustomerName.Name = "comboCustomerName";
            comboCustomerName.RightToLeft = RightToLeft.Yes;
            comboCustomerName.Size = new Size(366, 45);
            comboCustomerName.TabIndex = 4;
            comboCustomerName.SelectionChangeCommitted += comboCustomerName_SelectionChangeCommitted;
            comboCustomerName.TextChanged += comboCustomerName_TextChanged;
            // 
            // comboOrderType
            // 
            comboOrderType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboOrderType.FlatStyle = FlatStyle.Flat;
            comboOrderType.FormattingEnabled = true;
            comboOrderType.Items.AddRange(new object[] { "تأجير", "بيع" });
            comboOrderType.Location = new Point(556, 139);
            comboOrderType.Name = "comboOrderType";
            comboOrderType.RightToLeft = RightToLeft.Yes;
            comboOrderType.Size = new Size(188, 45);
            comboOrderType.TabIndex = 7;
            comboOrderType.SelectionChangeCommitted += comboOrderType_SelectionChangeCommitted;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerAddress.BorderStyle = BorderStyle.None;
            txtCustomerAddress.Location = new Point(378, 96);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.PlaceholderText = "برجاء إدخال عنوان العميل أو لا يوجد";
            txtCustomerAddress.RightToLeft = RightToLeft.Yes;
            txtCustomerAddress.Size = new Size(366, 37);
            txtCustomerAddress.TabIndex = 5;
            txtCustomerAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Location = new Point(13, 49);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "بحث بالأسم أو إضافة عميل جديد";
            txtCustomerName.RightToLeft = RightToLeft.Yes;
            txtCustomerName.Size = new Size(358, 37);
            txtCustomerName.TabIndex = 5;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerPhone.BorderStyle = BorderStyle.None;
            txtCustomerPhone.Location = new Point(12, 96);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.PlaceholderText = "التليفون أو لا يوجد";
            txtCustomerPhone.RightToLeft = RightToLeft.Yes;
            txtCustomerPhone.Size = new Size(254, 37);
            txtCustomerPhone.TabIndex = 6;
            txtCustomerPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(683, 4);
            label3.Name = "label3";
            label3.Size = new Size(132, 42);
            label3.TabIndex = 7;
            label3.Text = "بيانات العميل";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(757, 142);
            label12.Name = "label12";
            label12.Size = new Size(104, 37);
            label12.TabIndex = 8;
            label12.Text = "تأجير او بيع";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(794, 96);
            label4.Name = "label4";
            label4.Size = new Size(67, 37);
            label4.TabIndex = 9;
            label4.Text = "العنوان";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(272, 96);
            label6.Name = "label6";
            label6.Size = new Size(99, 37);
            label6.TabIndex = 10;
            label6.Text = "رقم التليفون";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(794, 46);
            label5.Name = "label5";
            label5.Size = new Size(59, 37);
            label5.TabIndex = 11;
            label5.Text = "الاسم";
            // 
            // panelRentType
            // 
            panelRentType.Controls.Add(numericRentDays);
            panelRentType.Controls.Add(label7);
            panelRentType.Controls.Add(txtBetAttachment);
            panelRentType.Controls.Add(label8);
            panelRentType.Dock = DockStyle.Top;
            panelRentType.Location = new Point(0, 367);
            panelRentType.Name = "panelRentType";
            panelRentType.Size = new Size(900, 51);
            panelRentType.TabIndex = 4;
            // 
            // numericRentDays
            // 
            numericRentDays.BackColor = Color.White;
            numericRentDays.BorderStyle = BorderStyle.None;
            numericRentDays.Location = new Point(13, 6);
            numericRentDays.Name = "numericRentDays";
            numericRentDays.RightToLeft = RightToLeft.Yes;
            numericRentDays.Size = new Size(203, 40);
            numericRentDays.TabIndex = 9;
            numericRentDays.TextAlign = HorizontalAlignment.Center;
            numericRentDays.ValueChanged += numericRentDays_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(757, 6);
            label7.Name = "label7";
            label7.Size = new Size(114, 37);
            label7.TabIndex = 9;
            label7.Text = "المرفق المرهن";
            // 
            // txtBetAttachment
            // 
            txtBetAttachment.BorderStyle = BorderStyle.None;
            txtBetAttachment.Location = new Point(378, 6);
            txtBetAttachment.Name = "txtBetAttachment";
            txtBetAttachment.PlaceholderText = "برجاء إدخال المرفق المرهن أو لا يوجد";
            txtBetAttachment.RightToLeft = RightToLeft.Yes;
            txtBetAttachment.Size = new Size(366, 37);
            txtBetAttachment.TabIndex = 8;
            txtBetAttachment.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(222, 6);
            label8.Name = "label8";
            label8.Size = new Size(128, 37);
            label8.TabIndex = 10;
            label8.Text = "عدد أيام الرهن";
            // 
            // panelPrices
            // 
            panelPrices.Controls.Add(numericDiscount);
            panelPrices.Controls.Add(lblRmainAmount);
            panelPrices.Controls.Add(label11);
            panelPrices.Controls.Add(label13);
            panelPrices.Controls.Add(numericPaidAmount);
            panelPrices.Controls.Add(lblTotalPrice);
            panelPrices.Controls.Add(label10);
            panelPrices.Controls.Add(label9);
            panelPrices.Dock = DockStyle.Top;
            panelPrices.Location = new Point(0, 418);
            panelPrices.Name = "panelPrices";
            panelPrices.Size = new Size(900, 99);
            panelPrices.TabIndex = 5;
            // 
            // numericDiscount
            // 
            numericDiscount.BackColor = Color.White;
            numericDiscount.BorderStyle = BorderStyle.None;
            numericDiscount.DecimalPlaces = 2;
            numericDiscount.Location = new Point(13, 6);
            numericDiscount.Name = "numericDiscount";
            numericDiscount.RightToLeft = RightToLeft.Yes;
            numericDiscount.Size = new Size(203, 40);
            numericDiscount.TabIndex = 11;
            numericDiscount.TextAlign = HorizontalAlignment.Center;
            numericDiscount.ValueChanged += numericDiscount_ValueChanged;
            // 
            // lblRmainAmount
            // 
            lblRmainAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRmainAmount.AutoSize = true;
            lblRmainAmount.Location = new Point(150, 56);
            lblRmainAmount.Name = "lblRmainAmount";
            lblRmainAmount.RightToLeft = RightToLeft.Yes;
            lblRmainAmount.Size = new Size(31, 37);
            lblRmainAmount.TabIndex = 15;
            lblRmainAmount.Text = "0";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(229, 6);
            label11.Name = "label11";
            label11.Size = new Size(143, 37);
            label11.TabIndex = 16;
            label11.Text = "خصم نسبة مئوية";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(248, 56);
            label13.Name = "label13";
            label13.Size = new Size(102, 37);
            label13.TabIndex = 17;
            label13.Text = "المبلغ المتبقي";
            // 
            // numericPaidAmount
            // 
            numericPaidAmount.BackColor = Color.White;
            numericPaidAmount.BorderStyle = BorderStyle.None;
            numericPaidAmount.DecimalPlaces = 2;
            numericPaidAmount.Location = new Point(522, 43);
            numericPaidAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPaidAmount.Name = "numericPaidAmount";
            numericPaidAmount.RightToLeft = RightToLeft.Yes;
            numericPaidAmount.Size = new Size(222, 40);
            numericPaidAmount.TabIndex = 12;
            numericPaidAmount.TextAlign = HorizontalAlignment.Center;
            numericPaidAmount.ValueChanged += numericPaidAmount_ValueChanged;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(648, 3);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.Yes;
            lblTotalPrice.Size = new Size(31, 37);
            lblTotalPrice.TabIndex = 11;
            lblTotalPrice.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(765, 56);
            label10.Name = "label10";
            label10.Size = new Size(109, 37);
            label10.TabIndex = 12;
            label10.Text = "المبلغ المدفوع";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(766, 3);
            label9.Name = "label9";
            label9.Size = new Size(95, 37);
            label9.TabIndex = 13;
            label9.Text = "المبلغ الكلي";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnAddOrder);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 517);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(900, 100);
            panelButtons.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(32, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(184, 49);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.ForeColor = Color.Green;
            btnAddOrder.Location = new Point(497, 22);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(318, 49);
            btnAddOrder.TabIndex = 13;
            btnAddOrder.Text = "تأكيد ";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // MakeOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panelButtons);
            Controls.Add(panelPrices);
            Controls.Add(panelRentType);
            Controls.Add(panelCustomerInfo);
            Controls.Add(panelSuitsSelect);
            Controls.Add(PanelLayout);
            Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            Name = "MakeOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MakeOrder";
            Load += MakeOrder_Load;
            PanelLayout.ResumeLayout(false);
            PanelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinmize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelSuitsSelect.ResumeLayout(false);
            panelSuitsSelect.PerformLayout();
            panelCustomerInfo.ResumeLayout(false);
            panelCustomerInfo.PerformLayout();
            panelRentType.ResumeLayout(false);
            panelRentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericRentDays).EndInit();
            panelPrices.ResumeLayout(false);
            panelPrices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPaidAmount).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLayout;
        private Label label1;
        private PictureBox btnMinmize;
        private PictureBox btnClose;
        private Panel panelSuitsSelect;
        private Button btnEnsureDeleteSuit;
        private Label lblSelectedSuits;
        private ComboBox comboSelectedDeleteSuit;
        private Label lblDeleteSuitText;
        private ComboBox comboSuits;
        private Label label2;
        private Panel panelCustomerInfo;
        private ComboBox comboOrderType;
        private TextBox txtCustomerAddress;
        private TextBox txtCustomerPhone;
        private Label label3;
        private Label label12;
        private Label label4;
        private Label label6;
        private Label label5;
        private Panel panelRentType;
        private NumericUpDown numericRentDays;
        private Label label7;
        private TextBox txtBetAttachment;
        private Label label8;
        private Panel panelPrices;
        private NumericUpDown numericPaidAmount;
        private Label lblTotalPrice;
        private Label label10;
        private Label label9;
        private NumericUpDown numericDiscount;
        private Label lblRmainAmount;
        private Label label11;
        private Label label13;
        private Panel panelButtons;
        private Button btnAddOrder;
        private Button btnCancel;
        private ComboBox comboCustomerName;
        private TextBox txtCustomerName;
    }
}