namespace Suits_Rental.UserControls
{
    partial class UCMakeOrder
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
            panelHead = new Panel();
            label1 = new Label();
            panelSelectSuits = new Panel();
            panelSelectedSuits = new Panel();
            btnDeleteSuit = new Button();
            comboSelectedSuits = new ComboBox();
            label3 = new Label();
            panelComboSuits = new Panel();
            comboAllAvailableSuits = new ComboBox();
            label2 = new Label();
            panelSuitAttachments = new Panel();
            lblSelectedSuitsCount = new Label();
            label4 = new Label();
            comboAttachmentAndSizes = new ComboBox();
            label16 = new Label();
            panelCustomerInfo = new Panel();
            txtCustomerAddress = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new TextBox();
            comboCustomterName = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            panelOrderType = new Panel();
            comboOrderType = new ComboBox();
            label9 = new Label();
            panelRentalType = new Panel();
            txtBetAttachment = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtRentDays = new TextBox();
            panelPricesSection = new Panel();
            lblRmainAmount = new Label();
            label12 = new Label();
            label13 = new Label();
            txtPaidAmount = new TextBox();
            txtDiscount = new TextBox();
            lblTotalPrice = new Label();
            label14 = new Label();
            label15 = new Label();
            panelButtonsSection = new Panel();
            btnCancel = new Button();
            btnAddOrder = new Button();
            label17 = new Label();
            txtNotes = new TextBox();
            panelHead.SuspendLayout();
            panelSelectSuits.SuspendLayout();
            panelSelectedSuits.SuspendLayout();
            panelComboSuits.SuspendLayout();
            panelSuitAttachments.SuspendLayout();
            panelCustomerInfo.SuspendLayout();
            panelOrderType.SuspendLayout();
            panelRentalType.SuspendLayout();
            panelPricesSection.SuspendLayout();
            panelButtonsSection.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.Controls.Add(label1);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(1050, 50);
            panelHead.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(420, 3);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(128, 42);
            label1.TabIndex = 0;
            label1.Text = "إضافة أوردر";
            // 
            // panelSelectSuits
            // 
            panelSelectSuits.Controls.Add(panelSelectedSuits);
            panelSelectSuits.Controls.Add(panelComboSuits);
            panelSelectSuits.Dock = DockStyle.Top;
            panelSelectSuits.Location = new Point(0, 50);
            panelSelectSuits.Name = "panelSelectSuits";
            panelSelectSuits.Size = new Size(1050, 67);
            panelSelectSuits.TabIndex = 1;
            // 
            // panelSelectedSuits
            // 
            panelSelectedSuits.Controls.Add(btnDeleteSuit);
            panelSelectedSuits.Controls.Add(comboSelectedSuits);
            panelSelectedSuits.Controls.Add(label3);
            panelSelectedSuits.Dock = DockStyle.Fill;
            panelSelectedSuits.Location = new Point(0, 0);
            panelSelectedSuits.Name = "panelSelectedSuits";
            panelSelectedSuits.Size = new Size(574, 67);
            panelSelectedSuits.TabIndex = 3;
            // 
            // btnDeleteSuit
            // 
            btnDeleteSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteSuit.FlatStyle = FlatStyle.Flat;
            btnDeleteSuit.ForeColor = Color.FromArgb(192, 0, 0);
            btnDeleteSuit.Location = new Point(19, 9);
            btnDeleteSuit.Name = "btnDeleteSuit";
            btnDeleteSuit.RightToLeft = RightToLeft.Yes;
            btnDeleteSuit.Size = new Size(131, 45);
            btnDeleteSuit.TabIndex = 3;
            btnDeleteSuit.Text = "حذف البدلة";
            btnDeleteSuit.UseVisualStyleBackColor = true;
            btnDeleteSuit.Click += btnDeleteSuit_Click;
            // 
            // comboSelectedSuits
            // 
            comboSelectedSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboSelectedSuits.BackColor = Color.White;
            comboSelectedSuits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSelectedSuits.FlatStyle = FlatStyle.Popup;
            comboSelectedSuits.FormattingEnabled = true;
            comboSelectedSuits.Location = new Point(169, 9);
            comboSelectedSuits.Name = "comboSelectedSuits";
            comboSelectedSuits.RightToLeft = RightToLeft.Yes;
            comboSelectedSuits.Size = new Size(261, 45);
            comboSelectedSuits.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(440, 12);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(108, 37);
            label3.TabIndex = 0;
            label3.Text = "البدل المختارة";
            // 
            // panelComboSuits
            // 
            panelComboSuits.Controls.Add(comboAllAvailableSuits);
            panelComboSuits.Controls.Add(label2);
            panelComboSuits.Dock = DockStyle.Right;
            panelComboSuits.Location = new Point(574, 0);
            panelComboSuits.Name = "panelComboSuits";
            panelComboSuits.Size = new Size(476, 67);
            panelComboSuits.TabIndex = 2;
            // 
            // comboAllAvailableSuits
            // 
            comboAllAvailableSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboAllAvailableSuits.BackColor = Color.White;
            comboAllAvailableSuits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAllAvailableSuits.FlatStyle = FlatStyle.Popup;
            comboAllAvailableSuits.FormattingEnabled = true;
            comboAllAvailableSuits.Location = new Point(23, 9);
            comboAllAvailableSuits.Name = "comboAllAvailableSuits";
            comboAllAvailableSuits.RightToLeft = RightToLeft.Yes;
            comboAllAvailableSuits.Size = new Size(299, 45);
            comboAllAvailableSuits.TabIndex = 1;
            comboAllAvailableSuits.SelectedIndexChanged += comboAllAvailableSuits_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Location = new Point(344, 8);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(114, 45);
            label2.TabIndex = 0;
            label2.Text = "أختار البدل";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSuitAttachments
            // 
            panelSuitAttachments.Controls.Add(lblSelectedSuitsCount);
            panelSuitAttachments.Controls.Add(label4);
            panelSuitAttachments.Controls.Add(comboAttachmentAndSizes);
            panelSuitAttachments.Controls.Add(label16);
            panelSuitAttachments.Dock = DockStyle.Top;
            panelSuitAttachments.Location = new Point(0, 117);
            panelSuitAttachments.Name = "panelSuitAttachments";
            panelSuitAttachments.Size = new Size(1050, 63);
            panelSuitAttachments.TabIndex = 2;
            // 
            // lblSelectedSuitsCount
            // 
            lblSelectedSuitsCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSelectedSuitsCount.ForeColor = Color.Black;
            lblSelectedSuitsCount.Location = new Point(35, 13);
            lblSelectedSuitsCount.Name = "lblSelectedSuitsCount";
            lblSelectedSuitsCount.RightToLeft = RightToLeft.Yes;
            lblSelectedSuitsCount.Size = new Size(164, 37);
            lblSelectedSuitsCount.TabIndex = 0;
            lblSelectedSuitsCount.Text = "0";
            lblSelectedSuitsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(205, 10);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(164, 37);
            label4.TabIndex = 0;
            label4.Text = "عدد البدل المختارة";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboAttachmentAndSizes
            // 
            comboAttachmentAndSizes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboAttachmentAndSizes.BackColor = Color.White;
            comboAttachmentAndSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAttachmentAndSizes.FlatStyle = FlatStyle.Popup;
            comboAttachmentAndSizes.FormattingEnabled = true;
            comboAttachmentAndSizes.Location = new Point(386, 8);
            comboAttachmentAndSizes.Name = "comboAttachmentAndSizes";
            comboAttachmentAndSizes.RightToLeft = RightToLeft.Yes;
            comboAttachmentAndSizes.Size = new Size(379, 45);
            comboAttachmentAndSizes.TabIndex = 0;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.Location = new Point(771, 7);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(261, 45);
            label16.TabIndex = 0;
            label16.Text = "المرفقات والمقاسات المختارة ";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCustomerInfo
            // 
            panelCustomerInfo.Controls.Add(txtCustomerAddress);
            panelCustomerInfo.Controls.Add(txtCustomerName);
            panelCustomerInfo.Controls.Add(txtCustomerPhone);
            panelCustomerInfo.Controls.Add(comboCustomterName);
            panelCustomerInfo.Controls.Add(label7);
            panelCustomerInfo.Controls.Add(label8);
            panelCustomerInfo.Controls.Add(label6);
            panelCustomerInfo.Controls.Add(label5);
            panelCustomerInfo.Dock = DockStyle.Top;
            panelCustomerInfo.Location = new Point(0, 180);
            panelCustomerInfo.Name = "panelCustomerInfo";
            panelCustomerInfo.Size = new Size(1050, 149);
            panelCustomerInfo.TabIndex = 3;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerAddress.BorderStyle = BorderStyle.None;
            txtCustomerAddress.HideSelection = false;
            txtCustomerAddress.Location = new Point(478, 98);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.PlaceholderText = "برجاء إدخال عنوان العميل أو لا يوجد";
            txtCustomerAddress.RightToLeft = RightToLeft.Yes;
            txtCustomerAddress.Size = new Size(433, 37);
            txtCustomerAddress.TabIndex = 6;
            txtCustomerAddress.TextAlign = HorizontalAlignment.Center;
            txtCustomerAddress.Click += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerAddress.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.HideSelection = false;
            txtCustomerName.Location = new Point(15, 49);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "بحث بالأسم أو إضافة عميل جديد";
            txtCustomerName.RightToLeft = RightToLeft.Yes;
            txtCustomerName.Size = new Size(441, 37);
            txtCustomerName.TabIndex = 5;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            txtCustomerName.Click += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerName.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerPhone.BorderStyle = BorderStyle.None;
            txtCustomerPhone.HideSelection = false;
            txtCustomerPhone.Location = new Point(15, 98);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.PlaceholderText = "التليفون أو لا يوجد";
            txtCustomerPhone.RightToLeft = RightToLeft.Yes;
            txtCustomerPhone.Size = new Size(316, 37);
            txtCustomerPhone.TabIndex = 7;
            txtCustomerPhone.TextAlign = HorizontalAlignment.Center;
            txtCustomerPhone.Click += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerPhone.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerPhone.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            // 
            // comboCustomterName
            // 
            comboCustomterName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboCustomterName.BackColor = Color.White;
            comboCustomterName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCustomterName.FlatStyle = FlatStyle.Popup;
            comboCustomterName.FormattingEnabled = true;
            comboCustomterName.Location = new Point(478, 46);
            comboCustomterName.Name = "comboCustomterName";
            comboCustomterName.RightToLeft = RightToLeft.Yes;
            comboCustomterName.Size = new Size(433, 45);
            comboCustomterName.TabIndex = 4;
            comboCustomterName.SelectedIndexChanged += comboCustomterName_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Location = new Point(342, 98);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(114, 45);
            label7.TabIndex = 0;
            label7.Text = "رقم التليفون";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Location = new Point(933, 98);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(114, 45);
            label8.TabIndex = 0;
            label8.Text = "العنوان";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Location = new Point(933, 45);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(114, 45);
            label6.TabIndex = 0;
            label6.Text = "الأسم";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(706, 3);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(117, 37);
            label5.TabIndex = 0;
            label5.Text = "بيانات العميل";
            // 
            // panelOrderType
            // 
            panelOrderType.Controls.Add(comboOrderType);
            panelOrderType.Controls.Add(label9);
            panelOrderType.Dock = DockStyle.Top;
            panelOrderType.Location = new Point(0, 329);
            panelOrderType.Name = "panelOrderType";
            panelOrderType.Size = new Size(1050, 58);
            panelOrderType.TabIndex = 4;
            // 
            // comboOrderType
            // 
            comboOrderType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboOrderType.FlatStyle = FlatStyle.Flat;
            comboOrderType.FormattingEnabled = true;
            comboOrderType.Items.AddRange(new object[] { "تأجير", "بيع" });
            comboOrderType.Location = new Point(637, 6);
            comboOrderType.Name = "comboOrderType";
            comboOrderType.RightToLeft = RightToLeft.Yes;
            comboOrderType.Size = new Size(274, 45);
            comboOrderType.TabIndex = 8;
            comboOrderType.SelectedIndexChanged += comboOrderType_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Location = new Point(933, 2);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(114, 45);
            label9.TabIndex = 0;
            label9.Text = "نوع الأوردر";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRentalType
            // 
            panelRentalType.Controls.Add(txtBetAttachment);
            panelRentalType.Controls.Add(label11);
            panelRentalType.Controls.Add(label10);
            panelRentalType.Controls.Add(txtRentDays);
            panelRentalType.Dock = DockStyle.Top;
            panelRentalType.Location = new Point(0, 387);
            panelRentalType.Name = "panelRentalType";
            panelRentalType.Size = new Size(1050, 58);
            panelRentalType.TabIndex = 5;
            panelRentalType.Visible = false;
            // 
            // txtBetAttachment
            // 
            txtBetAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBetAttachment.BorderStyle = BorderStyle.None;
            txtBetAttachment.HideSelection = false;
            txtBetAttachment.Location = new Point(478, 10);
            txtBetAttachment.Name = "txtBetAttachment";
            txtBetAttachment.PlaceholderText = "برجاء إدخال المرفق المرهن أو لا يوجد";
            txtBetAttachment.RightToLeft = RightToLeft.Yes;
            txtBetAttachment.Size = new Size(433, 37);
            txtBetAttachment.TabIndex = 9;
            txtBetAttachment.TextAlign = HorizontalAlignment.Center;
            txtBetAttachment.Click += TxtBoxSelectAll_ClickTapIndex;
            txtBetAttachment.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Location = new Point(933, 6);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(114, 45);
            label11.TabIndex = 0;
            label11.Text = "المرفق المرهن";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Location = new Point(292, 5);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(153, 45);
            label10.TabIndex = 0;
            label10.Text = "عدد أيام الرهن";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRentDays
            // 
            txtRentDays.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRentDays.BorderStyle = BorderStyle.None;
            txtRentDays.HideSelection = false;
            txtRentDays.Location = new Point(58, 9);
            txtRentDays.Name = "txtRentDays";
            txtRentDays.PlaceholderText = "عدد الأيام";
            txtRentDays.RightToLeft = RightToLeft.Yes;
            txtRentDays.Size = new Size(215, 37);
            txtRentDays.TabIndex = 10;
            txtRentDays.Text = "0";
            txtRentDays.TextAlign = HorizontalAlignment.Center;
            txtRentDays.Click += TxtBoxSelectAll_ClickTapIndex;
            txtRentDays.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtRentDays.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtRentDays.Leave += TxtBoxMinZero_Leave;
            // 
            // panelPricesSection
            // 
            panelPricesSection.Controls.Add(lblRmainAmount);
            panelPricesSection.Controls.Add(label12);
            panelPricesSection.Controls.Add(label13);
            panelPricesSection.Controls.Add(txtPaidAmount);
            panelPricesSection.Controls.Add(txtDiscount);
            panelPricesSection.Controls.Add(lblTotalPrice);
            panelPricesSection.Controls.Add(label14);
            panelPricesSection.Controls.Add(label15);
            panelPricesSection.Dock = DockStyle.Top;
            panelPricesSection.Location = new Point(0, 445);
            panelPricesSection.Name = "panelPricesSection";
            panelPricesSection.Size = new Size(1050, 109);
            panelPricesSection.TabIndex = 6;
            // 
            // lblRmainAmount
            // 
            lblRmainAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRmainAmount.Location = new Point(104, 56);
            lblRmainAmount.Name = "lblRmainAmount";
            lblRmainAmount.RightToLeft = RightToLeft.Yes;
            lblRmainAmount.Size = new Size(169, 37);
            lblRmainAmount.TabIndex = 0;
            lblRmainAmount.Text = "0";
            lblRmainAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.Location = new Point(292, 8);
            label12.Name = "label12";
            label12.Size = new Size(143, 37);
            label12.TabIndex = 0;
            label12.Text = "خصم نسبة مئوية";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.Location = new Point(289, 56);
            label13.Name = "label13";
            label13.Size = new Size(146, 37);
            label13.TabIndex = 0;
            label13.Text = "المبلغ المتبقي";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPaidAmount.BorderStyle = BorderStyle.None;
            txtPaidAmount.HideSelection = false;
            txtPaidAmount.Location = new Point(664, 56);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.RightToLeft = RightToLeft.Yes;
            txtPaidAmount.Size = new Size(247, 37);
            txtPaidAmount.TabIndex = 12;
            txtPaidAmount.Text = "0";
            txtPaidAmount.TextAlign = HorizontalAlignment.Center;
            txtPaidAmount.Click += TxtBoxSelectAll_ClickTapIndex;
            txtPaidAmount.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtPaidAmount.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtPaidAmount.Leave += TxtBoxMinZero_Leave;
            // 
            // txtDiscount
            // 
            txtDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDiscount.BorderStyle = BorderStyle.None;
            txtDiscount.HideSelection = false;
            txtDiscount.Location = new Point(58, 8);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.PlaceholderText = "من 0 إلي 100";
            txtDiscount.RightToLeft = RightToLeft.Yes;
            txtDiscount.Size = new Size(215, 37);
            txtDiscount.TabIndex = 11;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Center;
            txtDiscount.Click += TxtBoxSelectAll_ClickTapIndex;
            txtDiscount.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtDiscount.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtDiscount.Leave += TxtBoxMinZero_Leave;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPrice.Location = new Point(664, 5);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.Yes;
            lblTotalPrice.Size = new Size(247, 37);
            lblTotalPrice.TabIndex = 0;
            lblTotalPrice.Text = "0";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.Location = new Point(933, 56);
            label14.Name = "label14";
            label14.Size = new Size(114, 37);
            label14.TabIndex = 0;
            label14.Text = "المبلغ المدفوع";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.Location = new Point(933, 5);
            label15.Name = "label15";
            label15.Size = new Size(114, 37);
            label15.TabIndex = 0;
            label15.Text = "المبلغ الكلي";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelButtonsSection
            // 
            panelButtonsSection.Controls.Add(txtNotes);
            panelButtonsSection.Controls.Add(btnCancel);
            panelButtonsSection.Controls.Add(btnAddOrder);
            panelButtonsSection.Controls.Add(label17);
            panelButtonsSection.Dock = DockStyle.Fill;
            panelButtonsSection.Location = new Point(0, 554);
            panelButtonsSection.Name = "panelButtonsSection";
            panelButtonsSection.Size = new Size(1050, 136);
            panelButtonsSection.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(89, 72);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(184, 49);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.ForeColor = Color.Green;
            btnAddOrder.Location = new Point(597, 72);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(318, 49);
            btnAddOrder.TabIndex = 14;
            btnAddOrder.Text = "تأكيد ";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.Location = new Point(918, 18);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.Yes;
            label17.Size = new Size(114, 45);
            label17.TabIndex = 0;
            label17.Text = "ملاحظات";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.HideSelection = false;
            txtNotes.Location = new Point(58, 18);
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.Size = new Size(838, 37);
            txtNotes.TabIndex = 13;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            txtNotes.Click += TxtBoxSelectAll_ClickTapIndex;
            txtNotes.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            // 
            // UCMakeOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(panelButtonsSection);
            Controls.Add(panelPricesSection);
            Controls.Add(panelRentalType);
            Controls.Add(panelOrderType);
            Controls.Add(panelCustomerInfo);
            Controls.Add(panelSuitAttachments);
            Controls.Add(panelSelectSuits);
            Controls.Add(panelHead);
            Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "UCMakeOrder";
            Size = new Size(1050, 690);
            Load += UCMakeOrder_Load;
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            panelSelectSuits.ResumeLayout(false);
            panelSelectedSuits.ResumeLayout(false);
            panelSelectedSuits.PerformLayout();
            panelComboSuits.ResumeLayout(false);
            panelSuitAttachments.ResumeLayout(false);
            panelCustomerInfo.ResumeLayout(false);
            panelCustomerInfo.PerformLayout();
            panelOrderType.ResumeLayout(false);
            panelRentalType.ResumeLayout(false);
            panelRentalType.PerformLayout();
            panelPricesSection.ResumeLayout(false);
            panelPricesSection.PerformLayout();
            panelButtonsSection.ResumeLayout(false);
            panelButtonsSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Label label1;
        private Panel panelSelectSuits;
        private Label label2;
        private ComboBox comboAllAvailableSuits;
        private Panel panelComboSuits;
        private Panel panelSelectedSuits;
        private Button btnDeleteSuit;
        private ComboBox comboSelectedSuits;
        private Label label3;
        private Panel panelSuitAttachments;
        private Panel panelCustomerInfo;
        private ComboBox comboCustomterName;
        private Label label5;
        private Label label6;
        private TextBox txtCustomerAddress;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private Label label7;
        private Label label8;
        private Panel panelOrderType;
        private ComboBox comboOrderType;
        private Label label9;
        private Panel panelRentalType;
        private TextBox txtBetAttachment;
        private Label label11;
        private Label label10;
        private TextBox txtRentDays;
        private Panel panelPricesSection;
        private Label lblRmainAmount;
        private Label label12;
        private Label label13;
        private TextBox txtPaidAmount;
        private TextBox txtDiscount;
        private Label lblTotalPrice;
        private Label label14;
        private Label label15;
        private Panel panelButtonsSection;
        private Button btnCancel;
        private Button btnAddOrder;
        private ComboBox comboAttachmentAndSizes;
        private Label label16;
        private Label lblSelectedSuitsCount;
        private Label label4;
        private TextBox txtNotes;
        private Label label17;
    }
}
