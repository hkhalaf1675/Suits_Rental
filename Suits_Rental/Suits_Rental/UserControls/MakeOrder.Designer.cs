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
            tlpContainer = new TableLayoutPanel();
            tlpHead = new TableLayoutPanel();
            label1 = new Label();
            tlpSelectSuits = new TableLayoutPanel();
            label19 = new Label();
            comboAllAvailableSuits = new ComboBox();
            label2 = new Label();
            comboSelectedSuits = new ComboBox();
            btnDeleteSuit = new Button();
            label3 = new Label();
            cmbAvailableSuitSizes = new ComboBox();
            tlpAttachmentsSizesAndDate = new TableLayoutPanel();
            label16 = new Label();
            comboAttachmentAndSizes = new ComboBox();
            label4 = new Label();
            dateTimeOrderDate = new DateTimePicker();
            label18 = new Label();
            lblSelectedSuitsCount = new Label();
            tlpCustomerInfoTitle = new TableLayoutPanel();
            label5 = new Label();
            tlpCustomerInfo1 = new TableLayoutPanel();
            txtCustomerName = new TextBox();
            comboCustomterName = new ComboBox();
            label6 = new Label();
            tlpCustomerInfo2 = new TableLayoutPanel();
            label7 = new Label();
            txtCustomerAddress = new TextBox();
            label8 = new Label();
            txtCustomerPhone = new TextBox();
            tlpOrderType = new TableLayoutPanel();
            comboOrderType = new ComboBox();
            label9 = new Label();
            tlpRentalType = new TableLayoutPanel();
            label10 = new Label();
            txtBetAttachment = new TextBox();
            label11 = new Label();
            txtRentDays = new TextBox();
            tlpPrices = new TableLayoutPanel();
            label14 = new Label();
            label15 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblTotalPrice = new Label();
            lblRmainAmount = new Label();
            txtPaidAmount = new TextBox();
            txtDiscount = new TextBox();
            tlpNotes = new TableLayoutPanel();
            txtNotes = new TextBox();
            label17 = new Label();
            tlpButtons = new TableLayoutPanel();
            btnAddOrder = new Button();
            btnCancel = new Button();
            tlpContainer.SuspendLayout();
            tlpHead.SuspendLayout();
            tlpSelectSuits.SuspendLayout();
            tlpAttachmentsSizesAndDate.SuspendLayout();
            tlpCustomerInfoTitle.SuspendLayout();
            tlpCustomerInfo1.SuspendLayout();
            tlpCustomerInfo2.SuspendLayout();
            tlpOrderType.SuspendLayout();
            tlpRentalType.SuspendLayout();
            tlpPrices.SuspendLayout();
            tlpNotes.SuspendLayout();
            tlpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 1;
            tlpContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContainer.Controls.Add(tlpHead, 0, 0);
            tlpContainer.Controls.Add(tlpSelectSuits, 0, 1);
            tlpContainer.Controls.Add(tlpAttachmentsSizesAndDate, 0, 2);
            tlpContainer.Controls.Add(tlpCustomerInfoTitle, 0, 3);
            tlpContainer.Controls.Add(tlpCustomerInfo1, 0, 4);
            tlpContainer.Controls.Add(tlpCustomerInfo2, 0, 5);
            tlpContainer.Controls.Add(tlpOrderType, 0, 6);
            tlpContainer.Controls.Add(tlpRentalType, 0, 7);
            tlpContainer.Controls.Add(tlpPrices, 0, 8);
            tlpContainer.Controls.Add(tlpNotes, 0, 9);
            tlpContainer.Controls.Add(tlpButtons, 0, 10);
            tlpContainer.Dock = DockStyle.Fill;
            tlpContainer.Location = new Point(0, 0);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RightToLeft = RightToLeft.Yes;
            tlpContainer.RowCount = 12;
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 5.050505F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 8.080808F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1616154F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 5.050505F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 8.080808F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 8.080808F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 8.080808F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 8.080808F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1616154F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 8.080808F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 8.080808F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 1.010101F));
            tlpContainer.Size = new Size(858, 679);
            tlpContainer.TabIndex = 0;
            // 
            // tlpHead
            // 
            tlpHead.ColumnCount = 7;
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tlpHead.Controls.Add(label1, 3, 0);
            tlpHead.Dock = DockStyle.Fill;
            tlpHead.Location = new Point(3, 3);
            tlpHead.Name = "tlpHead";
            tlpHead.RowCount = 1;
            tlpHead.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHead.Size = new Size(852, 28);
            tlpHead.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(372, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(105, 28);
            label1.TabIndex = 1;
            label1.Text = "إضافة أوردر";
            // 
            // tlpSelectSuits
            // 
            tlpSelectSuits.ColumnCount = 8;
            tlpSelectSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6813183F));
            tlpSelectSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2912083F));
            tlpSelectSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tlpSelectSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tlpSelectSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tlpSelectSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6882668F));
            tlpSelectSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7670746F));
            tlpSelectSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9649734F));
            tlpSelectSuits.Controls.Add(label19, 0, 0);
            tlpSelectSuits.Controls.Add(comboAllAvailableSuits, 0, 0);
            tlpSelectSuits.Controls.Add(label2, 0, 0);
            tlpSelectSuits.Controls.Add(comboSelectedSuits, 6, 0);
            tlpSelectSuits.Controls.Add(btnDeleteSuit, 7, 0);
            tlpSelectSuits.Controls.Add(label3, 5, 0);
            tlpSelectSuits.Controls.Add(cmbAvailableSuitSizes, 3, 0);
            tlpSelectSuits.Dock = DockStyle.Fill;
            tlpSelectSuits.Location = new Point(3, 37);
            tlpSelectSuits.Name = "tlpSelectSuits";
            tlpSelectSuits.RowCount = 1;
            tlpSelectSuits.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSelectSuits.Size = new Size(852, 48);
            tlpSelectSuits.TabIndex = 1;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(508, 0);
            label19.Name = "label19";
            label19.RightToLeft = RightToLeft.Yes;
            label19.Size = new Size(100, 48);
            label19.TabIndex = 6;
            label19.Text = "مقاس البدلة";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboAllAvailableSuits
            // 
            comboAllAvailableSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboAllAvailableSuits.BackColor = Color.White;
            comboAllAvailableSuits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAllAvailableSuits.FlatStyle = FlatStyle.Popup;
            comboAllAvailableSuits.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboAllAvailableSuits.FormattingEnabled = true;
            comboAllAvailableSuits.Location = new Point(616, 3);
            comboAllAvailableSuits.Name = "comboAllAvailableSuits";
            comboAllAvailableSuits.RightToLeft = RightToLeft.Yes;
            comboAllAvailableSuits.Size = new Size(115, 35);
            comboAllAvailableSuits.TabIndex = 2;
            comboAllAvailableSuits.SelectedIndexChanged += comboAllAvailableSuits_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(743, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(100, 48);
            label2.TabIndex = 1;
            label2.Text = "أختار البدل";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboSelectedSuits
            // 
            comboSelectedSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboSelectedSuits.BackColor = Color.White;
            comboSelectedSuits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSelectedSuits.FlatStyle = FlatStyle.Popup;
            comboSelectedSuits.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboSelectedSuits.FormattingEnabled = true;
            comboSelectedSuits.Location = new Point(124, 3);
            comboSelectedSuits.Name = "comboSelectedSuits";
            comboSelectedSuits.RightToLeft = RightToLeft.Yes;
            comboSelectedSuits.Size = new Size(124, 35);
            comboSelectedSuits.TabIndex = 4;
            // 
            // btnDeleteSuit
            // 
            btnDeleteSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteSuit.FlatStyle = FlatStyle.Flat;
            btnDeleteSuit.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteSuit.ForeColor = Color.FromArgb(192, 0, 0);
            btnDeleteSuit.Location = new Point(3, 3);
            btnDeleteSuit.Name = "btnDeleteSuit";
            btnDeleteSuit.RightToLeft = RightToLeft.Yes;
            btnDeleteSuit.Size = new Size(108, 42);
            btnDeleteSuit.TabIndex = 5;
            btnDeleteSuit.Text = "حذف البدلة";
            btnDeleteSuit.UseVisualStyleBackColor = true;
            btnDeleteSuit.Click += btnDeleteSuit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(260, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(92, 48);
            label3.TabIndex = 3;
            label3.Text = "البدل المختارة";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbAvailableSuitSizes
            // 
            cmbAvailableSuitSizes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbAvailableSuitSizes.BackColor = Color.White;
            cmbAvailableSuitSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailableSuitSizes.FlatStyle = FlatStyle.Popup;
            cmbAvailableSuitSizes.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cmbAvailableSuitSizes.FormattingEnabled = true;
            cmbAvailableSuitSizes.Location = new Point(379, 3);
            cmbAvailableSuitSizes.Name = "cmbAvailableSuitSizes";
            cmbAvailableSuitSizes.RightToLeft = RightToLeft.Yes;
            cmbAvailableSuitSizes.Size = new Size(115, 35);
            cmbAvailableSuitSizes.TabIndex = 7;
            cmbAvailableSuitSizes.SelectedIndexChanged += cmbAvailableSuitSizes_SelectedIndexChanged;
            // 
            // tlpAttachmentsSizesAndDate
            // 
            tlpAttachmentsSizesAndDate.ColumnCount = 3;
            tlpAttachmentsSizesAndDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpAttachmentsSizesAndDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpAttachmentsSizesAndDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpAttachmentsSizesAndDate.Controls.Add(label16, 0, 0);
            tlpAttachmentsSizesAndDate.Controls.Add(comboAttachmentAndSizes, 1, 0);
            tlpAttachmentsSizesAndDate.Controls.Add(label4, 2, 0);
            tlpAttachmentsSizesAndDate.Controls.Add(dateTimeOrderDate, 1, 1);
            tlpAttachmentsSizesAndDate.Controls.Add(label18, 0, 1);
            tlpAttachmentsSizesAndDate.Controls.Add(lblSelectedSuitsCount, 2, 1);
            tlpAttachmentsSizesAndDate.Dock = DockStyle.Fill;
            tlpAttachmentsSizesAndDate.Location = new Point(3, 91);
            tlpAttachmentsSizesAndDate.Name = "tlpAttachmentsSizesAndDate";
            tlpAttachmentsSizesAndDate.RowCount = 2;
            tlpAttachmentsSizesAndDate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAttachmentsSizesAndDate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAttachmentsSizesAndDate.Size = new Size(852, 103);
            tlpAttachmentsSizesAndDate.TabIndex = 2;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(685, 0);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(164, 51);
            label16.TabIndex = 1;
            label16.Text = "المرفقات والمقاسات المختارة ";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboAttachmentAndSizes
            // 
            comboAttachmentAndSizes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboAttachmentAndSizes.BackColor = Color.White;
            comboAttachmentAndSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAttachmentAndSizes.FlatStyle = FlatStyle.Popup;
            comboAttachmentAndSizes.Font = new Font("Arabic Typesetting", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboAttachmentAndSizes.FormattingEnabled = true;
            comboAttachmentAndSizes.Location = new Point(302, 3);
            comboAttachmentAndSizes.Name = "comboAttachmentAndSizes";
            comboAttachmentAndSizes.RightToLeft = RightToLeft.Yes;
            comboAttachmentAndSizes.Size = new Size(377, 32);
            comboAttachmentAndSizes.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(293, 51);
            label4.TabIndex = 6;
            label4.Text = "عدد البدل المختارة";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeOrderDate
            // 
            dateTimeOrderDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimeOrderDate.Font = new Font("Arabic Typesetting", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeOrderDate.Location = new Point(302, 54);
            dateTimeOrderDate.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimeOrderDate.Name = "dateTimeOrderDate";
            dateTimeOrderDate.RightToLeftLayout = true;
            dateTimeOrderDate.Size = new Size(377, 32);
            dateTimeOrderDate.TabIndex = 5;
            dateTimeOrderDate.ValueChanged += dateTimeOrderDate_ValueChanged;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(685, 51);
            label18.Name = "label18";
            label18.RightToLeft = RightToLeft.Yes;
            label18.Size = new Size(164, 52);
            label18.TabIndex = 2;
            label18.Text = "التاريخ";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSelectedSuitsCount
            // 
            lblSelectedSuitsCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSelectedSuitsCount.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedSuitsCount.ForeColor = Color.Black;
            lblSelectedSuitsCount.Location = new Point(3, 51);
            lblSelectedSuitsCount.Name = "lblSelectedSuitsCount";
            lblSelectedSuitsCount.RightToLeft = RightToLeft.Yes;
            lblSelectedSuitsCount.Size = new Size(293, 52);
            lblSelectedSuitsCount.TabIndex = 7;
            lblSelectedSuitsCount.Text = "0";
            lblSelectedSuitsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpCustomerInfoTitle
            // 
            tlpCustomerInfoTitle.ColumnCount = 3;
            tlpCustomerInfoTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCustomerInfoTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCustomerInfoTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 464F));
            tlpCustomerInfoTitle.Controls.Add(label5, 1, 0);
            tlpCustomerInfoTitle.Dock = DockStyle.Fill;
            tlpCustomerInfoTitle.Location = new Point(3, 200);
            tlpCustomerInfoTitle.Name = "tlpCustomerInfoTitle";
            tlpCustomerInfoTitle.RowCount = 1;
            tlpCustomerInfoTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCustomerInfoTitle.Size = new Size(852, 28);
            tlpCustomerInfoTitle.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(467, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(179, 28);
            label5.TabIndex = 1;
            label5.Text = "بيانات العميل";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpCustomerInfo1
            // 
            tlpCustomerInfo1.ColumnCount = 3;
            tlpCustomerInfo1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpCustomerInfo1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpCustomerInfo1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpCustomerInfo1.Controls.Add(txtCustomerName, 0, 0);
            tlpCustomerInfo1.Controls.Add(comboCustomterName, 0, 0);
            tlpCustomerInfo1.Controls.Add(label6, 0, 0);
            tlpCustomerInfo1.Dock = DockStyle.Fill;
            tlpCustomerInfo1.Location = new Point(3, 234);
            tlpCustomerInfo1.Name = "tlpCustomerInfo1";
            tlpCustomerInfo1.RowCount = 1;
            tlpCustomerInfo1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCustomerInfo1.Size = new Size(852, 48);
            tlpCustomerInfo1.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustomerName.HideSelection = false;
            txtCustomerName.Location = new Point(3, 3);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "بحث بالأسم أو إضافة عميل جديد";
            txtCustomerName.RightToLeft = RightToLeft.Yes;
            txtCustomerName.Size = new Size(379, 42);
            txtCustomerName.TabIndex = 7;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            txtCustomerName.Click += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerName.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // comboCustomterName
            // 
            comboCustomterName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboCustomterName.BackColor = Color.White;
            comboCustomterName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCustomterName.FlatStyle = FlatStyle.Popup;
            comboCustomterName.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboCustomterName.FormattingEnabled = true;
            comboCustomterName.Location = new Point(388, 3);
            comboCustomterName.Name = "comboCustomterName";
            comboCustomterName.RightToLeft = RightToLeft.Yes;
            comboCustomterName.Size = new Size(334, 35);
            comboCustomterName.TabIndex = 6;
            comboCustomterName.SelectedIndexChanged += comboCustomterName_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(728, 0);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(121, 48);
            label6.TabIndex = 1;
            label6.Text = "الأسم";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpCustomerInfo2
            // 
            tlpCustomerInfo2.ColumnCount = 4;
            tlpCustomerInfo2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpCustomerInfo2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpCustomerInfo2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpCustomerInfo2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpCustomerInfo2.Controls.Add(label7, 0, 0);
            tlpCustomerInfo2.Controls.Add(txtCustomerAddress, 0, 0);
            tlpCustomerInfo2.Controls.Add(label8, 0, 0);
            tlpCustomerInfo2.Controls.Add(txtCustomerPhone, 3, 0);
            tlpCustomerInfo2.Dock = DockStyle.Fill;
            tlpCustomerInfo2.Location = new Point(3, 288);
            tlpCustomerInfo2.Name = "tlpCustomerInfo2";
            tlpCustomerInfo2.RowCount = 1;
            tlpCustomerInfo2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCustomerInfo2.Size = new Size(852, 48);
            tlpCustomerInfo2.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(303, 0);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(121, 48);
            label7.TabIndex = 9;
            label7.Text = "رقم التليفون";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerAddress.BorderStyle = BorderStyle.None;
            txtCustomerAddress.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustomerAddress.HideSelection = false;
            txtCustomerAddress.Location = new Point(430, 3);
            txtCustomerAddress.Multiline = true;
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.PlaceholderText = "برجاء إدخال عنوان العميل أو لا يوجد";
            txtCustomerAddress.RightToLeft = RightToLeft.Yes;
            txtCustomerAddress.Size = new Size(292, 42);
            txtCustomerAddress.TabIndex = 8;
            txtCustomerAddress.TextAlign = HorizontalAlignment.Center;
            txtCustomerAddress.Click += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerAddress.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(728, 0);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(121, 45);
            label8.TabIndex = 1;
            label8.Text = "العنوان";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerPhone.BorderStyle = BorderStyle.None;
            txtCustomerPhone.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtCustomerPhone.HideSelection = false;
            txtCustomerPhone.Location = new Point(3, 3);
            txtCustomerPhone.Multiline = true;
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.PlaceholderText = "التليفون أو لا يوجد";
            txtCustomerPhone.RightToLeft = RightToLeft.Yes;
            txtCustomerPhone.Size = new Size(294, 42);
            txtCustomerPhone.TabIndex = 9;
            txtCustomerPhone.TextAlign = HorizontalAlignment.Center;
            txtCustomerPhone.Click += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerPhone.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtCustomerPhone.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            // 
            // tlpOrderType
            // 
            tlpOrderType.ColumnCount = 3;
            tlpOrderType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpOrderType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpOrderType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpOrderType.Controls.Add(comboOrderType, 0, 0);
            tlpOrderType.Controls.Add(label9, 0, 0);
            tlpOrderType.Dock = DockStyle.Fill;
            tlpOrderType.Location = new Point(3, 342);
            tlpOrderType.Name = "tlpOrderType";
            tlpOrderType.RowCount = 1;
            tlpOrderType.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpOrderType.Size = new Size(852, 48);
            tlpOrderType.TabIndex = 6;
            // 
            // comboOrderType
            // 
            comboOrderType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboOrderType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOrderType.FlatStyle = FlatStyle.Flat;
            comboOrderType.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboOrderType.FormattingEnabled = true;
            comboOrderType.Items.AddRange(new object[] { "تأجير", "بيع" });
            comboOrderType.Location = new Point(345, 3);
            comboOrderType.Name = "comboOrderType";
            comboOrderType.RightToLeft = RightToLeft.Yes;
            comboOrderType.Size = new Size(334, 35);
            comboOrderType.TabIndex = 10;
            comboOrderType.SelectedIndexChanged += comboOrderType_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(685, 0);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(164, 48);
            label9.TabIndex = 1;
            label9.Text = "نوع الأوردر";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpRentalType
            // 
            tlpRentalType.ColumnCount = 4;
            tlpRentalType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpRentalType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpRentalType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpRentalType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRentalType.Controls.Add(label10, 0, 0);
            tlpRentalType.Controls.Add(txtBetAttachment, 0, 0);
            tlpRentalType.Controls.Add(label11, 0, 0);
            tlpRentalType.Controls.Add(txtRentDays, 3, 0);
            tlpRentalType.Dock = DockStyle.Fill;
            tlpRentalType.Location = new Point(3, 396);
            tlpRentalType.Name = "tlpRentalType";
            tlpRentalType.RowCount = 1;
            tlpRentalType.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRentalType.Size = new Size(852, 48);
            tlpRentalType.TabIndex = 7;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(217, 0);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(151, 48);
            label10.TabIndex = 12;
            label10.Text = "عدد أيام الرهن";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBetAttachment
            // 
            txtBetAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBetAttachment.BorderStyle = BorderStyle.None;
            txtBetAttachment.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtBetAttachment.HideSelection = false;
            txtBetAttachment.Location = new Point(387, 3);
            txtBetAttachment.Multiline = true;
            txtBetAttachment.Name = "txtBetAttachment";
            txtBetAttachment.PlaceholderText = "برجاء إدخال المرفق المرهن أو لا يوجد";
            txtBetAttachment.RightToLeft = RightToLeft.Yes;
            txtBetAttachment.Size = new Size(292, 42);
            txtBetAttachment.TabIndex = 11;
            txtBetAttachment.TextAlign = HorizontalAlignment.Center;
            txtBetAttachment.Click += TxtBoxSelectAll_ClickTapIndex;
            txtBetAttachment.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(685, 0);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(136, 48);
            label11.TabIndex = 1;
            label11.Text = "المرفق المرهن";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRentDays
            // 
            txtRentDays.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRentDays.BorderStyle = BorderStyle.None;
            txtRentDays.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtRentDays.HideSelection = false;
            txtRentDays.Location = new Point(3, 3);
            txtRentDays.Multiline = true;
            txtRentDays.Name = "txtRentDays";
            txtRentDays.PlaceholderText = "عدد الأيام";
            txtRentDays.RightToLeft = RightToLeft.Yes;
            txtRentDays.Size = new Size(208, 42);
            txtRentDays.TabIndex = 12;
            txtRentDays.Text = "0";
            txtRentDays.TextAlign = HorizontalAlignment.Center;
            txtRentDays.Click += TxtBoxSelectAll_ClickTapIndex;
            txtRentDays.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtRentDays.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtRentDays.Leave += TxtBoxMinZero_Leave;
            // 
            // tlpPrices
            // 
            tlpPrices.ColumnCount = 4;
            tlpPrices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpPrices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpPrices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpPrices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpPrices.Controls.Add(label14, 0, 1);
            tlpPrices.Controls.Add(label15, 0, 0);
            tlpPrices.Controls.Add(label12, 2, 0);
            tlpPrices.Controls.Add(label13, 2, 1);
            tlpPrices.Controls.Add(lblTotalPrice, 1, 0);
            tlpPrices.Controls.Add(lblRmainAmount, 3, 1);
            tlpPrices.Controls.Add(txtPaidAmount, 1, 1);
            tlpPrices.Controls.Add(txtDiscount, 3, 0);
            tlpPrices.Dock = DockStyle.Fill;
            tlpPrices.Location = new Point(3, 450);
            tlpPrices.Name = "tlpPrices";
            tlpPrices.RowCount = 2;
            tlpPrices.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPrices.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPrices.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPrices.Size = new Size(852, 103);
            tlpPrices.TabIndex = 8;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(685, 51);
            label14.Name = "label14";
            label14.Size = new Size(164, 52);
            label14.TabIndex = 2;
            label14.Text = "المبلغ المدفوع";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(685, 0);
            label15.Name = "label15";
            label15.Size = new Size(164, 51);
            label15.TabIndex = 1;
            label15.Text = "المبلغ الكلي";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(260, 0);
            label12.Name = "label12";
            label12.Size = new Size(164, 51);
            label12.TabIndex = 3;
            label12.Text = "خصم نسبة مئوية";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(260, 51);
            label13.Name = "label13";
            label13.Size = new Size(164, 52);
            label13.TabIndex = 4;
            label13.Text = "المبلغ المتبقي";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPrice.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(430, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.Yes;
            lblTotalPrice.Size = new Size(249, 51);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = "0";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRmainAmount
            // 
            lblRmainAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRmainAmount.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRmainAmount.Location = new Point(3, 51);
            lblRmainAmount.Name = "lblRmainAmount";
            lblRmainAmount.RightToLeft = RightToLeft.Yes;
            lblRmainAmount.Size = new Size(251, 52);
            lblRmainAmount.TabIndex = 6;
            lblRmainAmount.Text = "0";
            lblRmainAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPaidAmount.BorderStyle = BorderStyle.None;
            txtPaidAmount.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtPaidAmount.HideSelection = false;
            txtPaidAmount.Location = new Point(430, 54);
            txtPaidAmount.Multiline = true;
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.PlaceholderText = "من 0 إلي 100";
            txtPaidAmount.RightToLeft = RightToLeft.Yes;
            txtPaidAmount.Size = new Size(249, 45);
            txtPaidAmount.TabIndex = 14;
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
            txtDiscount.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiscount.HideSelection = false;
            txtDiscount.Location = new Point(3, 3);
            txtDiscount.Multiline = true;
            txtDiscount.Name = "txtDiscount";
            txtDiscount.RightToLeft = RightToLeft.Yes;
            txtDiscount.Size = new Size(247, 45);
            txtDiscount.TabIndex = 13;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Center;
            txtDiscount.Click += TxtBoxSelectAll_ClickTapIndex;
            txtDiscount.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            txtDiscount.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtDiscount.Leave += TxtBoxMinZero_Leave;
            // 
            // tlpNotes
            // 
            tlpNotes.ColumnCount = 2;
            tlpNotes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpNotes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpNotes.Controls.Add(txtNotes, 0, 0);
            tlpNotes.Controls.Add(label17, 0, 0);
            tlpNotes.Dock = DockStyle.Fill;
            tlpNotes.Location = new Point(3, 559);
            tlpNotes.Name = "tlpNotes";
            tlpNotes.RowCount = 1;
            tlpNotes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpNotes.Size = new Size(852, 48);
            tlpNotes.TabIndex = 9;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtNotes.HideSelection = false;
            txtNotes.Location = new Point(3, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.Size = new Size(676, 42);
            txtNotes.TabIndex = 15;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            txtNotes.Click += TxtBoxSelectAll_ClickTapIndex;
            txtNotes.TabIndexChanged += TxtBoxSelectAll_ClickTapIndex;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(685, 0);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.Yes;
            label17.Size = new Size(164, 48);
            label17.TabIndex = 1;
            label17.Text = "ملاحظات";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 5;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpButtons.Controls.Add(btnAddOrder, 1, 0);
            tlpButtons.Controls.Add(btnCancel, 3, 0);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.Location = new Point(3, 613);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(852, 48);
            tlpButtons.TabIndex = 10;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddOrder.ForeColor = Color.Green;
            btnAddOrder.Location = new Point(472, 3);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(292, 42);
            btnAddOrder.TabIndex = 16;
            btnAddOrder.Text = "تأكيد ";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(89, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(207, 42);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MakeOrder
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(tlpContainer);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 7, 5, 7);
            Name = "MakeOrder";
            Size = new Size(858, 679);
            Load += UCMakeOrder_Load;
            tlpContainer.ResumeLayout(false);
            tlpHead.ResumeLayout(false);
            tlpHead.PerformLayout();
            tlpSelectSuits.ResumeLayout(false);
            tlpAttachmentsSizesAndDate.ResumeLayout(false);
            tlpCustomerInfoTitle.ResumeLayout(false);
            tlpCustomerInfo1.ResumeLayout(false);
            tlpCustomerInfo1.PerformLayout();
            tlpCustomerInfo2.ResumeLayout(false);
            tlpCustomerInfo2.PerformLayout();
            tlpOrderType.ResumeLayout(false);
            tlpRentalType.ResumeLayout(false);
            tlpRentalType.PerformLayout();
            tlpPrices.ResumeLayout(false);
            tlpPrices.PerformLayout();
            tlpNotes.ResumeLayout(false);
            tlpNotes.PerformLayout();
            tlpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpContainer;
        private TableLayoutPanel tlpHead;
        private Label label1;
        private TableLayoutPanel tlpAttachmentsSizesAndDate;
        private Label label16;
        private Label label18;
        private ComboBox comboAttachmentAndSizes;
        private DateTimePicker dateTimeOrderDate;
        private Label label4;
        private Label lblSelectedSuitsCount;
        private TableLayoutPanel tlpCustomerInfoTitle;
        private Label label5;
        private TableLayoutPanel tlpCustomerInfo1;
        private Label label6;
        private ComboBox comboCustomterName;
        private TextBox txtCustomerName;
        private TableLayoutPanel tlpCustomerInfo2;
        private Label label8;
        private TextBox txtCustomerAddress;
        private Label label7;
        private TextBox txtCustomerPhone;
        private TableLayoutPanel tlpOrderType;
        private Label label9;
        private ComboBox comboOrderType;
        private TableLayoutPanel tlpRentalType;
        private Label label11;
        private TextBox txtBetAttachment;
        private Label label10;
        private TextBox txtRentDays;
        private TableLayoutPanel tlpPrices;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label13;
        private Label lblTotalPrice;
        private Label lblRmainAmount;
        private TextBox txtDiscount;
        private TextBox txtPaidAmount;
        private TableLayoutPanel tlpNotes;
        private Label label17;
        private TextBox txtNotes;
        private TableLayoutPanel tlpButtons;
        private Button btnAddOrder;
        private Button btnCancel;
        private TableLayoutPanel tlpSelectSuits;
        private ComboBox comboAllAvailableSuits;
        private Label label2;
        private ComboBox comboSelectedSuits;
        private Button btnDeleteSuit;
        private Label label3;
        private Label label19;
        private ComboBox cmbAvailableSuitSizes;
    }
}
