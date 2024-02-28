﻿namespace Suits_Rental.UserControls
{
    partial class Orders
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            numericOrderId = new NumericUpDown();
            panel1 = new Panel();
            panelSearchSection = new Panel();
            label1 = new Label();
            txtOrderId = new TextBox();
            btnGetAllOutside = new Button();
            btnGetAllOrders = new Button();
            btnSearch = new Button();
            btnReturnSuit = new Button();
            panelBtnAddOrderSection = new Panel();
            btnMakeOrder = new Button();
            dataGridAllOrders = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            RentDays = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            RemainAmount = new DataGridViewTextBoxColumn();
            BetAttachment = new DataGridViewTextBoxColumn();
            btnPrintInvoice = new DataGridViewButtonColumn();
            btnDeleteOrder = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)numericOrderId).BeginInit();
            panel1.SuspendLayout();
            panelSearchSection.SuspendLayout();
            panelBtnAddOrderSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllOrders).BeginInit();
            SuspendLayout();
            // 
            // numericOrderId
            // 
            numericOrderId.BorderStyle = BorderStyle.None;
            numericOrderId.Location = new Point(2377, 207);
            numericOrderId.Margin = new Padding(11, 17, 11, 17);
            numericOrderId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericOrderId.Name = "numericOrderId";
            numericOrderId.RightToLeft = RightToLeft.Yes;
            numericOrderId.Size = new Size(414, 40);
            numericOrderId.TabIndex = 2;
            numericOrderId.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelSearchSection);
            panel1.Controls.Add(panelBtnAddOrderSection);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 137);
            panel1.TabIndex = 3;
            // 
            // panelSearchSection
            // 
            panelSearchSection.Controls.Add(label1);
            panelSearchSection.Controls.Add(txtOrderId);
            panelSearchSection.Controls.Add(btnGetAllOutside);
            panelSearchSection.Controls.Add(btnGetAllOrders);
            panelSearchSection.Controls.Add(btnSearch);
            panelSearchSection.Controls.Add(btnReturnSuit);
            panelSearchSection.Dock = DockStyle.Right;
            panelSearchSection.Location = new Point(1, 0);
            panelSearchSection.Name = "panelSearchSection";
            panelSearchSection.Size = new Size(629, 137);
            panelSearchSection.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(528, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 13;
            label1.Text = "رقم الأوردر";
            // 
            // txtOrderId
            // 
            txtOrderId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtOrderId.Location = new Point(377, 46);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.RightToLeft = RightToLeft.Yes;
            txtOrderId.Size = new Size(145, 44);
            txtOrderId.TabIndex = 2;
            txtOrderId.Text = "0";
            txtOrderId.TextAlign = HorizontalAlignment.Center;
            txtOrderId.KeyPress += txtOrderId_KeyPress;
            txtOrderId.Leave += txtOrderId_Leave;
            // 
            // btnGetAllOutside
            // 
            btnGetAllOutside.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetAllOutside.FlatStyle = FlatStyle.Flat;
            btnGetAllOutside.ForeColor = Color.Teal;
            btnGetAllOutside.Location = new Point(12, 68);
            btnGetAllOutside.Name = "btnGetAllOutside";
            btnGetAllOutside.Size = new Size(182, 50);
            btnGetAllOutside.TabIndex = 6;
            btnGetAllOutside.Text = "عرض كل الخارجة";
            btnGetAllOutside.UseVisualStyleBackColor = true;
            btnGetAllOutside.Click += btnGetAllOutside_Click;
            // 
            // btnGetAllOrders
            // 
            btnGetAllOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetAllOrders.FlatStyle = FlatStyle.Flat;
            btnGetAllOrders.ForeColor = Color.Teal;
            btnGetAllOrders.Location = new Point(12, 12);
            btnGetAllOrders.Name = "btnGetAllOrders";
            btnGetAllOrders.Size = new Size(182, 50);
            btnGetAllOrders.TabIndex = 5;
            btnGetAllOrders.Text = "عرض الكل";
            btnGetAllOrders.UseVisualStyleBackColor = true;
            btnGetAllOrders.Click += btnGetAllOrders_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Teal;
            btnSearch.Location = new Point(200, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 50);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReturnSuit
            // 
            btnReturnSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturnSuit.FlatStyle = FlatStyle.Flat;
            btnReturnSuit.ForeColor = Color.Teal;
            btnReturnSuit.Location = new Point(200, 68);
            btnReturnSuit.Name = "btnReturnSuit";
            btnReturnSuit.Size = new Size(171, 50);
            btnReturnSuit.TabIndex = 4;
            btnReturnSuit.Text = "إرجاع بدلة";
            btnReturnSuit.UseVisualStyleBackColor = true;
            btnReturnSuit.Click += btnReturnSuit_Click;
            // 
            // panelBtnAddOrderSection
            // 
            panelBtnAddOrderSection.Controls.Add(btnMakeOrder);
            panelBtnAddOrderSection.Dock = DockStyle.Right;
            panelBtnAddOrderSection.Location = new Point(630, 0);
            panelBtnAddOrderSection.Name = "panelBtnAddOrderSection";
            panelBtnAddOrderSection.Size = new Size(300, 137);
            panelBtnAddOrderSection.TabIndex = 8;
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMakeOrder.FlatStyle = FlatStyle.Flat;
            btnMakeOrder.ForeColor = Color.Green;
            btnMakeOrder.Location = new Point(59, 43);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(223, 50);
            btnMakeOrder.TabIndex = 1;
            btnMakeOrder.Text = "إضافة أوردر";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // dataGridAllOrders
            // 
            dataGridAllOrders.AllowUserToAddRows = false;
            dataGridAllOrders.AllowUserToDeleteRows = false;
            dataGridAllOrders.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridAllOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arabic Typesetting", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAllOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAllOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAllOrders.Columns.AddRange(new DataGridViewColumn[] { OrderId, CustomerName, OrderDate, RentDays, TotalPrice, RemainAmount, BetAttachment, btnPrintInvoice, btnDeleteOrder });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arabic Typesetting", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridAllOrders.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridAllOrders.Dock = DockStyle.Fill;
            dataGridAllOrders.Location = new Point(0, 137);
            dataGridAllOrders.Name = "dataGridAllOrders";
            dataGridAllOrders.ReadOnly = true;
            dataGridAllOrders.RightToLeft = RightToLeft.Yes;
            dataGridAllOrders.RowHeadersVisible = false;
            dataGridAllOrders.RowTemplate.Height = 25;
            dataGridAllOrders.Size = new Size(930, 453);
            dataGridAllOrders.TabIndex = 4;
            dataGridAllOrders.CellClick += dataGridAllOrders_CellClick;
            dataGridAllOrders.CellEnter += dataGridAllOrders_CellEnter;
            // 
            // OrderId
            // 
            OrderId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderId.HeaderText = "رقم الأوردر";
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerName.HeaderText = "اسم المستاجر";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // OrderDate
            // 
            OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderDate.HeaderText = "التاريخ";
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            // 
            // RentDays
            // 
            RentDays.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RentDays.HeaderText = "عدد أيام الرهن";
            RentDays.Name = "RentDays";
            RentDays.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.HeaderText = "المبلغ الكلي";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // RemainAmount
            // 
            RemainAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RemainAmount.HeaderText = "المبلغ المتبقي";
            RemainAmount.Name = "RemainAmount";
            RemainAmount.ReadOnly = true;
            // 
            // BetAttachment
            // 
            BetAttachment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BetAttachment.HeaderText = "المرفق المرهن";
            BetAttachment.Name = "BetAttachment";
            BetAttachment.ReadOnly = true;
            // 
            // btnPrintInvoice
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Teal;
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            btnPrintInvoice.DefaultCellStyle = dataGridViewCellStyle3;
            btnPrintInvoice.FlatStyle = FlatStyle.Flat;
            btnPrintInvoice.HeaderText = "طباعة الفاتورة";
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.ReadOnly = true;
            btnPrintInvoice.Text = "طباعة";
            btnPrintInvoice.UseColumnTextForButtonValue = true;
            // 
            // btnDeleteOrder
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            btnDeleteOrder.DefaultCellStyle = dataGridViewCellStyle4;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.HeaderText = "إلغاء الأوردر";
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.ReadOnly = true;
            btnDeleteOrder.Text = "إلغاء";
            btnDeleteOrder.UseColumnTextForButtonValue = true;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridAllOrders);
            Controls.Add(panel1);
            Controls.Add(numericOrderId);
            Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Orders";
            Size = new Size(930, 590);
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)numericOrderId).EndInit();
            panel1.ResumeLayout(false);
            panelSearchSection.ResumeLayout(false);
            panelSearchSection.PerformLayout();
            panelBtnAddOrderSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAllOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numericOrderId;
        private Panel panel1;
        private DataGridView dataGridAllOrders;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn RentDays;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn RemainAmount;
        private DataGridViewTextBoxColumn BetAttachment;
        private DataGridViewButtonColumn btnPrintInvoice;
        private DataGridViewButtonColumn btnDeleteOrder;
        private Panel panelBtnAddOrderSection;
        private Button btnMakeOrder;
        private Panel panelSearchSection;
        private Label label1;
        private TextBox txtOrderId;
        private Button btnGetAllOutside;
        private Button btnGetAllOrders;
        private Button btnSearch;
        private Button btnReturnSuit;
    }
}
