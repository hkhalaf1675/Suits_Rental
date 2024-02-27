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
            txtAttachmentSize = new TextBox();
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
            label2.Location = new Point(380, 113);
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
            label3.Location = new Point(380, 204);
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
            label4.Location = new Point(379, 160);
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
            btnAddSuitAttachment.Location = new Point(313, 260);
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
            lblAttachmentName.Location = new Point(380, 383);
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
            lblAttachmentSize.Location = new Point(379, 431);
            lblAttachmentSize.Name = "lblAttachmentSize";
            lblAttachmentSize.RightToLeft = RightToLeft.Yes;
            lblAttachmentSize.Size = new Size(171, 42);
            lblAttachmentSize.TabIndex = 1;
            lblAttachmentSize.Text = "مقاس المرفق";
            lblAttachmentSize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotes.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(380, 477);
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
            txtAttachmentName.Location = new Point(68, 385);
            txtAttachmentName.Name = "txtAttachmentName";
            txtAttachmentName.RightToLeft = RightToLeft.Yes;
            txtAttachmentName.Size = new Size(306, 41);
            txtAttachmentName.TabIndex = 9;
            txtAttachmentName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(224, 224, 224);
            txtNotes.Location = new Point(68, 479);
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.Size = new Size(306, 41);
            txtNotes.TabIndex = 11;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSaveSuitAttachment
            // 
            btnSaveSuitAttachment.FlatStyle = FlatStyle.Flat;
            btnSaveSuitAttachment.ForeColor = Color.Green;
            btnSaveSuitAttachment.Location = new Point(152, 526);
            btnSaveSuitAttachment.Name = "btnSaveSuitAttachment";
            btnSaveSuitAttachment.Size = new Size(246, 52);
            btnSaveSuitAttachment.TabIndex = 12;
            btnSaveSuitAttachment.Text = "حفظ المرفق";
            btnSaveSuitAttachment.UseVisualStyleBackColor = true;
            btnSaveSuitAttachment.Click += btnSaveSuitAttachment_Click;
            // 
            // btnSaveSuit
            // 
            btnSaveSuit.FlatStyle = FlatStyle.Flat;
            btnSaveSuit.ForeColor = Color.Green;
            btnSaveSuit.Location = new Point(12, 260);
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
            comboSuitAttachments.Location = new Point(214, 325);
            comboSuitAttachments.Name = "comboSuitAttachments";
            comboSuitAttachments.RightToLeft = RightToLeft.Yes;
            comboSuitAttachments.Size = new Size(248, 42);
            comboSuitAttachments.TabIndex = 7;
            // 
            // label7
            // 
            label7.Font = new Font("Arabic Typesetting", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(468, 325);
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
            btnDeleteAttachment.Location = new Point(12, 325);
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
            label5.Location = new Point(380, 64);
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
            txtSuitId.Location = new Point(68, 64);
            txtSuitId.Name = "txtSuitId";
            txtSuitId.RightToLeft = RightToLeft.Yes;
            txtSuitId.Size = new Size(306, 41);
            txtSuitId.TabIndex = 1;
            txtSuitId.Text = "0";
            txtSuitId.TextAlign = HorizontalAlignment.Center;
            txtSuitId.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitId.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitSize
            // 
            txtSuitSize.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitSize.Location = new Point(68, 111);
            txtSuitSize.Name = "txtSuitSize";
            txtSuitSize.RightToLeft = RightToLeft.Yes;
            txtSuitSize.Size = new Size(306, 41);
            txtSuitSize.TabIndex = 2;
            txtSuitSize.Text = "0";
            txtSuitSize.TextAlign = HorizontalAlignment.Center;
            txtSuitSize.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitSize.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitRentalPrice
            // 
            txtSuitRentalPrice.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitRentalPrice.Location = new Point(68, 158);
            txtSuitRentalPrice.Name = "txtSuitRentalPrice";
            txtSuitRentalPrice.RightToLeft = RightToLeft.Yes;
            txtSuitRentalPrice.Size = new Size(306, 41);
            txtSuitRentalPrice.TabIndex = 3;
            txtSuitRentalPrice.Text = "0";
            txtSuitRentalPrice.TextAlign = HorizontalAlignment.Center;
            txtSuitRentalPrice.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitRentalPrice.Leave += TxtBoxMinZero_Leave;
            // 
            // txtSuitSalePrice
            // 
            txtSuitSalePrice.BackColor = Color.FromArgb(224, 224, 224);
            txtSuitSalePrice.Location = new Point(68, 204);
            txtSuitSalePrice.Name = "txtSuitSalePrice";
            txtSuitSalePrice.RightToLeft = RightToLeft.Yes;
            txtSuitSalePrice.Size = new Size(306, 41);
            txtSuitSalePrice.TabIndex = 4;
            txtSuitSalePrice.Text = "0";
            txtSuitSalePrice.TextAlign = HorizontalAlignment.Center;
            txtSuitSalePrice.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtSuitSalePrice.Leave += TxtBoxMinZero_Leave;
            // 
            // txtAttachmentSize
            // 
            txtAttachmentSize.BackColor = Color.FromArgb(224, 224, 224);
            txtAttachmentSize.Location = new Point(68, 432);
            txtAttachmentSize.Name = "txtAttachmentSize";
            txtAttachmentSize.RightToLeft = RightToLeft.Yes;
            txtAttachmentSize.Size = new Size(306, 41);
            txtAttachmentSize.TabIndex = 10;
            txtAttachmentSize.Text = "0";
            txtAttachmentSize.TextAlign = HorizontalAlignment.Center;
            txtAttachmentSize.KeyPress += TxtBoxPreventNonNumberic_KeyPress;
            txtAttachmentSize.Leave += TxtBoxMinZero_Leave;
            // 
            // ManageSuitForm
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(560, 375);
            Controls.Add(btnDeleteAttachment);
            Controls.Add(label7);
            Controls.Add(comboSuitAttachments);
            Controls.Add(txtNotes);
            Controls.Add(txtSuitSalePrice);
            Controls.Add(txtSuitRentalPrice);
            Controls.Add(txtSuitSize);
            Controls.Add(txtSuitId);
            Controls.Add(txtAttachmentSize);
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
            Margin = new Padding(5, 6, 5, 6);
            Name = "ManageSuitForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtAttachmentSize;
    }
}