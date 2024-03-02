namespace Suits_Rental.Forms
{
    partial class ManageSuitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSuitForm));
            panelLayout = new Panel();
            label1 = new Label();
            btnClose = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddSuitAttachment = new Button();
            lblAttachmentName = new Label();
            lblAttachmentSize = new Label();
            lblNotes = new Label();
            txtAttachmentName = new TextBox();
            txtNotes = new TextBox();
            btnSaveSuitAttachment = new Button();
            btnSaveSuit = new Button();
            comboSuitAttachments = new ComboBox();
            label7 = new Label();
            btnDeleteAttachment = new Button();
            label5 = new Label();
            txtSuitId = new TextBox();
            txtSuitSize = new TextBox();
            txtSuitRentalPrice = new TextBox();
            txtSuitSalePrice = new TextBox();
            txtAttachmentSizeNum5 = new TextBox();
            txtAttachmentSizeNum6 = new TextBox();
            txtAttachmentSizeNum7 = new TextBox();
            txtAttachmentSizeNum8 = new TextBox();
            txtAttachmentSizeNum1 = new TextBox();
            txtAttachmentSizeNum2 = new TextBox();
            txtAttachmentSizeNum3 = new TextBox();
            txtAttachmentSizeNum4 = new TextBox();
            panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panelLayout
            // 
            panelLayout.BackColor = Color.FromArgb(73, 78, 82);
            panelLayout.Controls.Add(label1);
            panelLayout.Controls.Add(btnClose);
            panelLayout.Dock = DockStyle.Top;
            panelLayout.Location = new Point(0, 0);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(560, 50);
            panelLayout.TabIndex = 0;
            panelLayout.MouseDown += panelLayout_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(376, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 42);
            label1.TabIndex = 3;
            label1.Text = "إضافة بدلة";
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(372, 100);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(174, 42);
            label2.TabIndex = 1;
            label2.Text = "مقاس البدلة";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(372, 191);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(174, 42);
            label3.TabIndex = 3;
            label3.Text = "سعر البدلة للبيع";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(371, 147);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(175, 42);
            label4.TabIndex = 5;
            label4.Text = "سعر البدلة للإيجار";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddSuitAttachment
            // 
            btnAddSuitAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddSuitAttachment.BackColor = Color.FromArgb(224, 224, 224);
            btnAddSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnAddSuitAttachment.ForeColor = Color.FromArgb(0, 192, 192);
            btnAddSuitAttachment.Location = new Point(313, 238);
            btnAddSuitAttachment.Name = "btnAddSuitAttachment";
            btnAddSuitAttachment.Size = new Size(230, 52);
            btnAddSuitAttachment.TabIndex = 5;
            btnAddSuitAttachment.Text = "إضافة مرفق للبدلة";
            btnAddSuitAttachment.UseVisualStyleBackColor = false;
            btnAddSuitAttachment.Click += btnAddSuitAttachment_Click;
            // 
            // lblAttachmentName
            // 
            lblAttachmentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentName.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentName.Location = new Point(376, 341);
            lblAttachmentName.Name = "lblAttachmentName";
            lblAttachmentName.RightToLeft = RightToLeft.Yes;
            lblAttachmentName.Size = new Size(174, 42);
            lblAttachmentName.TabIndex = 1;
            lblAttachmentName.Text = "اسم المرفق";
            lblAttachmentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAttachmentSize
            // 
            lblAttachmentSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentSize.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentSize.Location = new Point(379, 414);
            lblAttachmentSize.Name = "lblAttachmentSize";
            lblAttachmentSize.RightToLeft = RightToLeft.Yes;
            lblAttachmentSize.Size = new Size(171, 42);
            lblAttachmentSize.TabIndex = 1;
            lblAttachmentSize.Text = "مقاسات المرفق";
            lblAttachmentSize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotes.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(379, 484);
            lblNotes.Name = "lblNotes";
            lblNotes.RightToLeft = RightToLeft.Yes;
            lblNotes.Size = new Size(174, 42);
            lblNotes.TabIndex = 1;
            lblNotes.Text = "ملاحظات";
            lblNotes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAttachmentName
            // 
            txtAttachmentName.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentName.Location = new Point(56, 343);
            txtAttachmentName.Name = "txtAttachmentName";
            txtAttachmentName.RightToLeft = RightToLeft.Yes;
            txtAttachmentName.Size = new Size(318, 41);
            txtAttachmentName.TabIndex = 9;
            txtAttachmentName.TextAlign = HorizontalAlignment.Center;
            txtAttachmentName.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentName.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(224, 224, 224);
            txtNotes.Location = new Point(59, 486);
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.Size = new Size(315, 41);
            txtNotes.TabIndex = 18;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            txtNotes.Click += TxtBoxSelectAll_TabIndex_Click;
            txtNotes.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // btnSaveSuitAttachment
            // 
            btnSaveSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnSaveSuitAttachment.ForeColor = Color.Green;
            btnSaveSuitAttachment.Location = new Point(151, 533);
            btnSaveSuitAttachment.Name = "btnSaveSuitAttachment";
            btnSaveSuitAttachment.Size = new Size(246, 52);
            btnSaveSuitAttachment.TabIndex = 19;
            btnSaveSuitAttachment.Text = "حفظ المرفق";
            btnSaveSuitAttachment.UseVisualStyleBackColor = true;
            btnSaveSuitAttachment.Click += btnSaveSuitAttachment_Click;
            // 
            // btnSaveSuit
            // 
            btnSaveSuit.FlatStyle = FlatStyle.Flat;
            btnSaveSuit.ForeColor = Color.Green;
            btnSaveSuit.Location = new Point(12, 238);
            btnSaveSuit.Name = "btnSaveSuit";
            btnSaveSuit.Size = new Size(238, 52);
            btnSaveSuit.TabIndex = 6;
            btnSaveSuit.Text = "حفظ ";
            btnSaveSuit.UseVisualStyleBackColor = true;
            btnSaveSuit.Click += btnSaveSuit_Click;
            // 
            // comboSuitAttachments
            // 
            comboSuitAttachments.BackColor = Color.FromArgb(224, 224, 224);
            comboSuitAttachments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuitAttachments.FlatStyle = FlatStyle.Flat;
            comboSuitAttachments.FormattingEnabled = true;
            comboSuitAttachments.Location = new Point(220, 296);
            comboSuitAttachments.Name = "comboSuitAttachments";
            comboSuitAttachments.RightToLeft = RightToLeft.Yes;
            comboSuitAttachments.Size = new Size(248, 42);
            comboSuitAttachments.TabIndex = 7;
            // 
            // label7
            // 
            label7.Font = new Font("Arabic Typesetting", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(474, 296);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(82, 40);
            label7.TabIndex = 12;
            label7.Text = "المرفقات";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDeleteAttachment
            // 
            btnDeleteAttachment.FlatStyle = FlatStyle.Flat;
            btnDeleteAttachment.ForeColor = Color.FromArgb(192, 0, 0);
            btnDeleteAttachment.Location = new Point(18, 296);
            btnDeleteAttachment.Name = "btnDeleteAttachment";
            btnDeleteAttachment.Size = new Size(163, 42);
            btnDeleteAttachment.TabIndex = 8;
            btnDeleteAttachment.Text = "حذف المرفق";
            btnDeleteAttachment.UseVisualStyleBackColor = true;
            btnDeleteAttachment.Click += btnDeleteAttachment_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(372, 51);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(174, 42);
            label5.TabIndex = 1;
            label5.Text = "رقم البدلة";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSuitId
            // 
            txtSuitId.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitId.Location = new Point(60, 51);
            txtSuitId.Name = "txtSuitId";
            txtSuitId.RightToLeft = RightToLeft.Yes;
            txtSuitId.Size = new Size(306, 41);
            txtSuitId.TabIndex = 1;
            txtSuitId.Text = "0";
            txtSuitId.TextAlign = HorizontalAlignment.Center;
            txtSuitId.Click += TxtBoxSelectAll_TabIndex_Click;
            txtSuitId.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtSuitId.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitId.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitSize
            // 
            txtSuitSize.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitSize.Location = new Point(60, 98);
            txtSuitSize.Name = "txtSuitSize";
            txtSuitSize.RightToLeft = RightToLeft.Yes;
            txtSuitSize.Size = new Size(306, 41);
            txtSuitSize.TabIndex = 2;
            txtSuitSize.Text = "0";
            txtSuitSize.TextAlign = HorizontalAlignment.Center;
            txtSuitSize.Click += TxtBoxSelectAll_TabIndex_Click;
            txtSuitSize.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtSuitSize.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitSize.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitRentalPrice
            // 
            txtSuitRentalPrice.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitRentalPrice.Location = new Point(60, 145);
            txtSuitRentalPrice.Name = "txtSuitRentalPrice";
            txtSuitRentalPrice.RightToLeft = RightToLeft.Yes;
            txtSuitRentalPrice.Size = new Size(306, 41);
            txtSuitRentalPrice.TabIndex = 3;
            txtSuitRentalPrice.Text = "0";
            txtSuitRentalPrice.TextAlign = HorizontalAlignment.Center;
            txtSuitRentalPrice.Click += TxtBoxSelectAll_TabIndex_Click;
            txtSuitRentalPrice.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtSuitRentalPrice.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitRentalPrice.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitSalePrice
            // 
            txtSuitSalePrice.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitSalePrice.Location = new Point(60, 191);
            txtSuitSalePrice.Name = "txtSuitSalePrice";
            txtSuitSalePrice.RightToLeft = RightToLeft.Yes;
            txtSuitSalePrice.Size = new Size(306, 41);
            txtSuitSalePrice.TabIndex = 4;
            txtSuitSalePrice.Text = "0";
            txtSuitSalePrice.TextAlign = HorizontalAlignment.Center;
            txtSuitSalePrice.Click += TxtBoxSelectAll_TabIndex_Click;
            txtSuitSalePrice.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            txtSuitSalePrice.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitSalePrice.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSizeNum5
            // 
            txtAttachmentSizeNum5.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum5.Location = new Point(300, 439);
            txtAttachmentSizeNum5.Name = "txtAttachmentSizeNum5";
            txtAttachmentSizeNum5.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum5.Size = new Size(74, 41);
            txtAttachmentSizeNum5.TabIndex = 14;
            txtAttachmentSizeNum5.Text = "0";
            txtAttachmentSizeNum5.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum5.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum5.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtAttachmentSizeNum6
            // 
            txtAttachmentSizeNum6.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum6.Location = new Point(220, 439);
            txtAttachmentSizeNum6.Name = "txtAttachmentSizeNum6";
            txtAttachmentSizeNum6.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum6.Size = new Size(74, 41);
            txtAttachmentSizeNum6.TabIndex = 15;
            txtAttachmentSizeNum6.Text = "0";
            txtAttachmentSizeNum6.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum6.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum6.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtAttachmentSizeNum7
            // 
            txtAttachmentSizeNum7.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum7.Location = new Point(140, 439);
            txtAttachmentSizeNum7.Name = "txtAttachmentSizeNum7";
            txtAttachmentSizeNum7.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum7.Size = new Size(74, 41);
            txtAttachmentSizeNum7.TabIndex = 16;
            txtAttachmentSizeNum7.Text = "0";
            txtAttachmentSizeNum7.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum7.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum7.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtAttachmentSizeNum8
            // 
            txtAttachmentSizeNum8.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum8.Location = new Point(60, 439);
            txtAttachmentSizeNum8.Name = "txtAttachmentSizeNum8";
            txtAttachmentSizeNum8.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum8.Size = new Size(74, 41);
            txtAttachmentSizeNum8.TabIndex = 17;
            txtAttachmentSizeNum8.Text = "0";
            txtAttachmentSizeNum8.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum8.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum8.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtAttachmentSizeNum1
            // 
            txtAttachmentSizeNum1.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum1.Location = new Point(300, 390);
            txtAttachmentSizeNum1.Name = "txtAttachmentSizeNum1";
            txtAttachmentSizeNum1.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum1.Size = new Size(74, 41);
            txtAttachmentSizeNum1.TabIndex = 10;
            txtAttachmentSizeNum1.Text = "0";
            txtAttachmentSizeNum1.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum1.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum1.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtAttachmentSizeNum2
            // 
            txtAttachmentSizeNum2.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum2.Location = new Point(220, 390);
            txtAttachmentSizeNum2.Name = "txtAttachmentSizeNum2";
            txtAttachmentSizeNum2.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum2.Size = new Size(74, 41);
            txtAttachmentSizeNum2.TabIndex = 11;
            txtAttachmentSizeNum2.Text = "0";
            txtAttachmentSizeNum2.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum2.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum2.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtAttachmentSizeNum3
            // 
            txtAttachmentSizeNum3.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum3.Location = new Point(140, 390);
            txtAttachmentSizeNum3.Name = "txtAttachmentSizeNum3";
            txtAttachmentSizeNum3.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum3.Size = new Size(74, 41);
            txtAttachmentSizeNum3.TabIndex = 12;
            txtAttachmentSizeNum3.Text = "0";
            txtAttachmentSizeNum3.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum3.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum3.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // txtAttachmentSizeNum4
            // 
            txtAttachmentSizeNum4.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSizeNum4.Location = new Point(60, 390);
            txtAttachmentSizeNum4.Name = "txtAttachmentSizeNum4";
            txtAttachmentSizeNum4.RightToLeft = RightToLeft.Yes;
            txtAttachmentSizeNum4.Size = new Size(74, 41);
            txtAttachmentSizeNum4.TabIndex = 13;
            txtAttachmentSizeNum4.Text = "0";
            txtAttachmentSizeNum4.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSizeNum4.Click += TxtBoxSelectAll_TabIndex_Click;
            txtAttachmentSizeNum4.TabIndexChanged += TxtBoxSelectAll_TabIndex_Click;
            // 
            // ManageSuitForm
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(560, 340);
            Controls.Add(txtAttachmentSizeNum4);
            Controls.Add(txtAttachmentSizeNum8);
            Controls.Add(txtAttachmentSizeNum3);
            Controls.Add(txtAttachmentSizeNum7);
            Controls.Add(txtAttachmentSizeNum2);
            Controls.Add(txtAttachmentSizeNum1);
            Controls.Add(txtAttachmentSizeNum6);
            Controls.Add(txtAttachmentSizeNum5);
            Controls.Add(btnDeleteAttachment);
            Controls.Add(label7);
            Controls.Add(comboSuitAttachments);
            Controls.Add(txtNotes);
            Controls.Add(txtSuitSalePrice);
            Controls.Add(txtSuitRentalPrice);
            Controls.Add(txtSuitSize);
            Controls.Add(txtSuitId);
            Controls.Add(txtAttachmentName);
            Controls.Add(btnSaveSuit);
            Controls.Add(btnSaveSuitAttachment);
            Controls.Add(btnAddSuitAttachment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNotes);
            Controls.Add(lblAttachmentSize);
            Controls.Add(lblAttachmentName);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(panelLayout);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(300, 100);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ManageSuitForm";
            StartPosition = FormStartPosition.Manual;
            Text = "ManageSuitForm";
            panelLayout.ResumeLayout(false);
            panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLayout;
        private Label label1;
        private PictureBox btnClose;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddSuitAttachment;
        private Label lblAttachmentName;
        private Label lblAttachmentSize;
        private Label lblNotes;
        private TextBox txtAttachmentName;
        private TextBox txtNotes;
        private Button btnSaveSuitAttachment;
        private Button btnSaveSuit;
        private ComboBox comboSuitAttachments;
        private Label label7;
        private Button btnDeleteAttachment;
        private Label label5;
        private TextBox txtSuitId;
        private TextBox txtSuitSize;
        private TextBox txtSuitRentalPrice;
        private TextBox txtSuitSalePrice;
        private TextBox txtAttachmentSizeNum5;
        private TextBox txtAttachmentSizeNum6;
        private TextBox txtAttachmentSizeNum7;
        private TextBox txtAttachmentSizeNum8;
        private TextBox txtAttachmentSizeNum1;
        private TextBox txtAttachmentSizeNum2;
        private TextBox txtAttachmentSizeNum3;
        private TextBox txtAttachmentSizeNum4;
    }
}