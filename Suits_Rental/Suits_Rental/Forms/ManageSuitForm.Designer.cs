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
            numericSuitSize = new NumericUpDown();
            numericSuitSalePrice = new NumericUpDown();
            label3 = new Label();
            numericSuitRentPrice = new NumericUpDown();
            label4 = new Label();
            btnAddSuitAttachment = new Button();
            lblAttachmentName = new Label();
            lblAttachmentSize = new Label();
            lblNotes = new Label();
            numericAttachmentSize = new NumericUpDown();
            txtAttachmentName = new TextBox();
            txtNotes = new TextBox();
            btnSaveSuitAttachment = new Button();
            btnSaveSuit = new Button();
            comboSuitAttachments = new ComboBox();
            label7 = new Label();
            btnDeleteAttachment = new Button();
            panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitSalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitRentPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAttachmentSize).BeginInit();
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
            panelLayout.Size = new Size(561, 50);
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
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(430, 58);
            label2.Name = "label2";
            label2.Size = new Size(119, 42);
            label2.TabIndex = 1;
            label2.Text = "مقاس البدلة";
            // 
            // numericSuitSize
            // 
            numericSuitSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuitSize.BackColor = Color.FromArgb(224, 224, 224);
            numericSuitSize.DecimalPlaces = 2;
            numericSuitSize.Location = new Point(73, 58);
            numericSuitSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericSuitSize.Name = "numericSuitSize";
            numericSuitSize.RightToLeft = RightToLeft.Yes;
            numericSuitSize.Size = new Size(306, 41);
            numericSuitSize.TabIndex = 1;
            numericSuitSize.TextAlign = HorizontalAlignment.Center;
            // 
            // numericSuitSalePrice
            // 
            numericSuitSalePrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuitSalePrice.BackColor = Color.FromArgb(224, 224, 224);
            numericSuitSalePrice.DecimalPlaces = 2;
            numericSuitSalePrice.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericSuitSalePrice.Location = new Point(73, 152);
            numericSuitSalePrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 65536 });
            numericSuitSalePrice.Name = "numericSuitSalePrice";
            numericSuitSalePrice.RightToLeft = RightToLeft.Yes;
            numericSuitSalePrice.Size = new Size(306, 41);
            numericSuitSalePrice.TabIndex = 3;
            numericSuitSalePrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(397, 149);
            label3.Name = "label3";
            label3.Size = new Size(152, 42);
            label3.TabIndex = 3;
            label3.Text = "سعر البدلة للبيع";
            // 
            // numericSuitRentPrice
            // 
            numericSuitRentPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuitRentPrice.BackColor = Color.FromArgb(224, 224, 224);
            numericSuitRentPrice.DecimalPlaces = 2;
            numericSuitRentPrice.Location = new Point(73, 105);
            numericSuitRentPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericSuitRentPrice.Name = "numericSuitRentPrice";
            numericSuitRentPrice.RightToLeft = RightToLeft.Yes;
            numericSuitRentPrice.Size = new Size(306, 41);
            numericSuitRentPrice.TabIndex = 2;
            numericSuitRentPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(385, 105);
            label4.Name = "label4";
            label4.Size = new Size(175, 42);
            label4.TabIndex = 5;
            label4.Text = "سعر البدلة للإيجار";
            // 
            // btnAddSuitAttachment
            // 
            btnAddSuitAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddSuitAttachment.BackColor = Color.FromArgb(224, 224, 224);
            btnAddSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnAddSuitAttachment.ForeColor = Color.FromArgb(0, 192, 192);
            btnAddSuitAttachment.Location = new Point(319, 202);
            btnAddSuitAttachment.Name = "btnAddSuitAttachment";
            btnAddSuitAttachment.Size = new Size(230, 52);
            btnAddSuitAttachment.TabIndex = 4;
            btnAddSuitAttachment.Text = "إضافة مرفق للبدلة";
            btnAddSuitAttachment.UseVisualStyleBackColor = false;
            btnAddSuitAttachment.Click += btnAddSuitAttachment_Click;
            // 
            // lblAttachmentName
            // 
            lblAttachmentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentName.AutoSize = true;
            lblAttachmentName.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentName.Location = new Point(430, 327);
            lblAttachmentName.Name = "lblAttachmentName";
            lblAttachmentName.Size = new Size(106, 42);
            lblAttachmentName.TabIndex = 1;
            lblAttachmentName.Text = "اسم المرفق";
            // 
            // lblAttachmentSize
            // 
            lblAttachmentSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttachmentSize.AutoSize = true;
            lblAttachmentSize.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttachmentSize.Location = new Point(430, 380);
            lblAttachmentSize.Name = "lblAttachmentSize";
            lblAttachmentSize.Size = new Size(123, 42);
            lblAttachmentSize.TabIndex = 1;
            lblAttachmentSize.Text = "مقاس المرفق";
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(426, 432);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(104, 42);
            lblNotes.TabIndex = 1;
            lblNotes.Text = "ملاحظات";
            // 
            // numericAttachmentSize
            // 
            numericAttachmentSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericAttachmentSize.BackColor = Color.FromArgb(224, 224, 224);
            numericAttachmentSize.DecimalPlaces = 2;
            numericAttachmentSize.Location = new Point(73, 380);
            numericAttachmentSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericAttachmentSize.Name = "numericAttachmentSize";
            numericAttachmentSize.RightToLeft = RightToLeft.Yes;
            numericAttachmentSize.Size = new Size(306, 41);
            numericAttachmentSize.TabIndex = 7;
            numericAttachmentSize.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAttachmentName
            // 
            txtAttachmentName.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentName.Location = new Point(73, 328);
            txtAttachmentName.Name = "txtAttachmentName";
            txtAttachmentName.RightToLeft = RightToLeft.Yes;
            txtAttachmentName.Size = new Size(306, 41);
            txtAttachmentName.TabIndex = 6;
            txtAttachmentName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(224, 224, 224);
            txtNotes.Location = new Point(73, 432);
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.Size = new Size(306, 41);
            txtNotes.TabIndex = 8;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSaveSuitAttachment
            // 
            btnSaveSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnSaveSuitAttachment.ForeColor = Color.Green;
            btnSaveSuitAttachment.Location = new Point(157, 489);
            btnSaveSuitAttachment.Name = "btnSaveSuitAttachment";
            btnSaveSuitAttachment.Size = new Size(246, 52);
            btnSaveSuitAttachment.TabIndex = 9;
            btnSaveSuitAttachment.Text = "حفظ المرفق";
            btnSaveSuitAttachment.UseVisualStyleBackColor = true;
            btnSaveSuitAttachment.Click += btnSaveSuitAttachment_Click;
            // 
            // btnSaveSuit
            // 
            btnSaveSuit.FlatStyle = FlatStyle.Flat;
            btnSaveSuit.ForeColor = Color.Green;
            btnSaveSuit.Location = new Point(17, 202);
            btnSaveSuit.Name = "btnSaveSuit";
            btnSaveSuit.Size = new Size(238, 52);
            btnSaveSuit.TabIndex = 5;
            btnSaveSuit.Text = "حفظ ";
            btnSaveSuit.UseVisualStyleBackColor = true;
            btnSaveSuit.Click += btnSaveSuit_Click;
            // 
            // comboSuitAttachments
            // 
            comboSuitAttachments.BackColor = Color.FromArgb(224, 224, 224);
            comboSuitAttachments.FormattingEnabled = true;
            comboSuitAttachments.Location = new Point(219, 267);
            comboSuitAttachments.Name = "comboSuitAttachments";
            comboSuitAttachments.RightToLeft = RightToLeft.Yes;
            comboSuitAttachments.Size = new Size(248, 42);
            comboSuitAttachments.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arabic Typesetting", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(473, 267);
            label7.Name = "label7";
            label7.Size = new Size(82, 40);
            label7.TabIndex = 12;
            label7.Text = "المرفقات";
            // 
            // btnDeleteAttachment
            // 
            btnDeleteAttachment.FlatStyle = FlatStyle.Flat;
            btnDeleteAttachment.ForeColor = Color.FromArgb(192, 0, 0);
            btnDeleteAttachment.Location = new Point(17, 267);
            btnDeleteAttachment.Name = "btnDeleteAttachment";
            btnDeleteAttachment.Size = new Size(163, 42);
            btnDeleteAttachment.TabIndex = 21;
            btnDeleteAttachment.Text = "حذف المرفق";
            btnDeleteAttachment.UseVisualStyleBackColor = true;
            btnDeleteAttachment.Click += btnDeleteAttachment_Click;
            // 
            // ManageSuitForm
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(561, 322);
            Controls.Add(btnDeleteAttachment);
            Controls.Add(label7);
            Controls.Add(comboSuitAttachments);
            Controls.Add(txtNotes);
            Controls.Add(txtAttachmentName);
            Controls.Add(btnSaveSuit);
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
            Margin = new Padding(5, 6, 5, 6);
            Name = "ManageSuitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageSuitForm";
            Load += ManageSuitForm_Load;
            panelLayout.ResumeLayout(false);
            panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitSalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSuitRentPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAttachmentSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLayout;
        private Label label1;
        private PictureBox btnClose;
        private Label label2;
        private NumericUpDown numericSuitSize;
        private NumericUpDown numericSuitSalePrice;
        private Label label3;
        private NumericUpDown numericSuitRentPrice;
        private Label label4;
        private Button btnAddSuitAttachment;
        private Label lblAttachmentName;
        private Label lblAttachmentSize;
        private Label lblNotes;
        private NumericUpDown numericAttachmentSize;
        private TextBox txtAttachmentName;
        private TextBox txtNotes;
        private Button btnSaveSuitAttachment;
        private Button btnSaveSuit;
        private ComboBox comboSuitAttachments;
        private Label label7;
        private Button btnDeleteAttachment;
    }
}