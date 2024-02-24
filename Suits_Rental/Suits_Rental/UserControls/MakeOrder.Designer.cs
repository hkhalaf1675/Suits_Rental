namespace Suits_Rental.UserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboSuits = new ComboBox();
            lblSelectedSuits = new Label();
            lblDeleteSuitText = new Label();
            comboSelectedDeleteSuit = new ComboBox();
            btnEnsureDeleteSuit = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerAddress = new TextBox();
            txtCustomerPhone = new TextBox();
            label7 = new Label();
            comboOrderType = new ComboBox();
            panelRentType = new Panel();
            numericRentDays = new NumericUpDown();
            txtBetAttachment = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            numericDiscount = new NumericUpDown();
            lblRmainAmount = new Label();
            lblTotalPrice = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label5 = new Label();
            btnAddOrder = new Button();
            label12 = new Label();
            panelRentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRentDays).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(955, 39);
            label1.Name = "label1";
            label1.Size = new Size(128, 37);
            label1.TabIndex = 0;
            label1.Text = "اختار رقم البدلة";
            // 
            // comboSuits
            // 
            comboSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboSuits.BackColor = Color.White;
            comboSuits.FlatStyle = FlatStyle.Flat;
            comboSuits.FormattingEnabled = true;
            comboSuits.Location = new Point(683, 31);
            comboSuits.Name = "comboSuits";
            comboSuits.RightToLeft = RightToLeft.Yes;
            comboSuits.Size = new Size(239, 45);
            comboSuits.TabIndex = 1;
            comboSuits.SelectedIndexChanged += comboSuits_SelectedIndexChanged;
            comboSuits.SelectedValueChanged += comboSuits_SelectedValueChanged;
            // 
            // lblSelectedSuits
            // 
            lblSelectedSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSelectedSuits.AutoSize = true;
            lblSelectedSuits.Location = new Point(353, 34);
            lblSelectedSuits.Name = "lblSelectedSuits";
            lblSelectedSuits.RightToLeft = RightToLeft.Yes;
            lblSelectedSuits.Size = new Size(0, 37);
            lblSelectedSuits.TabIndex = 2;
            // 
            // lblDeleteSuitText
            // 
            lblDeleteSuitText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDeleteSuitText.AutoSize = true;
            lblDeleteSuitText.Location = new Point(955, 111);
            lblDeleteSuitText.Name = "lblDeleteSuitText";
            lblDeleteSuitText.Size = new Size(133, 37);
            lblDeleteSuitText.TabIndex = 0;
            lblDeleteSuitText.Text = "حذف البدلة رقم";
            lblDeleteSuitText.Click += lblDeleteSuitText_Click;
            // 
            // comboSelectedDeleteSuit
            // 
            comboSelectedDeleteSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboSelectedDeleteSuit.BackColor = Color.White;
            comboSelectedDeleteSuit.FlatStyle = FlatStyle.Flat;
            comboSelectedDeleteSuit.FormattingEnabled = true;
            comboSelectedDeleteSuit.Location = new Point(683, 103);
            comboSelectedDeleteSuit.Name = "comboSelectedDeleteSuit";
            comboSelectedDeleteSuit.RightToLeft = RightToLeft.Yes;
            comboSelectedDeleteSuit.Size = new Size(239, 45);
            comboSelectedDeleteSuit.TabIndex = 1;
            comboSelectedDeleteSuit.SelectedIndexChanged += comboSuits_SelectedIndexChanged;
            comboSelectedDeleteSuit.SelectedValueChanged += comboSuits_SelectedValueChanged;
            // 
            // btnEnsureDeleteSuit
            // 
            btnEnsureDeleteSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnsureDeleteSuit.FlatStyle = FlatStyle.Flat;
            btnEnsureDeleteSuit.ForeColor = Color.FromArgb(192, 0, 0);
            btnEnsureDeleteSuit.Location = new Point(435, 103);
            btnEnsureDeleteSuit.Name = "btnEnsureDeleteSuit";
            btnEnsureDeleteSuit.Size = new Size(179, 46);
            btnEnsureDeleteSuit.TabIndex = 0;
            btnEnsureDeleteSuit.Text = "حذف البدلة";
            btnEnsureDeleteSuit.UseVisualStyleBackColor = true;
            btnEnsureDeleteSuit.Click += btnEnsureDeleteSuit_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(873, 170);
            label2.Name = "label2";
            label2.Size = new Size(132, 42);
            label2.TabIndex = 0;
            label2.Text = "بيانات العميل";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1007, 225);
            label3.Name = "label3";
            label3.Size = new Size(59, 37);
            label3.TabIndex = 0;
            label3.Text = "الاسم";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1007, 284);
            label4.Name = "label4";
            label4.Size = new Size(67, 37);
            label4.TabIndex = 0;
            label4.Text = "العنوان";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(320, 218);
            label6.Name = "label6";
            label6.Size = new Size(99, 37);
            label6.TabIndex = 0;
            label6.Text = "رقم التليفون";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Location = new Point(569, 215);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.RightToLeft = RightToLeft.Yes;
            txtCustomerName.Size = new Size(388, 37);
            txtCustomerName.TabIndex = 3;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerAddress.BorderStyle = BorderStyle.None;
            txtCustomerAddress.Location = new Point(327, 277);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.RightToLeft = RightToLeft.Yes;
            txtCustomerAddress.Size = new Size(630, 37);
            txtCustomerAddress.TabIndex = 5;
            txtCustomerAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerPhone.BorderStyle = BorderStyle.None;
            txtCustomerPhone.Location = new Point(31, 215);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.RightToLeft = RightToLeft.Yes;
            txtCustomerPhone.Size = new Size(254, 37);
            txtCustomerPhone.TabIndex = 4;
            txtCustomerPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(983, 12);
            label7.Name = "label7";
            label7.Size = new Size(114, 37);
            label7.TabIndex = 0;
            label7.Text = "المرفق المرهن";
            // 
            // comboOrderType
            // 
            comboOrderType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboOrderType.FlatStyle = FlatStyle.Flat;
            comboOrderType.FormattingEnabled = true;
            comboOrderType.Items.AddRange(new object[] { "تأجير", "بيع" });
            comboOrderType.Location = new Point(769, 348);
            comboOrderType.Name = "comboOrderType";
            comboOrderType.RightToLeft = RightToLeft.Yes;
            comboOrderType.Size = new Size(188, 45);
            comboOrderType.TabIndex = 6;
            comboOrderType.SelectedIndexChanged += comboOrderType_SelectedIndexChanged;
            // 
            // panelRentType
            // 
            panelRentType.Controls.Add(numericRentDays);
            panelRentType.Controls.Add(label7);
            panelRentType.Controls.Add(txtBetAttachment);
            panelRentType.Controls.Add(label8);
            panelRentType.Location = new Point(0, 411);
            panelRentType.Name = "panelRentType";
            panelRentType.Size = new Size(1100, 64);
            panelRentType.TabIndex = 7;
            // 
            // numericRentDays
            // 
            numericRentDays.BackColor = Color.White;
            numericRentDays.BorderStyle = BorderStyle.None;
            numericRentDays.Location = new Point(31, 8);
            numericRentDays.Name = "numericRentDays";
            numericRentDays.RightToLeft = RightToLeft.Yes;
            numericRentDays.Size = new Size(254, 40);
            numericRentDays.TabIndex = 8;
            numericRentDays.Enter += numericUpDown1_Enter;
            // 
            // txtBetAttachment
            // 
            txtBetAttachment.BorderStyle = BorderStyle.None;
            txtBetAttachment.Location = new Point(569, 12);
            txtBetAttachment.Name = "txtBetAttachment";
            txtBetAttachment.RightToLeft = RightToLeft.Yes;
            txtBetAttachment.Size = new Size(388, 37);
            txtBetAttachment.TabIndex = 7;
            txtBetAttachment.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(291, 15);
            label8.Name = "label8";
            label8.Size = new Size(128, 37);
            label8.TabIndex = 0;
            label8.Text = "عدد أيام الرهن";
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(numericDiscount);
            panel1.Controls.Add(lblRmainAmount);
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 110);
            panel1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.White;
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(735, 57);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.RightToLeft = RightToLeft.Yes;
            numericUpDown1.Size = new Size(222, 40);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown1.Enter += numericUpDown1_Enter;
            // 
            // numericDiscount
            // 
            numericDiscount.BackColor = Color.White;
            numericDiscount.BorderStyle = BorderStyle.None;
            numericDiscount.DecimalPlaces = 2;
            numericDiscount.Location = new Point(31, 9);
            numericDiscount.Name = "numericDiscount";
            numericDiscount.RightToLeft = RightToLeft.Yes;
            numericDiscount.Size = new Size(254, 40);
            numericDiscount.TabIndex = 9;
            numericDiscount.ValueChanged += numericDiscount_ValueChanged;
            numericDiscount.Enter += numericUpDown1_Enter;
            // 
            // lblRmainAmount
            // 
            lblRmainAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRmainAmount.AutoSize = true;
            lblRmainAmount.Location = new Point(209, 66);
            lblRmainAmount.Name = "lblRmainAmount";
            lblRmainAmount.RightToLeft = RightToLeft.Yes;
            lblRmainAmount.Size = new Size(31, 37);
            lblRmainAmount.TabIndex = 0;
            lblRmainAmount.Text = "0";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(866, 11);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.Yes;
            lblTotalPrice.Size = new Size(31, 37);
            lblTotalPrice.TabIndex = 0;
            lblTotalPrice.Text = "0";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(291, 11);
            label9.Name = "label9";
            label9.Size = new Size(143, 37);
            label9.TabIndex = 0;
            label9.Text = "خصم نسبة مئوية";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(983, 64);
            label10.Name = "label10";
            label10.Size = new Size(109, 37);
            label10.TabIndex = 0;
            label10.Text = "المبلغ المدفوع";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(320, 64);
            label11.Name = "label11";
            label11.Size = new Size(102, 37);
            label11.TabIndex = 0;
            label11.Text = "المبلغ المتبقي";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(984, 11);
            label5.Name = "label5";
            label5.Size = new Size(95, 37);
            label5.TabIndex = 0;
            label5.Text = "المبلغ الكلي";
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.ForeColor = Color.Green;
            btnAddOrder.Location = new Point(411, 614);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(318, 49);
            btnAddOrder.TabIndex = 9;
            btnAddOrder.Text = "تأكيد ";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(984, 348);
            label12.Name = "label12";
            label12.Size = new Size(104, 37);
            label12.TabIndex = 0;
            label12.Text = "تأجير او بيع";
            // 
            // MakeOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddOrder);
            Controls.Add(panel1);
            Controls.Add(panelRentType);
            Controls.Add(comboOrderType);
            Controls.Add(txtCustomerAddress);
            Controls.Add(txtCustomerPhone);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(btnEnsureDeleteSuit);
            Controls.Add(lblSelectedSuits);
            Controls.Add(comboSelectedDeleteSuit);
            Controls.Add(lblDeleteSuitText);
            Controls.Add(comboSuits);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MakeOrder";
            Size = new Size(1100, 700);
            Load += MakeOrder_Load;
            panelRentType.ResumeLayout(false);
            panelRentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericRentDays).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboSuits;
        private Label lblSelectedSuits;
        private Label lblDeleteSuitText;
        private ComboBox comboSelectedDeleteSuit;
        private Button btnEnsureDeleteSuit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtCustomerName;
        private TextBox txtCustomerAddress;
        private TextBox txtCustomerPhone;
        private Label label7;
        private ComboBox comboOrderType;
        private Panel panelRentType;
        private TextBox txtBetAttachment;
        private NumericUpDown numericRentDays;
        private Label label8;
        private Panel panel1;
        private Label lblTotalPrice;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericDiscount;
        private Label lblRmainAmount;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnAddOrder;
        private Label label12;
    }
}
