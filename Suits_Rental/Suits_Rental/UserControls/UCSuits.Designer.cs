﻿namespace Suits_Rental.UserControls
{
    partial class UCSuits
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpContainer = new TableLayoutPanel();
            tlpHead = new TableLayoutPanel();
            label2 = new Label();
            lblAvailableSuits = new Label();
            label1 = new Label();
            lblOutsideSuits = new Label();
            btnAddNew = new Button();
            tlpDataGridAllSuits = new TableLayoutPanel();
            dataGridAllSuits = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            RentalPrice = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            AttachmentsCount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnDetails = new DataGridViewButtonColumn();
            tlpSuitInfo = new TableLayoutPanel();
            lblSuitId = new Label();
            label5 = new Label();
            comboSuitAttachments = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            tlpContainer.SuspendLayout();
            tlpHead.SuspendLayout();
            tlpDataGridAllSuits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllSuits).BeginInit();
            tlpSuitInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 1;
            tlpContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContainer.Controls.Add(tlpHead, 0, 0);
            tlpContainer.Controls.Add(tlpDataGridAllSuits, 0, 1);
            tlpContainer.Dock = DockStyle.Fill;
            tlpContainer.Location = new Point(0, 0);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RightToLeft = RightToLeft.Yes;
            tlpContainer.RowCount = 2;
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3310814F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 87.66892F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContainer.Size = new Size(853, 592);
            tlpContainer.TabIndex = 0;
            // 
            // tlpHead
            // 
            tlpHead.ColumnCount = 5;
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.23943F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7605629F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tlpHead.Controls.Add(label2, 0, 1);
            tlpHead.Controls.Add(lblAvailableSuits, 0, 1);
            tlpHead.Controls.Add(label1, 0, 1);
            tlpHead.Controls.Add(lblOutsideSuits, 3, 1);
            tlpHead.Controls.Add(btnAddNew, 4, 1);
            tlpHead.Dock = DockStyle.Fill;
            tlpHead.Location = new Point(3, 3);
            tlpHead.Name = "tlpHead";
            tlpHead.RowCount = 2;
            tlpHead.RowStyles.Add(new RowStyle(SizeType.Percent, 15.95092F));
            tlpHead.RowStyles.Add(new RowStyle(SizeType.Percent, 84.04908F));
            tlpHead.Size = new Size(847, 67);
            tlpHead.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(315, 10);
            label2.Name = "label2";
            label2.Size = new Size(134, 27);
            label2.TabIndex = 8;
            label2.Text = "عدد البدلات الخارجة";
            // 
            // lblAvailableSuits
            // 
            lblAvailableSuits.Anchor = AnchorStyles.Top;
            lblAvailableSuits.AutoSize = true;
            lblAvailableSuits.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailableSuits.ForeColor = Color.Black;
            lblAvailableSuits.Location = new Point(524, 10);
            lblAvailableSuits.Name = "lblAvailableSuits";
            lblAvailableSuits.Size = new Size(32, 27);
            lblAvailableSuits.TabIndex = 7;
            lblAvailableSuits.Text = "24";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(590, 10);
            label1.Name = "label1";
            label1.Size = new Size(141, 27);
            label1.TabIndex = 6;
            label1.Text = "عدد البدلات الموجودة";
            // 
            // lblOutsideSuits
            // 
            lblOutsideSuits.Anchor = AnchorStyles.Top;
            lblOutsideSuits.AutoSize = true;
            lblOutsideSuits.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutsideSuits.ForeColor = Color.Black;
            lblOutsideSuits.Location = new Point(260, 10);
            lblOutsideSuits.Name = "lblOutsideSuits";
            lblOutsideSuits.Size = new Size(22, 27);
            lblOutsideSuits.TabIndex = 9;
            lblOutsideSuits.Text = "0";
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.BackColor = Color.White;
            btnAddNew.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddNew.ForeColor = Color.Teal;
            btnAddNew.Location = new Point(3, 13);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(224, 51);
            btnAddNew.TabIndex = 10;
            btnAddNew.Text = "إضافة بدلة";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // tlpDataGridAllSuits
            // 
            tlpDataGridAllSuits.ColumnCount = 2;
            tlpDataGridAllSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            tlpDataGridAllSuits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0991745F));
            tlpDataGridAllSuits.Controls.Add(dataGridAllSuits, 0, 0);
            tlpDataGridAllSuits.Controls.Add(tlpSuitInfo, 1, 0);
            tlpDataGridAllSuits.Dock = DockStyle.Fill;
            tlpDataGridAllSuits.Location = new Point(3, 76);
            tlpDataGridAllSuits.Name = "tlpDataGridAllSuits";
            tlpDataGridAllSuits.RowCount = 1;
            tlpDataGridAllSuits.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDataGridAllSuits.Size = new Size(847, 513);
            tlpDataGridAllSuits.TabIndex = 1;
            // 
            // dataGridAllSuits
            // 
            dataGridAllSuits.AllowUserToAddRows = false;
            dataGridAllSuits.AllowUserToDeleteRows = false;
            dataGridAllSuits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAllSuits.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridAllSuits.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAllSuits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAllSuits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAllSuits.Columns.AddRange(new DataGridViewColumn[] { ID, RentalPrice, SalePrice, AttachmentsCount, Status, btnDetails });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arabic Typesetting", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridAllSuits.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridAllSuits.Dock = DockStyle.Fill;
            dataGridAllSuits.Location = new Point(241, 3);
            dataGridAllSuits.Name = "dataGridAllSuits";
            dataGridAllSuits.RightToLeft = RightToLeft.Yes;
            dataGridAllSuits.RowHeadersVisible = false;
            dataGridAllSuits.RowTemplate.Height = 25;
            dataGridAllSuits.Size = new Size(603, 507);
            dataGridAllSuits.TabIndex = 3;
            dataGridAllSuits.CellClick += dataGridAllSuits_CellClick;
            dataGridAllSuits.CellDoubleClick += dataGridAllSuits_CellDoubleClick;
            dataGridAllSuits.CellEnter += dataGridAllSuits_CellEnter;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "الرقم التعريفي";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // RentalPrice
            // 
            RentalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RentalPrice.HeaderText = "سعر الايجار";
            RentalPrice.Name = "RentalPrice";
            RentalPrice.ReadOnly = true;
            // 
            // SalePrice
            // 
            SalePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SalePrice.HeaderText = "سعر البيع";
            SalePrice.Name = "SalePrice";
            SalePrice.ReadOnly = true;
            // 
            // AttachmentsCount
            // 
            AttachmentsCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AttachmentsCount.HeaderText = "عدد المرفقات";
            AttachmentsCount.Name = "AttachmentsCount";
            AttachmentsCount.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.HeaderText = "العدد الموجود";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // btnDetails
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle2.ForeColor = Color.White;
            btnDetails.DefaultCellStyle = dataGridViewCellStyle2;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.HeaderText = "التفاصيل";
            btnDetails.Name = "btnDetails";
            btnDetails.Text = "التفاصيل";
            btnDetails.UseColumnTextForButtonValue = true;
            // 
            // tlpSuitInfo
            // 
            tlpSuitInfo.ColumnCount = 1;
            tlpSuitInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSuitInfo.Controls.Add(lblSuitId, 0, 1);
            tlpSuitInfo.Controls.Add(label5, 0, 3);
            tlpSuitInfo.Controls.Add(comboSuitAttachments, 0, 4);
            tlpSuitInfo.Controls.Add(btnUpdate, 0, 6);
            tlpSuitInfo.Controls.Add(btnDelete, 0, 7);
            tlpSuitInfo.Dock = DockStyle.Fill;
            tlpSuitInfo.Location = new Point(3, 3);
            tlpSuitInfo.Name = "tlpSuitInfo";
            tlpSuitInfo.RowCount = 9;
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tlpSuitInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpSuitInfo.Size = new Size(232, 507);
            tlpSuitInfo.TabIndex = 4;
            // 
            // lblSuitId
            // 
            lblSuitId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuitId.AutoSize = true;
            lblSuitId.Location = new Point(3, 87);
            lblSuitId.Name = "lblSuitId";
            lblSuitId.Size = new Size(226, 87);
            lblSuitId.TabIndex = 25;
            lblSuitId.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 201);
            label5.Name = "label5";
            label5.Size = new Size(226, 35);
            label5.TabIndex = 27;
            label5.Text = "مرفقات البدلة";
            // 
            // comboSuitAttachments
            // 
            comboSuitAttachments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboSuitAttachments.BackColor = SystemColors.ScrollBar;
            comboSuitAttachments.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuitAttachments.FlatStyle = FlatStyle.Flat;
            comboSuitAttachments.Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            comboSuitAttachments.FormattingEnabled = true;
            comboSuitAttachments.Location = new Point(3, 239);
            comboSuitAttachments.Name = "comboSuitAttachments";
            comboSuitAttachments.RightToLeft = RightToLeft.Yes;
            comboSuitAttachments.Size = new Size(226, 45);
            comboSuitAttachments.TabIndex = 28;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(33, 150, 243);
            btnUpdate.Location = new Point(3, 358);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 53);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(3, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(226, 51);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // UCSuits
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpContainer);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 7, 5, 7);
            Name = "UCSuits";
            Size = new Size(853, 592);
            Load += UCSuits_Load;
            tlpContainer.ResumeLayout(false);
            tlpHead.ResumeLayout(false);
            tlpHead.PerformLayout();
            tlpDataGridAllSuits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAllSuits).EndInit();
            tlpSuitInfo.ResumeLayout(false);
            tlpSuitInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpContainer;
        private TableLayoutPanel tlpHead;
        private Label label1;
        private Label lblAvailableSuits;
        private Label label2;
        private Label lblOutsideSuits;
        private Button btnAddNew;
        private TableLayoutPanel tlpDataGridAllSuits;
        private DataGridView dataGridAllSuits;
        private TableLayoutPanel tlpSuitInfo;
        private Label lblSuitId;
        private Label label5;
        private ComboBox comboSuitAttachments;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn RentalPrice;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn AttachmentsCount;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn btnDetails;
    }
}
