namespace Suits_Rental.Forms
{
    partial class SuitDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuitDetails));
            panelHead = new Panel();
            lblSuitNoHeader = new Label();
            btnClose = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            comboAvailableAttachments = new ComboBox();
            comboOutsideAttachments = new ComboBox();
            lblRentalPrice = new Label();
            lblSalePrice = new Label();
            label1 = new Label();
            comboSuitAvailableSizes = new ComboBox();
            comboSuitOutsideSizes = new ComboBox();
            panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.BackColor = Color.FromArgb(73, 78, 82);
            panelHead.Controls.Add(lblSuitNoHeader);
            panelHead.Controls.Add(btnClose);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(664, 50);
            panelHead.TabIndex = 1;
            panelHead.MouseDown += panelHead_MouseDown;
            // 
            // lblSuitNoHeader
            // 
            lblSuitNoHeader.AutoSize = true;
            lblSuitNoHeader.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuitNoHeader.ForeColor = Color.White;
            lblSuitNoHeader.Location = new Point(458, 9);
            lblSuitNoHeader.Name = "lblSuitNoHeader";
            lblSuitNoHeader.RightToLeft = RightToLeft.Yes;
            lblSuitNoHeader.Size = new Size(103, 25);
            lblSuitNoHeader.TabIndex = 1;
            lblSuitNoHeader.Text = "تفاصيل البدلة";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Left;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(0, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += CloseForm_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(486, 53);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(166, 35);
            label2.TabIndex = 2;
            label2.Text = "سعر البدلة للإيجار : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(486, 98);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(166, 35);
            label3.TabIndex = 2;
            label3.Text = "سعر البدلة للبيع : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(486, 148);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(166, 35);
            label4.TabIndex = 2;
            label4.Text = "مقاسات البدلة الموجودة : ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(486, 319);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(166, 35);
            label5.TabIndex = 2;
            label5.Text = "مرفقات البدلة الخارجة :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(486, 273);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(166, 35);
            label6.TabIndex = 2;
            label6.Text = "مرفقات البدلة الموجودة :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(12, 375);
            button1.Name = "button1";
            button1.Size = new Size(208, 50);
            button1.TabIndex = 3;
            button1.Text = "إلغاء";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CloseForm_Click;
            // 
            // comboAvailableAttachments
            // 
            comboAvailableAttachments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAvailableAttachments.FlatStyle = FlatStyle.Flat;
            comboAvailableAttachments.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboAvailableAttachments.FormattingEnabled = true;
            comboAvailableAttachments.Location = new Point(106, 273);
            comboAvailableAttachments.Name = "comboAvailableAttachments";
            comboAvailableAttachments.RightToLeft = RightToLeft.Yes;
            comboAvailableAttachments.Size = new Size(374, 28);
            comboAvailableAttachments.TabIndex = 4;
            // 
            // comboOutsideAttachments
            // 
            comboOutsideAttachments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOutsideAttachments.FlatStyle = FlatStyle.Flat;
            comboOutsideAttachments.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboOutsideAttachments.FormattingEnabled = true;
            comboOutsideAttachments.Location = new Point(106, 325);
            comboOutsideAttachments.Name = "comboOutsideAttachments";
            comboOutsideAttachments.RightToLeft = RightToLeft.Yes;
            comboOutsideAttachments.Size = new Size(374, 28);
            comboOutsideAttachments.TabIndex = 4;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRentalPrice.ForeColor = Color.Black;
            lblRentalPrice.Location = new Point(106, 53);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.RightToLeft = RightToLeft.Yes;
            lblRentalPrice.Size = new Size(374, 35);
            lblRentalPrice.TabIndex = 2;
            lblRentalPrice.Text = "0";
            lblRentalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSalePrice
            // 
            lblSalePrice.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalePrice.ForeColor = Color.Black;
            lblSalePrice.Location = new Point(106, 98);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.RightToLeft = RightToLeft.Yes;
            lblSalePrice.Size = new Size(374, 35);
            lblSalePrice.TabIndex = 2;
            lblSalePrice.Text = "0";
            lblSalePrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(486, 200);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(166, 35);
            label1.TabIndex = 2;
            label1.Text = "مقاسات البدلة الخارجة : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboSuitAvailableSizes
            // 
            comboSuitAvailableSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuitAvailableSizes.FlatStyle = FlatStyle.Flat;
            comboSuitAvailableSizes.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboSuitAvailableSizes.FormattingEnabled = true;
            comboSuitAvailableSizes.Location = new Point(106, 155);
            comboSuitAvailableSizes.Name = "comboSuitAvailableSizes";
            comboSuitAvailableSizes.RightToLeft = RightToLeft.Yes;
            comboSuitAvailableSizes.Size = new Size(374, 28);
            comboSuitAvailableSizes.TabIndex = 5;
            // 
            // comboSuitOutsideSizes
            // 
            comboSuitOutsideSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuitOutsideSizes.FlatStyle = FlatStyle.Flat;
            comboSuitOutsideSizes.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboSuitOutsideSizes.FormattingEnabled = true;
            comboSuitOutsideSizes.Location = new Point(106, 207);
            comboSuitOutsideSizes.Name = "comboSuitOutsideSizes";
            comboSuitOutsideSizes.RightToLeft = RightToLeft.Yes;
            comboSuitOutsideSizes.Size = new Size(374, 28);
            comboSuitOutsideSizes.TabIndex = 5;
            // 
            // SuitDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 437);
            Controls.Add(comboSuitOutsideSizes);
            Controls.Add(comboSuitAvailableSizes);
            Controls.Add(comboOutsideAttachments);
            Controls.Add(comboAvailableAttachments);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSalePrice);
            Controls.Add(lblRentalPrice);
            Controls.Add(label2);
            Controls.Add(panelHead);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SuitDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuitDetails";
            Load += SuitDetails_Load;
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Label lblSuitNoHeader;
        private PictureBox btnClose;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private ComboBox comboAvailableAttachments;
        private ComboBox comboOutsideAttachments;
        private Label lblRentalPrice;
        private Label lblSalePrice;
        private Label label1;
        private ComboBox comboSuitAvailableSizes;
        private ComboBox comboSuitOutsideSizes;
    }
}