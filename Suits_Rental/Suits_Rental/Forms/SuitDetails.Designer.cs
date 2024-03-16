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
            lblSize1 = new Label();
            lblSize2 = new Label();
            lblSize3 = new Label();
            lblSize4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            lblSize8 = new Label();
            lblSize7 = new Label();
            lblSize6 = new Label();
            lblSize5 = new Label();
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
            label4.Location = new Point(486, 182);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(166, 35);
            label4.TabIndex = 2;
            label4.Text = "مقاسات البدلة : ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(486, 325);
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
            // lblSize1
            // 
            lblSize1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize1.ForeColor = Color.Black;
            lblSize1.Location = new Point(403, 146);
            lblSize1.Name = "lblSize1";
            lblSize1.RightToLeft = RightToLeft.Yes;
            lblSize1.Size = new Size(77, 48);
            lblSize1.TabIndex = 2;
            lblSize1.Text = "0";
            lblSize1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSize2
            // 
            lblSize2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize2.ForeColor = Color.Black;
            lblSize2.Location = new Point(304, 146);
            lblSize2.Name = "lblSize2";
            lblSize2.RightToLeft = RightToLeft.Yes;
            lblSize2.Size = new Size(77, 48);
            lblSize2.TabIndex = 2;
            lblSize2.Text = "0";
            lblSize2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSize3
            // 
            lblSize3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize3.ForeColor = Color.Black;
            lblSize3.Location = new Point(205, 144);
            lblSize3.Name = "lblSize3";
            lblSize3.RightToLeft = RightToLeft.Yes;
            lblSize3.Size = new Size(77, 50);
            lblSize3.TabIndex = 2;
            lblSize3.Text = "0";
            lblSize3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSize4
            // 
            lblSize4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize4.ForeColor = Color.Black;
            lblSize4.Location = new Point(106, 146);
            lblSize4.Name = "lblSize4";
            lblSize4.RightToLeft = RightToLeft.Yes;
            lblSize4.Size = new Size(77, 48);
            lblSize4.TabIndex = 2;
            lblSize4.Text = "0";
            lblSize4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 78, 82);
            panel1.Location = new Point(189, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 50);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(73, 78, 82);
            panel2.Location = new Point(288, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 50);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(73, 78, 82);
            panel3.Location = new Point(387, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 50);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(73, 78, 82);
            panel4.Location = new Point(387, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 50);
            panel4.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(73, 78, 82);
            panel5.Location = new Point(288, 200);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 50);
            panel5.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(73, 78, 82);
            panel6.Location = new Point(189, 200);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 50);
            panel6.TabIndex = 11;
            // 
            // lblSize8
            // 
            lblSize8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize8.ForeColor = Color.Black;
            lblSize8.Location = new Point(106, 202);
            lblSize8.Name = "lblSize8";
            lblSize8.RightToLeft = RightToLeft.Yes;
            lblSize8.Size = new Size(77, 48);
            lblSize8.TabIndex = 7;
            lblSize8.Text = "0";
            lblSize8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSize7
            // 
            lblSize7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize7.ForeColor = Color.Black;
            lblSize7.Location = new Point(205, 200);
            lblSize7.Name = "lblSize7";
            lblSize7.RightToLeft = RightToLeft.Yes;
            lblSize7.Size = new Size(77, 50);
            lblSize7.TabIndex = 8;
            lblSize7.Text = "0";
            lblSize7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSize6
            // 
            lblSize6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize6.ForeColor = Color.Black;
            lblSize6.Location = new Point(304, 202);
            lblSize6.Name = "lblSize6";
            lblSize6.RightToLeft = RightToLeft.Yes;
            lblSize6.Size = new Size(77, 48);
            lblSize6.TabIndex = 9;
            lblSize6.Text = "0";
            lblSize6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSize5
            // 
            lblSize5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize5.ForeColor = Color.Black;
            lblSize5.Location = new Point(403, 202);
            lblSize5.Name = "lblSize5";
            lblSize5.RightToLeft = RightToLeft.Yes;
            lblSize5.Size = new Size(77, 48);
            lblSize5.TabIndex = 10;
            lblSize5.Text = "0";
            lblSize5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SuitDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 437);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(lblSize8);
            Controls.Add(panel1);
            Controls.Add(lblSize7);
            Controls.Add(comboOutsideAttachments);
            Controls.Add(lblSize6);
            Controls.Add(comboAvailableAttachments);
            Controls.Add(lblSize5);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSize4);
            Controls.Add(lblSize3);
            Controls.Add(lblSize2);
            Controls.Add(lblSize1);
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
        private Label lblSize1;
        private Label lblSize2;
        private Label lblSize3;
        private Label lblSize4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label lblSize8;
        private Label lblSize7;
        private Label lblSize6;
        private Label lblSize5;
    }
}