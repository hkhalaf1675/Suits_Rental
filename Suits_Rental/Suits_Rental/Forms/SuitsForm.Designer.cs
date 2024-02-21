﻿namespace Suits_Rental.Forms
{
    partial class SuitsForm
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
            label1 = new Label();
            lblAvailableSuits = new Label();
            label2 = new Label();
            lblOutsideSuits = new Label();
            btnAddNew = new Button();
            panelSuitsContainer = new Panel();
            dataGridAllSuits = new DataGridView();
            panelSuitSelect = new Panel();
            comboSuitAttachments = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            lblSuitSize = new Label();
            lblSuitId = new Label();
            label3 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            panelSuitsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllSuits).BeginInit();
            panelSuitSelect.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(220, 50, 44);
            label1.Location = new Point(665, 25);
            label1.Name = "label1";
            label1.Size = new Size(208, 42);
            label1.TabIndex = 0;
            label1.Text = "عدد البدلات الموجودة";
            // 
            // lblAvailableSuits
            // 
            lblAvailableSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAvailableSuits.AutoSize = true;
            lblAvailableSuits.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailableSuits.ForeColor = Color.Black;
            lblAvailableSuits.Location = new Point(616, 25);
            lblAvailableSuits.Name = "lblAvailableSuits";
            lblAvailableSuits.Size = new Size(44, 42);
            lblAvailableSuits.TabIndex = 0;
            lblAvailableSuits.Text = "24";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(220, 50, 44);
            label2.Location = new Point(385, 25);
            label2.Name = "label2";
            label2.Size = new Size(198, 42);
            label2.TabIndex = 0;
            label2.Text = "عدد البدلات الخارجة";
            // 
            // lblOutsideSuits
            // 
            lblOutsideSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOutsideSuits.AutoSize = true;
            lblOutsideSuits.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutsideSuits.ForeColor = Color.Black;
            lblOutsideSuits.Location = new Point(347, 25);
            lblOutsideSuits.Name = "lblOutsideSuits";
            lblOutsideSuits.Size = new Size(31, 42);
            lblOutsideSuits.TabIndex = 0;
            lblOutsideSuits.Text = "0";
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.BackColor = Color.White;
            btnAddNew.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddNew.ForeColor = Color.FromArgb(33, 150, 243);
            btnAddNew.Location = new Point(66, 23);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(249, 47);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "إضافة بدلة";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // panelSuitsContainer
            // 
            panelSuitsContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSuitsContainer.Controls.Add(dataGridAllSuits);
            panelSuitsContainer.Controls.Add(panelSuitSelect);
            panelSuitsContainer.Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            panelSuitsContainer.Location = new Point(0, 85);
            panelSuitsContainer.Name = "panelSuitsContainer";
            panelSuitsContainer.Size = new Size(914, 425);
            panelSuitsContainer.TabIndex = 2;
            // 
            // dataGridAllSuits
            // 
            dataGridAllSuits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAllSuits.Dock = DockStyle.Fill;
            dataGridAllSuits.Location = new Point(234, 0);
            dataGridAllSuits.Name = "dataGridAllSuits";
            dataGridAllSuits.RowTemplate.Height = 25;
            dataGridAllSuits.Size = new Size(680, 425);
            dataGridAllSuits.TabIndex = 1;
            dataGridAllSuits.RowEnter += dataGridAllSuits_RowEnter;
            dataGridAllSuits.Click += dataGridAllSuits_Click;
            dataGridAllSuits.DoubleClick += dataGridAllSuits_DoubleClick;
            // 
            // panelSuitSelect
            // 
            panelSuitSelect.Controls.Add(comboSuitAttachments);
            panelSuitSelect.Controls.Add(label5);
            panelSuitSelect.Controls.Add(label4);
            panelSuitSelect.Controls.Add(lblSuitSize);
            panelSuitSelect.Controls.Add(lblSuitId);
            panelSuitSelect.Controls.Add(label3);
            panelSuitSelect.Controls.Add(btnDelete);
            panelSuitSelect.Controls.Add(btnUpdate);
            panelSuitSelect.Dock = DockStyle.Left;
            panelSuitSelect.Location = new Point(0, 0);
            panelSuitSelect.Name = "panelSuitSelect";
            panelSuitSelect.Size = new Size(234, 425);
            panelSuitSelect.TabIndex = 0;
            // 
            // comboSuitAttachments
            // 
            comboSuitAttachments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboSuitAttachments.FormattingEnabled = true;
            comboSuitAttachments.Location = new Point(12, 168);
            comboSuitAttachments.Name = "comboSuitAttachments";
            comboSuitAttachments.RightToLeft = RightToLeft.Yes;
            comboSuitAttachments.Size = new Size(209, 45);
            comboSuitAttachments.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(56, 128);
            label5.Name = "label5";
            label5.Size = new Size(117, 37);
            label5.TabIndex = 13;
            label5.Text = "مرفقات البدلة";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(84, 78);
            label4.Name = "label4";
            label4.Size = new Size(104, 37);
            label4.TabIndex = 14;
            label4.Text = "مقاس البدلة";
            // 
            // lblSuitSize
            // 
            lblSuitSize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuitSize.AutoSize = true;
            lblSuitSize.Location = new Point(32, 78);
            lblSuitSize.Name = "lblSuitSize";
            lblSuitSize.Size = new Size(41, 37);
            lblSuitSize.TabIndex = 15;
            lblSuitSize.Text = "00";
            // 
            // lblSuitId
            // 
            lblSuitId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuitId.AutoSize = true;
            lblSuitId.Location = new Point(44, 30);
            lblSuitId.Name = "lblSuitId";
            lblSuitId.Size = new Size(29, 37);
            lblSuitId.TabIndex = 16;
            lblSuitId.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(106, 30);
            label3.Name = "label3";
            label3.Size = new Size(82, 37);
            label3.TabIndex = 17;
            label3.Text = "رقم البدلة";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(12, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 51);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(33, 150, 243);
            btnUpdate.Location = new Point(12, 271);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 51);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // SuitsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 510);
            Controls.Add(panelSuitsContainer);
            Controls.Add(btnAddNew);
            Controls.Add(lblOutsideSuits);
            Controls.Add(lblAvailableSuits);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuitsForm";
            Text = "SuitsForm";
            Load += SuitsForm_Load;
            panelSuitsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAllSuits).EndInit();
            panelSuitSelect.ResumeLayout(false);
            panelSuitSelect.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAvailableSuits;
        private Label label2;
        private Label lblOutsideSuits;
        private Button btnAddNew;
        private Panel panelSuitsContainer;
        private Panel panelSuitSelect;
        private ComboBox comboSuitAttachments;
        private Label label5;
        private Label label4;
        private Label lblSuitSize;
        private Label lblSuitId;
        private Label label3;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridAllSuits;
    }
}