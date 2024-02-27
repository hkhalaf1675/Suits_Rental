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
            btnAddSuitAttachment = new Button();
            lblTitle = new Label();
            btnClose = new PictureBox();
            panelLayout = new Panel();
            txtSuitSalePrice = new TextBox();
            txtSuitRentalPrice = new TextBox();
            txtSuitSize = new TextBox();
            txtAttachmentSize = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblNotes = new Label();
            lblAttachmentSize = new Label();
            lblAttachmentName = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelLayout.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteAttachment
            // 
            btnDeleteAttachment.FlatStyle = FlatStyle.Flat;
            btnDeleteAttachment.ForeColor = Color.FromArgb(192, 0, 0);
            btnDeleteAttachment.Location = new Point(12, 274);
            btnDeleteAttachment.Name = "btnDeleteAttachment";
            btnDeleteAttachment.Size = new Size(163, 42);
            btnDeleteAttachment.TabIndex = 7;
            btnDeleteAttachment.Text = "حذف المرفق";
            btnDeleteAttachment.UseVisualStyleBackColor = true;
            btnDeleteAttachment.Click += btnDeleteAttachment_Click;
            // 
            // comboSuitAttachments
            // 
            comboSuitAttachments.BackColor = Color.FromArgb(224, 224, 224);
            comboSuitAttachments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuitAttachments.FlatStyle = FlatStyle.Flat;
            comboSuitAttachments.FormattingEnabled = true;
            comboSuitAttachments.Location = new Point(213, 274);
            comboSuitAttachments.Name = "comboSuitAttachments";
            comboSuitAttachments.RightToLeft = RightToLeft.Yes;
            comboSuitAttachments.Size = new Size(248, 42);
            comboSuitAttachments.TabIndex = 6;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(224, 224, 224);
            txtNotes.Location = new Point(62, 426);
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.Size = new Size(306, 41);
            txtNotes.TabIndex = 10;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAttachmentName
            // 
            txtAttachmentName.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentName.Location = new Point(62, 332);
            txtAttachmentName.Name = "txtAttachmentName";
            txtAttachmentName.RightToLeft = RightToLeft.Yes;
            txtAttachmentName.Size = new Size(306, 41);
            txtAttachmentName.TabIndex = 8;
            txtAttachmentName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdateSuit
            // 
            btnUpdateSuit.FlatStyle = FlatStyle.Flat;
            btnUpdateSuit.ForeColor = Color.Blue;
            btnUpdateSuit.Location = new Point(12, 207);
            btnUpdateSuit.Name = "btnUpdateSuit";
            btnUpdateSuit.Size = new Size(207, 52);
            btnUpdateSuit.TabIndex = 5;
            btnUpdateSuit.Text = "حفظ ";
            btnUpdateSuit.UseVisualStyleBackColor = true;
            btnUpdateSuit.Click += btnUpdateSuit_Click;
            // 
            // btnSaveSuitAttachment
            // 
            btnSaveSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnSaveSuitAttachment.ForeColor = Color.Green;
            btnSaveSuitAttachment.Location = new Point(144, 473);
            btnSaveSuitAttachment.Name = "btnSaveSuitAttachment";
            btnSaveSuitAttachment.Size = new Size(246, 52);
            btnSaveSuitAttachment.TabIndex = 37;
            btnSaveSuitAttachment.Text = "حفظ المرفق";
            btnSaveSuitAttachment.UseVisualStyleBackColor = true;
            btnSaveSuitAttachment.Click += btnSaveSuitAttachment_Click;
            // 
            // btnAddSuitAttachment
            // 
            btnAddSuitAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnAddSuitAttachment.ForeColor = Color.FromArgb(33, 150, 243);
            btnAddSuitAttachment.Location = new Point(331, 207);
            btnAddSuitAttachment.Name = "btnAddSuitAttachment";
            btnAddSuitAttachment.Size = new Size(207, 52);
            btnAddSuitAttachment.TabIndex = 4;
            btnAddSuitAttachment.Text = "إضافة مرفق للبدلة";
            btnAddSuitAttachment.UseVisualStyleBackColor = true;
            btnAddSuitAttachment.Click += btnAddSuitAttachment_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(350, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(111, 42);
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
            txtSuitSalePrice.Location = new Point(62, 156);
            txtSuitSalePrice.Name = "txtSuitSalePrice";
            txtSuitSalePrice.RightToLeft = RightToLeft.Yes;
            txtSuitSalePrice.Size = new Size(306, 41);
            txtSuitSalePrice.TabIndex = 3;
            txtSuitSalePrice.Text = "0";
            txtSuitSalePrice.TextAlign = HorizontalAlignment.Center;
            txtSuitSalePrice.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitSalePrice.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitRentalPrice
            // 
            txtSuitRentalPrice.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitRentalPrice.Location = new Point(62, 110);
            txtSuitRentalPrice.Name = "txtSuitRentalPrice";
            txtSuitRentalPrice.RightToLeft = RightToLeft.Yes;
            txtSuitRentalPrice.Size = new Size(306, 41);
            txtSuitRentalPrice.TabIndex = 2;
            txtSuitRentalPrice.Text = "0";
            txtSuitRentalPrice.TextAlign = HorizontalAlignment.Center;
            txtSuitRentalPrice.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitRentalPrice.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitSize
            // 
            txtSuitSize.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitSize.Location = new Point(62, 63);
            txtSuitSize.Name = "txtSuitSize";
            txtSuitSize.RightToLeft = RightToLeft.Yes;
            txtSuitSize.Size = new Size(306, 41);
            txtSuitSize.TabIndex = 1;
            txtSuitSize.Text = "0";
            txtSuitSize.TextAlign = HorizontalAlignment.Center;
            txtSuitSize.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitSize.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSize
            // 
            txtAttachmentSize.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSize.Location = new Point(62, 379);
            txtAttachmentSize.Name = "txtAttachmentSize";
            txtAttachmentSize.RightToLeft = RightToLeft.Yes;
            txtAttachmentSize.Size = new Size(306, 41);
            txtAttachmentSize.TabIndex = 9;
            txtAttachmentSize.Text = "0";
            txtAttachmentSize.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSize.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSize.Leave += TxtBoxMinZero_Leave;
            // 
            // label7
            // 
            label7.Font = new Font("Arabic Typesetting", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(463, 275);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(82, 40);
            label7.TabIndex = 51;
            label7.Text = "المرفقات";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(374, 110);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(175, 42);
            label4.TabIndex = 50;
            label4.Text = "سعر البدلة للإيجار";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(375, 154);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(174, 42);
            label3.TabIndex = 49;
            label3.Text = "سعر البدلة للبيع";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotes.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(374, 426);
            lblNotes.Name = "lblNotes";
            lblNotes.RightToLeft = RightToLeft.Yes;
            lblNotes.Size = new Size(174, 42);
            lblNotes.TabIndex = 45;
            lblNotes.Text = "ملاحظات";
            lblNotes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAttachmentSize
            // 
            lblAttachmentSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentSize.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentSize.Location = new Point(375, 379);
            lblAttachmentSize.Name = "lblAttachmentSize";
            lblAttachmentSize.RightToLeft = RightToLeft.Yes;
            lblAttachmentSize.Size = new Size(171, 42);
            lblAttachmentSize.TabIndex = 46;
            lblAttachmentSize.Text = "مقاس المرفق";
            lblAttachmentSize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAttachmentName
            // 
            lblAttachmentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentName.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentName.Location = new Point(375, 330);
            lblAttachmentName.Name = "lblAttachmentName";
            lblAttachmentName.RightToLeft = RightToLeft.Yes;
            lblAttachmentName.Size = new Size(174, 42);
            lblAttachmentName.TabIndex = 47;
            lblAttachmentName.Text = "اسم المرفق";
            lblAttachmentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(375, 63);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(174, 42);
            label2.TabIndex = 48;
            label2.Text = "مقاس البدلة";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateSuit
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(561, 325);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNotes);
            Controls.Add(lblAttachmentSize);
            Controls.Add(lblAttachmentName);
            Controls.Add(label2);
            Controls.Add(txtSuitSalePrice);
            Controls.Add(txtSuitRentalPrice);
            Controls.Add(txtSuitSize);
            Controls.Add(txtAttachmentSize);
            Controls.Add(btnDeleteAttachment);
            Controls.Add(comboSuitAttachments);
            Controls.Add(txtNotes);
            Controls.Add(txtAttachmentName);
            Controls.Add(btnUpdateSuit);
            Controls.Add(btnSaveSuitAttachment);
            Controls.Add(btnAddSuitAttachment);
            Controls.Add(panelLayout);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "UpdateSuit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateSuit";
            Load += UpdateSuit_Load;
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
        private Button btnAddSuitAttachment;
        private Label lblTitle;
        private PictureBox btnClose;
        private Panel panelLayout;
        private TextBox txtSuitSalePrice;
        private TextBox txtSuitRentalPrice;
        private TextBox txtSuitSize;
        private TextBox txtAttachmentSize;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label lblNotes;
        private Label lblAttachmentSize;
        private Label lblAttachmentName;
        private Label label2;
    }
}