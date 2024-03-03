﻿namespace Suits_Rental.Forms
{
    partial class SelectAttachmentSizes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAttachmentSizes));
            panelLayout = new Panel();
            label1 = new Label();
            btnClose = new PictureBox();
            panelSelectedSizes = new Panel();
            btnSave = new Button();
            panelAttachmentsAndSizes = new Panel();
            label5 = new Label();
            btnDeleteSize = new Button();
            btnAddAttchmentSize = new Button();
            comboSelectedSizes = new ComboBox();
            comboAvailableSizes = new ComboBox();
            comboAttachments = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelSelectedSizes.SuspendLayout();
            panelAttachmentsAndSizes.SuspendLayout();
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
            panelLayout.Size = new Size(690, 50);
            panelLayout.TabIndex = 1;
            panelLayout.MouseDown += panelLayout_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(289, 8);
            label1.Name = "label1";
            label1.Size = new Size(223, 42);
            label1.TabIndex = 0;
            label1.Text = "إختيار مقاسات المرفقات";
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
            // panelSelectedSizes
            // 
            panelSelectedSizes.Controls.Add(btnSave);
            panelSelectedSizes.Dock = DockStyle.Bottom;
            panelSelectedSizes.Location = new Point(0, 326);
            panelSelectedSizes.Name = "panelSelectedSizes";
            panelSelectedSizes.Size = new Size(690, 74);
            panelSelectedSizes.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Silver;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(196, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(316, 52);
            btnSave.TabIndex = 3;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panelAttachmentsAndSizes
            // 
            panelAttachmentsAndSizes.Controls.Add(label5);
            panelAttachmentsAndSizes.Controls.Add(btnDeleteSize);
            panelAttachmentsAndSizes.Controls.Add(btnAddAttchmentSize);
            panelAttachmentsAndSizes.Controls.Add(comboSelectedSizes);
            panelAttachmentsAndSizes.Controls.Add(comboAvailableSizes);
            panelAttachmentsAndSizes.Controls.Add(comboAttachments);
            panelAttachmentsAndSizes.Controls.Add(label4);
            panelAttachmentsAndSizes.Controls.Add(label3);
            panelAttachmentsAndSizes.Controls.Add(label2);
            panelAttachmentsAndSizes.Dock = DockStyle.Fill;
            panelAttachmentsAndSizes.Location = new Point(0, 50);
            panelAttachmentsAndSizes.Name = "panelAttachmentsAndSizes";
            panelAttachmentsAndSizes.Size = new Size(690, 276);
            panelAttachmentsAndSizes.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(507, 214);
            label5.Name = "label5";
            label5.Size = new Size(171, 42);
            label5.TabIndex = 1;
            label5.Text = "المقاسات المختارة";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDeleteSize
            // 
            btnDeleteSize.BackColor = Color.Silver;
            btnDeleteSize.FlatStyle = FlatStyle.Flat;
            btnDeleteSize.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDeleteSize.ForeColor = Color.Red;
            btnDeleteSize.Location = new Point(37, 216);
            btnDeleteSize.Name = "btnDeleteSize";
            btnDeleteSize.Size = new Size(147, 42);
            btnDeleteSize.TabIndex = 4;
            btnDeleteSize.Text = "حذف";
            btnDeleteSize.UseVisualStyleBackColor = false;
            btnDeleteSize.Click += btnDeleteSize_Click;
            // 
            // btnAddAttchmentSize
            // 
            btnAddAttchmentSize.BackColor = Color.Silver;
            btnAddAttchmentSize.FlatStyle = FlatStyle.Flat;
            btnAddAttchmentSize.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddAttchmentSize.ForeColor = Color.Teal;
            btnAddAttchmentSize.Location = new Point(12, 158);
            btnAddAttchmentSize.Name = "btnAddAttchmentSize";
            btnAddAttchmentSize.Size = new Size(305, 52);
            btnAddAttchmentSize.TabIndex = 3;
            btnAddAttchmentSize.Text = "إضافة";
            btnAddAttchmentSize.UseVisualStyleBackColor = false;
            btnAddAttchmentSize.Click += btnAddAttchmentSize_Click;
            // 
            // comboSelectedSizes
            // 
            comboSelectedSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSelectedSizes.FormattingEnabled = true;
            comboSelectedSizes.Location = new Point(216, 216);
            comboSelectedSizes.Name = "comboSelectedSizes";
            comboSelectedSizes.RightToLeft = RightToLeft.Yes;
            comboSelectedSizes.Size = new Size(285, 42);
            comboSelectedSizes.TabIndex = 1;
            // 
            // comboAvailableSizes
            // 
            comboAvailableSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAvailableSizes.FormattingEnabled = true;
            comboAvailableSizes.Location = new Point(216, 110);
            comboAvailableSizes.Name = "comboAvailableSizes";
            comboAvailableSizes.RightToLeft = RightToLeft.Yes;
            comboAvailableSizes.Size = new Size(285, 42);
            comboAvailableSizes.TabIndex = 1;
            // 
            // comboAttachments
            // 
            comboAttachments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAttachments.FormattingEnabled = true;
            comboAttachments.Location = new Point(216, 58);
            comboAttachments.Name = "comboAttachments";
            comboAttachments.RightToLeft = RightToLeft.Yes;
            comboAttachments.Size = new Size(285, 42);
            comboAttachments.TabIndex = 1;
            comboAttachments.SelectedIndexChanged += comboAttachments_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(507, 110);
            label4.Name = "label4";
            label4.Size = new Size(171, 42);
            label4.TabIndex = 1;
            label4.Text = "المقاسات الموجودة";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(507, 58);
            label3.Name = "label3";
            label3.Size = new Size(171, 42);
            label3.TabIndex = 2;
            label3.Text = "مرفقات البدلة";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(245, 3);
            label2.Name = "label2";
            label2.Size = new Size(433, 42);
            label2.TabIndex = 3;
            label2.Text = "إختر مرفق البدلة ثم إختر المقاس ثم إضغط إضافة";
            // 
            // SelectAttachmentSizes
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(690, 400);
            Controls.Add(panelAttachmentsAndSizes);
            Controls.Add(panelSelectedSizes);
            Controls.Add(panelLayout);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 7, 5, 7);
            Name = "SelectAttachmentSizes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectAttachmentSizes";
            Load += SelectAttachmentSizes_Load;
            panelLayout.ResumeLayout(false);
            panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelSelectedSizes.ResumeLayout(false);
            panelAttachmentsAndSizes.ResumeLayout(false);
            panelAttachmentsAndSizes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLayout;
        private Label label1;
        private PictureBox btnClose;
        private Panel panelSelectedSizes;
        private Panel panelAttachmentsAndSizes;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboAttachments;
        private ComboBox comboSelectedSizes;
        private Label label5;
        private Button btnAddAttchmentSize;
        private ComboBox comboAvailableSizes;
        private Button btnDeleteSize;
        private Button btnSave;
    }
}