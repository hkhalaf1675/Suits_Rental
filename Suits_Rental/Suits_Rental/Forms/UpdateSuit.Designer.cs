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
            label7 = new Label();
            comboSuitAttachments = new ComboBox();
            txtNotes = new TextBox();
            txtAttachmentName = new TextBox();
            btnUpdateSuit = new Button();
            btnSaveSuitAttachment = new Button();
            btnAddSuitAttachment = new Button();
            numericSuitRentPrice = new NumericUpDown();
            label4 = new Label();
            numericSuitSalePrice = new NumericUpDown();
            label3 = new Label();
            numericAttachmentSize = new NumericUpDown();
            numericSuitSize = new NumericUpDown();
            lblNotes = new Label();
            lblAttachmentSize = new Label();
            lblAttachmentName = new Label();
            lblTitle = new Label();
            btnClose = new PictureBox();
            label2 = new Label();
            panelLayout = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericSuitRentPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitSalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAttachmentSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitSize).BeginInit();
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
            btnDeleteAttachment.TabIndex = 40;
            btnDeleteAttachment.Text = "حذف المرفق";
            btnDeleteAttachment.UseVisualStyleBackColor = true;
            btnDeleteAttachment.Click += btnDeleteAttachment_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arabic Typesetting", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(467, 273);
            label7.Name = "label7";
            label7.Size = new Size(82, 40);
            label7.TabIndex = 38;
            label7.Text = "المرفقات";
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
            comboSuitAttachments.TabIndex = 39;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(224, 224, 224);
            txtNotes.Location = new Point(62, 437);
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.Size = new Size(306, 41);
            txtNotes.TabIndex = 36;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAttachmentName
            // 
            txtAttachmentName.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentName.Location = new Point(62, 332);
            txtAttachmentName.Name = "txtAttachmentName";
            txtAttachmentName.RightToLeft = RightToLeft.Yes;
            txtAttachmentName.Size = new Size(306, 41);
            txtAttachmentName.TabIndex = 34;
            txtAttachmentName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdateSuit
            // 
            btnUpdateSuit.FlatStyle = FlatStyle.Flat;
            btnUpdateSuit.ForeColor = Color.Blue;
            btnUpdateSuit.Location = new Point(12, 207);
            btnUpdateSuit.Name = "btnUpdateSuit";
            btnUpdateSuit.Size = new Size(207, 52);
            btnUpdateSuit.TabIndex = 33;
            btnUpdateSuit.Text = "حفظ ";
            btnUpdateSuit.UseVisualStyleBackColor = true;
            btnUpdateSuit.Click += btnUpdateSuit_Click;
            // 
            // btnSaveSuitAttachment
            // 
            btnSaveSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnSaveSuitAttachment.ForeColor = Color.Green;
            btnSaveSuitAttachment.Location = new Point(144, 484);
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
            btnAddSuitAttachment.TabIndex = 31;
            btnAddSuitAttachment.Text = "إضافة مرفق للبدلة";
            btnAddSuitAttachment.UseVisualStyleBackColor = true;
            btnAddSuitAttachment.Click += btnAddSuitAttachment_Click;
            // 
            // numericSuitRentPrice
            // 
            numericSuitRentPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuitRentPrice.BackColor = Color.FromArgb(224, 224, 224);
            numericSuitRentPrice.DecimalPlaces = 2;
            numericSuitRentPrice.Location = new Point(62, 109);
            numericSuitRentPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericSuitRentPrice.Name = "numericSuitRentPrice";
            numericSuitRentPrice.RightToLeft = RightToLeft.Yes;
            numericSuitRentPrice.Size = new Size(306, 41);
            numericSuitRentPrice.TabIndex = 28;
            numericSuitRentPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(374, 109);
            label4.Name = "label4";
            label4.Size = new Size(175, 42);
            label4.TabIndex = 32;
            label4.Text = "سعر البدلة للإيجار";
            // 
            // numericSuitSalePrice
            // 
            numericSuitSalePrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuitSalePrice.BackColor = Color.FromArgb(224, 224, 224);
            numericSuitSalePrice.DecimalPlaces = 2;
            numericSuitSalePrice.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericSuitSalePrice.Location = new Point(62, 156);
            numericSuitSalePrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 65536 });
            numericSuitSalePrice.Name = "numericSuitSalePrice";
            numericSuitSalePrice.RightToLeft = RightToLeft.Yes;
            numericSuitSalePrice.Size = new Size(306, 41);
            numericSuitSalePrice.TabIndex = 30;
            numericSuitSalePrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(386, 153);
            label3.Name = "label3";
            label3.Size = new Size(152, 42);
            label3.TabIndex = 29;
            label3.Text = "سعر البدلة للبيع";
            // 
            // numericAttachmentSize
            // 
            numericAttachmentSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericAttachmentSize.BackColor = Color.FromArgb(224, 224, 224);
            numericAttachmentSize.DecimalPlaces = 2;
            numericAttachmentSize.Location = new Point(62, 384);
            numericAttachmentSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericAttachmentSize.Name = "numericAttachmentSize";
            numericAttachmentSize.RightToLeft = RightToLeft.Yes;
            numericAttachmentSize.Size = new Size(306, 41);
            numericAttachmentSize.TabIndex = 35;
            numericAttachmentSize.TextAlign = HorizontalAlignment.Center;
            // 
            // numericSuitSize
            // 
            numericSuitSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuitSize.BackColor = Color.FromArgb(224, 224, 224);
            numericSuitSize.DecimalPlaces = 2;
            numericSuitSize.Location = new Point(62, 62);
            numericSuitSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericSuitSize.Name = "numericSuitSize";
            numericSuitSize.RightToLeft = RightToLeft.Yes;
            numericSuitSize.Size = new Size(306, 41);
            numericSuitSize.TabIndex = 26;
            numericSuitSize.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(434, 437);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(104, 42);
            lblNotes.TabIndex = 25;
            lblNotes.Text = "ملاحظات";
            // 
            // lblAttachmentSize
            // 
            lblAttachmentSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentSize.AutoSize = true;
            lblAttachmentSize.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentSize.Location = new Point(426, 384);
            lblAttachmentSize.Name = "lblAttachmentSize";
            lblAttachmentSize.Size = new Size(123, 42);
            lblAttachmentSize.TabIndex = 24;
            lblAttachmentSize.Text = "مقاس المرفق";
            // 
            // lblAttachmentName
            // 
            lblAttachmentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentName.AutoSize = true;
            lblAttachmentName.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentName.Location = new Point(432, 331);
            lblAttachmentName.Name = "lblAttachmentName";
            lblAttachmentName.Size = new Size(106, 42);
            lblAttachmentName.TabIndex = 23;
            lblAttachmentName.Text = "اسم المرفق";
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(419, 62);
            label2.Name = "label2";
            label2.Size = new Size(119, 42);
            label2.TabIndex = 27;
            label2.Text = "مقاس البدلة";
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
            // UpdateSuit
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(561, 329);
            Controls.Add(btnDeleteAttachment);
            Controls.Add(label7);
            Controls.Add(comboSuitAttachments);
            Controls.Add(txtNotes);
            Controls.Add(txtAttachmentName);
            Controls.Add(btnUpdateSuit);
            Controls.Add(btnSaveSuitAttachment);
            Controls.Add(btnAddSuitAttachment);
            Controls.Add(numericSuitRentPrice);
            Controls.Add(label4);
            Controls.Add(numericSuitSalePrice);
            Controls.Add(label3);
            Controls.Add(numericAttachmentSize);
            Controls.Add(numericSuitSize);
            Controls.Add(lblNotes);
            Controls.Add(lblAttachmentSize);
            Controls.Add(lblAttachmentName);
            Controls.Add(label2);
            Controls.Add(panelLayout);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "UpdateSuit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateSuit";
            Load += UpdateSuit_Load;
            ((System.ComponentModel.ISupportInitialize)numericSuitRentPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitSalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAttachmentSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelLayout.ResumeLayout(false);
            panelLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteAttachment;
        private Label label7;
        private ComboBox comboSuitAttachments;
        private TextBox txtNotes;
        private TextBox txtAttachmentName;
        private Button btnUpdateSuit;
        private Button btnSaveSuitAttachment;
        private Button btnAddSuitAttachment;
        private NumericUpDown numericSuitRentPrice;
        private Label label4;
        private NumericUpDown numericSuitSalePrice;
        private Label label3;
        private NumericUpDown numericAttachmentSize;
        private NumericUpDown numericSuitSize;
        private Label lblNotes;
        private Label lblAttachmentSize;
        private Label lblAttachmentName;
        private Label lblTitle;
        private PictureBox btnClose;
        private Label label2;
        private Panel panelLayout;
    }
}