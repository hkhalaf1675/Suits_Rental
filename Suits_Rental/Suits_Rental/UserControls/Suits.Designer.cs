namespace Suits_Rental.UserControls
{
    partial class Suits
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHead = new Panel();
            btnAddNew = new Button();
            lblOutsideSuits = new Label();
            lblAvailableSuits = new Label();
            label2 = new Label();
            label1 = new Label();
            panelSuitSelect = new Panel();
            comboSuitAttachments = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            lblSuitSize = new Label();
            lblSuitId = new Label();
            label3 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            panelAllSuits = new Panel();
            dataGridAllSuits = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            SuitSize = new DataGridViewTextBoxColumn();
            RentalPrice = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            AttachmentsCount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panelHead.SuspendLayout();
            panelSuitSelect.SuspendLayout();
            panelAllSuits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllSuits).BeginInit();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.Controls.Add(btnAddNew);
            panelHead.Controls.Add(lblOutsideSuits);
            panelHead.Controls.Add(lblAvailableSuits);
            panelHead.Controls.Add(label2);
            panelHead.Controls.Add(label1);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(930, 77);
            panelHead.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.BackColor = Color.White;
            btnAddNew.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddNew.ForeColor = Color.Teal;
            btnAddNew.Location = new Point(50, 15);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(249, 47);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "إضافة بدلة";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // lblOutsideSuits
            // 
            lblOutsideSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOutsideSuits.AutoSize = true;
            lblOutsideSuits.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutsideSuits.ForeColor = Color.Black;
            lblOutsideSuits.Location = new Point(331, 18);
            lblOutsideSuits.Name = "lblOutsideSuits";
            lblOutsideSuits.Size = new Size(31, 42);
            lblOutsideSuits.TabIndex = 2;
            lblOutsideSuits.Text = "0";
            // 
            // lblAvailableSuits
            // 
            lblAvailableSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAvailableSuits.AutoSize = true;
            lblAvailableSuits.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailableSuits.ForeColor = Color.Black;
            lblAvailableSuits.Location = new Point(600, 18);
            lblAvailableSuits.Name = "lblAvailableSuits";
            lblAvailableSuits.Size = new Size(44, 42);
            lblAvailableSuits.TabIndex = 3;
            lblAvailableSuits.Text = "24";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(369, 18);
            label2.Name = "label2";
            label2.Size = new Size(198, 42);
            label2.TabIndex = 4;
            label2.Text = "عدد البدلات الخارجة";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(649, 18);
            label1.Name = "label1";
            label1.Size = new Size(208, 42);
            label1.TabIndex = 5;
            label1.Text = "عدد البدلات الموجودة";
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
            panelSuitSelect.Location = new Point(0, 77);
            panelSuitSelect.Name = "panelSuitSelect";
            panelSuitSelect.Size = new Size(231, 513);
            panelSuitSelect.TabIndex = 1;
            panelSuitSelect.Visible = false;
            // 
            // comboSuitAttachments
            // 
            comboSuitAttachments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboSuitAttachments.BackColor = SystemColors.ScrollBar;
            comboSuitAttachments.FlatStyle = FlatStyle.Flat;
            comboSuitAttachments.Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            comboSuitAttachments.FormattingEnabled = true;
            comboSuitAttachments.Location = new Point(11, 212);
            comboSuitAttachments.Name = "comboSuitAttachments";
            comboSuitAttachments.RightToLeft = RightToLeft.Yes;
            comboSuitAttachments.Size = new Size(209, 45);
            comboSuitAttachments.TabIndex = 26;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(55, 172);
            label5.Name = "label5";
            label5.Size = new Size(117, 37);
            label5.TabIndex = 21;
            label5.Text = "مرفقات البدلة";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(83, 122);
            label4.Name = "label4";
            label4.Size = new Size(104, 37);
            label4.TabIndex = 22;
            label4.Text = "مقاس البدلة";
            // 
            // lblSuitSize
            // 
            lblSuitSize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuitSize.AutoSize = true;
            lblSuitSize.Location = new Point(31, 122);
            lblSuitSize.Name = "lblSuitSize";
            lblSuitSize.Size = new Size(41, 37);
            lblSuitSize.TabIndex = 23;
            lblSuitSize.Text = "00";
            // 
            // lblSuitId
            // 
            lblSuitId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuitId.AutoSize = true;
            lblSuitId.Location = new Point(43, 74);
            lblSuitId.Name = "lblSuitId";
            lblSuitId.Size = new Size(29, 37);
            lblSuitId.TabIndex = 24;
            lblSuitId.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(105, 74);
            label3.Name = "label3";
            label3.Size = new Size(82, 37);
            label3.TabIndex = 25;
            label3.Text = "رقم البدلة";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(11, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 51);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(33, 150, 243);
            btnUpdate.Location = new Point(11, 315);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 51);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panelAllSuits
            // 
            panelAllSuits.Controls.Add(dataGridAllSuits);
            panelAllSuits.Dock = DockStyle.Fill;
            panelAllSuits.Location = new Point(231, 77);
            panelAllSuits.Name = "panelAllSuits";
            panelAllSuits.Size = new Size(699, 513);
            panelAllSuits.TabIndex = 2;
            // 
            // dataGridAllSuits
            // 
            dataGridAllSuits.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arabic Typesetting", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAllSuits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAllSuits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAllSuits.Columns.AddRange(new DataGridViewColumn[] { ID, SuitSize, RentalPrice, SalePrice, AttachmentsCount, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arabic Typesetting", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridAllSuits.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridAllSuits.Dock = DockStyle.Fill;
            dataGridAllSuits.Location = new Point(0, 0);
            dataGridAllSuits.Name = "dataGridAllSuits";
            dataGridAllSuits.RightToLeft = RightToLeft.Yes;
            dataGridAllSuits.RowHeadersVisible = false;
            dataGridAllSuits.RowTemplate.Height = 25;
            dataGridAllSuits.Size = new Size(699, 513);
            dataGridAllSuits.TabIndex = 2;
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
            // SuitSize
            // 
            SuitSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SuitSize.HeaderText = "مقاس البدلة";
            SuitSize.Name = "SuitSize";
            SuitSize.ReadOnly = true;
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
            Status.HeaderText = "الحالة";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Suits
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAllSuits);
            Controls.Add(panelSuitSelect);
            Controls.Add(panelHead);
            Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Suits";
            Size = new Size(930, 590);
            Load += Suits_Load;
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            panelSuitSelect.ResumeLayout(false);
            panelSuitSelect.PerformLayout();
            panelAllSuits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAllSuits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Button btnAddNew;
        private Label lblOutsideSuits;
        private Label lblAvailableSuits;
        private Label label2;
        private Label label1;
        private Panel panelSuitSelect;
        private ComboBox comboSuitAttachments;
        private Label label5;
        private Label label4;
        private Label lblSuitSize;
        private Label lblSuitId;
        private Label label3;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panelAllSuits;
        private DataGridView dataGridAllSuits;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SuitSize;
        private DataGridViewTextBoxColumn RentalPrice;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn AttachmentsCount;
        private DataGridViewTextBoxColumn Status;
    }
}
