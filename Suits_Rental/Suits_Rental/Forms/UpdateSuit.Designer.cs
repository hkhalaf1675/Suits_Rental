namespace Suits_Rental.Forms
{
    partial class UpdateSuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSuit));
            btnDeleteAttachment = new Button();
            comboSuitAttachments = new ComboBox();
            txtNotes = new TextBox();
            txtAttachmentName = new TextBox();
            btnUpdateSuit = new Button();
            btnSaveSuitAttachment = new Button();
            lblTitle = new Label();
            btnClose = new PictureBox();
            panelLayout = new Panel();
            txtSuitSalePrice = new TextBox();
            txtSuitRentalPrice = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblNotes = new Label();
            lblAttachmentName = new Label();
            label2 = new Label();
            txtAttachmentSizeNum4 = new TextBox();
            txtAttachmentSizeNum8 = new TextBox();
            txtAttachmentSizeNum3 = new TextBox();
            txtAttachmentSizeNum7 = new TextBox();
            txtAttachmentSizeNum2 = new TextBox();
            txtAttachmentSizeNum1 = new TextBox();
            txtAttachmentSizeNum6 = new TextBox();
            txtAttachmentSizeNum5 = new TextBox();
            lblAttachmentSize = new Label();
            comboSuitSizes = new ComboBox();
            btnDeleteSuitSize = new Button();
            txtAddSuitSize = new TextBox();
            label1 = new Label();
            btnAddSuitSize = new Button();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelLayout.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteAttachment
            // 
            btnDeleteAttachment.FlatStyle = FlatStyle.Flat;
            btnDeleteAttachment.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteAttachment.ForeColor = Color.FromArgb(192, 0, 0);
            btnDeleteAttachment.Location = new Point(12, 272);
            btnDeleteAttachment.Name = "btnDeleteAttachment";
            btnDeleteAttachment.Size = new Size(163, 35);
            btnDeleteAttachment.TabIndex = 9;
            btnDeleteAttachment.Text = "حذف المرفق";
            btnDeleteAttachment.UseVisualStyleBackColor = true;
            btnDeleteAttachment.Click += btnDeleteAttachment_Click;
            // 
            // comboSuitAttachments
            // 
            comboSuitAttachments.BackColor = Color.FromArgb(224, 224, 224);
            comboSuitAttachments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuitAttachments.FlatStyle = FlatStyle.Flat;
            comboSuitAttachments.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboSuitAttachments.FormattingEnabled = true;
            comboSuitAttachments.Location = new Point(213, 272);
            comboSuitAttachments.Name = "comboSuitAttachments";
            comboSuitAttachments.RightToLeft = RightToLeft.Yes;
            comboSuitAttachments.Size = new Size(248, 35);
            comboSuitAttachments.TabIndex = 8;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(224, 224, 224);
            txtNotes.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtNotes.Location = new Point(50, 443);
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.Size = new Size(313, 35);
            txtNotes.TabIndex = 19;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            txtNotes.Click += TxtBoxSelectAll_TabIndex_Click;
            txtNotes.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtAttachmentName
            // 
            txtAttachmentName.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentName.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentName.Location = new Point(51, 320);
            txtAttachmentName.Name = "txtAttachmentName";
            txtAttachmentName.RightToLeft = RightToLeft.Yes;
            txtAttachmentName.Size = new Size(313, 35);
            txtAttachmentName.TabIndex = 10;
            txtAttachmentName.TextAlign = HorizontalAlignment.Center;
            txtAttachmentName.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentName.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // btnUpdateSuit
            // 
            btnUpdateSuit.FlatStyle = FlatStyle.Flat;
            btnUpdateSuit.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateSuit.ForeColor = Color.Blue;
            btnUpdateSuit.Location = new Point(82, 214);
            btnUpdateSuit.Name = "btnUpdateSuit";
            btnUpdateSuit.Size = new Size(354, 52);
            btnUpdateSuit.TabIndex = 7;
            btnUpdateSuit.Text = "حفظ ";
            btnUpdateSuit.UseVisualStyleBackColor = true;
            btnUpdateSuit.Click += btnUpdateSuit_Click;
            // 
            // btnSaveSuitAttachment
            // 
            btnSaveSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnSaveSuitAttachment.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveSuitAttachment.ForeColor = Color.Green;
            btnSaveSuitAttachment.Location = new Point(139, 490);
            btnSaveSuitAttachment.Name = "btnSaveSuitAttachment";
            btnSaveSuitAttachment.Size = new Size(246, 52);
            btnSaveSuitAttachment.TabIndex = 20;
            btnSaveSuitAttachment.Text = "حفظ المرفق";
            btnSaveSuitAttachment.UseVisualStyleBackColor = true;
            btnSaveSuitAttachment.Click += btnSaveSuitAttachment_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(350, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(75, 27);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "تعديل بدلة";
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
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelLayout
            // 
            panelLayout.BackColor = Color.FromArgb(73, 78, 82);
            panelLayout.Controls.Add(lblTitle);
            panelLayout.Controls.Add(btnClose);
            panelLayout.Dock = DockStyle.Top;
            panelLayout.Location = new Point(0, 0);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(561, 50);
            panelLayout.TabIndex = 22;
            panelLayout.MouseDown += panelLayout_MouseDown;
            // 
            // txtSuitSalePrice
            // 
            txtSuitSalePrice.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitSalePrice.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtSuitSalePrice.Location = new Point(50, 173);
            txtSuitSalePrice.Name = "txtSuitSalePrice";
            txtSuitSalePrice.RightToLeft = RightToLeft.Yes;
            txtSuitSalePrice.Size = new Size(313, 35);
            txtSuitSalePrice.TabIndex = 6;
            txtSuitSalePrice.Text = "0";
            txtSuitSalePrice.TextAlign = HorizontalAlignment.Center;
            txtSuitSalePrice.Click += TxtBoxSelectAll_TabIndex_Click;
            txtSuitSalePrice.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtSuitSalePrice.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitSalePrice.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitRentalPrice
            // 
            txtSuitRentalPrice.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitRentalPrice.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtSuitRentalPrice.Location = new Point(50, 132);
            txtSuitRentalPrice.Name = "txtSuitRentalPrice";
            txtSuitRentalPrice.RightToLeft = RightToLeft.Yes;
            txtSuitRentalPrice.Size = new Size(313, 35);
            txtSuitRentalPrice.TabIndex = 5;
            txtSuitRentalPrice.Text = "0";
            txtSuitRentalPrice.TextAlign = HorizontalAlignment.Center;
            txtSuitRentalPrice.Click += TxtBoxSelectAll_TabIndex_Click;
            txtSuitRentalPrice.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtSuitRentalPrice.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitRentalPrice.Leave += TxtBoxMinZero_Leave;
            // 
            // label7
            // 
            label7.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(463, 273);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(82, 34);
            label7.TabIndex = 0;
            label7.Text = "المرفقات";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(369, 132);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(175, 35);
            label4.TabIndex = 0;
            label4.Text = "سعر البدلة للإيجار";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(370, 173);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(174, 35);
            label3.TabIndex = 0;
            label3.Text = "سعر البدلة للبيع";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotes.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(369, 443);
            lblNotes.Name = "lblNotes";
            lblNotes.RightToLeft = RightToLeft.Yes;
            lblNotes.Size = new Size(174, 35);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "ملاحظات";
            lblNotes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAttachmentName
            // 
            lblAttachmentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentName.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentName.Location = new Point(371, 320);
            lblAttachmentName.Name = "lblAttachmentName";
            lblAttachmentName.RightToLeft = RightToLeft.Yes;
            lblAttachmentName.Size = new Size(174, 35);
            lblAttachmentName.TabIndex = 0;
            lblAttachmentName.Text = "اسم المرفق";
            lblAttachmentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(398, 56);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(146, 35);
            label2.TabIndex = 0;
            label2.Text = "مقاسات البدلة";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAttachmentSizeNum4
            // 
            txtAttachmentSizeNum4.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum4.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentSizeNum4.Location = new Point(50, 361);
            txtAttachmentSizeNum4.Name = "txtAttachmentSizeNum4";
            txtAttachmentSizeNum4.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum4.Size = new Size(74, 35);
            txtAttachmentSizeNum4.TabIndex = 14;
            txtAttachmentSizeNum4.Text = "0";
            txtAttachmentSizeNum4.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum4.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum4.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum4.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSizeNum4.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSizeNum8
            // 
            txtAttachmentSizeNum8.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum8.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentSizeNum8.Location = new Point(50, 402);
            txtAttachmentSizeNum8.Name = "txtAttachmentSizeNum8";
            txtAttachmentSizeNum8.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum8.Size = new Size(74, 35);
            txtAttachmentSizeNum8.TabIndex = 18;
            txtAttachmentSizeNum8.Text = "0";
            txtAttachmentSizeNum8.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum8.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum8.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum8.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSizeNum8.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSizeNum3
            // 
            txtAttachmentSizeNum3.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum3.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentSizeNum3.Location = new Point(130, 361);
            txtAttachmentSizeNum3.Name = "txtAttachmentSizeNum3";
            txtAttachmentSizeNum3.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum3.Size = new Size(74, 35);
            txtAttachmentSizeNum3.TabIndex = 13;
            txtAttachmentSizeNum3.Text = "0";
            txtAttachmentSizeNum3.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum3.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum3.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum3.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSizeNum3.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSizeNum7
            // 
            txtAttachmentSizeNum7.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum7.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentSizeNum7.Location = new Point(130, 402);
            txtAttachmentSizeNum7.Name = "txtAttachmentSizeNum7";
            txtAttachmentSizeNum7.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum7.Size = new Size(74, 35);
            txtAttachmentSizeNum7.TabIndex = 17;
            txtAttachmentSizeNum7.Text = "0";
            txtAttachmentSizeNum7.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum7.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum7.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum7.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSizeNum7.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSizeNum2
            // 
            txtAttachmentSizeNum2.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum2.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentSizeNum2.Location = new Point(210, 361);
            txtAttachmentSizeNum2.Name = "txtAttachmentSizeNum2";
            txtAttachmentSizeNum2.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum2.Size = new Size(74, 35);
            txtAttachmentSizeNum2.TabIndex = 12;
            txtAttachmentSizeNum2.Text = "0";
            txtAttachmentSizeNum2.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum2.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum2.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum2.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSizeNum2.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSizeNum1
            // 
            txtAttachmentSizeNum1.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum1.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentSizeNum1.Location = new Point(290, 361);
            txtAttachmentSizeNum1.Name = "txtAttachmentSizeNum1";
            txtAttachmentSizeNum1.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum1.Size = new Size(74, 35);
            txtAttachmentSizeNum1.TabIndex = 11;
            txtAttachmentSizeNum1.Text = "0";
            txtAttachmentSizeNum1.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum1.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum1.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum1.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSizeNum1.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSizeNum6
            // 
            txtAttachmentSizeNum6.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum6.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentSizeNum6.Location = new Point(210, 402);
            txtAttachmentSizeNum6.Name = "txtAttachmentSizeNum6";
            txtAttachmentSizeNum6.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum6.Size = new Size(74, 35);
            txtAttachmentSizeNum6.TabIndex = 16;
            txtAttachmentSizeNum6.Text = "0";
            txtAttachmentSizeNum6.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum6.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum6.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum6.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSizeNum6.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSizeNum5
            // 
            txtAttachmentSizeNum5.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum5.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttachmentSizeNum5.Location = new Point(290, 402);
            txtAttachmentSizeNum5.Name = "txtAttachmentSizeNum5";
            txtAttachmentSizeNum5.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum5.Size = new Size(74, 35);
            txtAttachmentSizeNum5.TabIndex = 15;
            txtAttachmentSizeNum5.Text = "0";
            txtAttachmentSizeNum5.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum5.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum5.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum5.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSizeNum5.Leave += TxtBoxMinZero_Leave;
            // 
            // lblAttachmentSize
            // 
            lblAttachmentSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentSize.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentSize.Location = new Point(370, 381);
            lblAttachmentSize.Name = "lblAttachmentSize";
            lblAttachmentSize.RightToLeft = RightToLeft.Yes;
            lblAttachmentSize.Size = new Size(171, 37);
            lblAttachmentSize.TabIndex = 0;
            lblAttachmentSize.Text = "مقاسات المرفق";
            lblAttachmentSize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboSuitSizes
            // 
            comboSuitSizes.BackColor = Color.FromArgb(224, 224, 224);
            comboSuitSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuitSizes.FlatStyle = FlatStyle.Flat;
            comboSuitSizes.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboSuitSizes.FormattingEnabled = true;
            comboSuitSizes.Location = new Point(161, 56);
            comboSuitSizes.Name = "comboSuitSizes";
            comboSuitSizes.RightToLeft = RightToLeft.Yes;
            comboSuitSizes.Size = new Size(224, 35);
            comboSuitSizes.TabIndex = 1;
            // 
            // btnDeleteSuitSize
            // 
            btnDeleteSuitSize.FlatStyle = FlatStyle.Flat;
            btnDeleteSuitSize.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteSuitSize.ForeColor = Color.FromArgb(192, 0, 0);
            btnDeleteSuitSize.Location = new Point(12, 56);
            btnDeleteSuitSize.Name = "btnDeleteSuitSize";
            btnDeleteSuitSize.Size = new Size(143, 35);
            btnDeleteSuitSize.TabIndex = 2;
            btnDeleteSuitSize.Text = "حذف المقاس";
            btnDeleteSuitSize.UseVisualStyleBackColor = true;
            btnDeleteSuitSize.Click += btnDeleteSuitSize_Click;
            // 
            // txtAddSuitSize
            // 
            txtAddSuitSize.BackColor = Color.FromArgb(224, 224, 224);
            txtAddSuitSize.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddSuitSize.Location = new Point(189, 94);
            txtAddSuitSize.Name = "txtAddSuitSize";
            txtAddSuitSize.RightToLeft = RightToLeft.Yes;
            txtAddSuitSize.Size = new Size(196, 35);
            txtAddSuitSize.TabIndex = 3;
            txtAddSuitSize.Text = "0";
            txtAddSuitSize.TextAlign = HorizontalAlignment.Center;
            txtAddSuitSize.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAddSuitSize.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtAddSuitSize.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAddSuitSize.Leave += TxtBoxMinZero_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(395, 94);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(146, 35);
            label1.TabIndex = 0;
            label1.Text = "إضافة مقاس للبدلة";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddSuitSize
            // 
            btnAddSuitSize.FlatStyle = FlatStyle.Flat;
            btnAddSuitSize.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSuitSize.ForeColor = Color.Green;
            btnAddSuitSize.Location = new Point(12, 94);
            btnAddSuitSize.Name = "btnAddSuitSize";
            btnAddSuitSize.Size = new Size(171, 35);
            btnAddSuitSize.TabIndex = 4;
            btnAddSuitSize.Text = "حفظ المقاس";
            btnAddSuitSize.UseVisualStyleBackColor = true;
            btnAddSuitSize.Click += btnAddSuitSize_Click;
            // 
            // UpdateSuit
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(561, 549);
            Controls.Add(txtAttachmentSizeNum4);
            Controls.Add(txtAttachmentSizeNum8);
            Controls.Add(txtAttachmentSizeNum3);
            Controls.Add(txtAttachmentSizeNum7);
            Controls.Add(txtAttachmentSizeNum2);
            Controls.Add(txtAddSuitSize);
            Controls.Add(txtAttachmentSizeNum1);
            Controls.Add(txtAttachmentSizeNum6);
            Controls.Add(txtAttachmentSizeNum5);
            Controls.Add(lblAttachmentSize);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNotes);
            Controls.Add(lblAttachmentName);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtSuitSalePrice);
            Controls.Add(txtSuitRentalPrice);
            Controls.Add(btnDeleteSuitSize);
            Controls.Add(btnDeleteAttachment);
            Controls.Add(comboSuitSizes);
            Controls.Add(comboSuitAttachments);
            Controls.Add(txtNotes);
            Controls.Add(txtAttachmentName);
            Controls.Add(btnUpdateSuit);
            Controls.Add(btnAddSuitSize);
            Controls.Add(btnSaveSuitAttachment);
            Controls.Add(panelLayout);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(300, 100);
            Margin = new Padding(5);
            Name = "UpdateSuit";
            StartPosition = FormStartPosition.Manual;
            Text = "UpdateSuit";
            Load += UpdateSuit_Load;
            KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            Leave += TxtBoxMinZero_Leave;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelLayout.ResumeLayout(false);
            panelLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteAttachment;
        private ComboBox comboSuitAttachments;
        private TextBox txtNotes;
        private TextBox txtAttachmentName;
        private Button btnUpdateSuit;
        private Button btnSaveSuitAttachment;
        private Label lblTitle;
        private PictureBox btnClose;
        private Panel panelLayout;
        private TextBox txtSuitSalePrice;
        private TextBox txtSuitRentalPrice;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label lblNotes;
        private Label lblAttachmentName;
        private Label label2;
        private TextBox txtAttachmentSizeNum4;
        private TextBox txtAttachmentSizeNum8;
        private TextBox txtAttachmentSizeNum3;
        private TextBox txtAttachmentSizeNum7;
        private TextBox txtAttachmentSizeNum2;
        private TextBox txtAttachmentSizeNum1;
        private TextBox txtAttachmentSizeNum6;
        private TextBox txtAttachmentSizeNum5;
        private Label lblAttachmentSize;
        private ComboBox comboSuitSizes;
        private Button btnDeleteSuitSize;
        private TextBox txtAddSuitSize;
        private Label label1;
        private Button btnAddSuitSize;
    }
}