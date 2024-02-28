namespace Suits_Rental.UserControls
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            numericOrderId = new NumericUpDown();
            btnMakeOrder = new Button();
            btnReturnSuit = new Button();
            btnSearch = new Button();
            numericSearchOrderNum = new NumericUpDown();
            label2 = new Label();
            panel1 = new Panel();
            btnGetAllOutside = new Button();
            btnGetAllOrders = new Button();
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
            ((System.ComponentModel.ISupportInitialize)numericSearchOrderNum).BeginInit();
            panel1.SuspendLayout();
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
            // btnMakeOrder
            // 
            btnMakeOrder.FlatStyle = FlatStyle.Flat;
            btnMakeOrder.ForeColor = Color.Green;
            btnMakeOrder.Location = new Point(613, 44);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(223, 50);
            btnMakeOrder.TabIndex = 6;
            btnMakeOrder.Text = "إضافة أوردر";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // btnReturnSuit
            // 
            btnReturnSuit.FlatStyle = FlatStyle.Flat;
            btnReturnSuit.ForeColor = Color.Teal;
            btnReturnSuit.Location = new Point(191, 73);
            btnReturnSuit.Name = "btnReturnSuit";
            btnReturnSuit.Size = new Size(171, 50);
            btnReturnSuit.TabIndex = 5;
            btnReturnSuit.Text = "إرجاع بدلة";
            btnReturnSuit.UseVisualStyleBackColor = true;
            btnReturnSuit.Click += btnReturnSuit_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Teal;
            btnSearch.Location = new Point(191, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 50);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // numericSearchOrderNum
            // 
            numericSearchOrderNum.BackColor = Color.Gainsboro;
            numericSearchOrderNum.BorderStyle = BorderStyle.None;
            numericSearchOrderNum.Location = new Point(366, 51);
            numericSearchOrderNum.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericSearchOrderNum.Name = "numericSearchOrderNum";
            numericSearchOrderNum.RightToLeft = RightToLeft.Yes;
            numericSearchOrderNum.Size = new Size(120, 40);
            numericSearchOrderNum.TabIndex = 7;
            numericSearchOrderNum.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 51);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 9;
            label2.Text = "رقم الأوردر";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numericSearchOrderNum);
            panel1.Controls.Add(btnGetAllOutside);
            panel1.Controls.Add(btnGetAllOrders);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnReturnSuit);
            panel1.Controls.Add(btnMakeOrder);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 137);
            panel1.TabIndex = 3;
            // 
            // btnGetAllOutside
            // 
            btnGetAllOutside.FlatStyle = FlatStyle.Flat;
            btnGetAllOutside.ForeColor = Color.Teal;
            btnGetAllOutside.Location = new Point(3, 73);
            btnGetAllOutside.Name = "btnGetAllOutside";
            btnGetAllOutside.Size = new Size(182, 50);
            btnGetAllOutside.TabIndex = 4;
            btnGetAllOutside.Text = "عرض كل الخارجة";
            btnGetAllOutside.UseVisualStyleBackColor = true;
            btnGetAllOutside.Click += btnGetAllOutside_Click;
            // 
            // btnGetAllOrders
            // 
            btnGetAllOrders.FlatStyle = FlatStyle.Flat;
            btnGetAllOrders.ForeColor = Color.Teal;
            btnGetAllOrders.Location = new Point(3, 17);
            btnGetAllOrders.Name = "btnGetAllOrders";
            btnGetAllOrders.Size = new Size(182, 50);
            btnGetAllOrders.TabIndex = 4;
            btnGetAllOrders.Text = "عرض الكل";
            btnGetAllOrders.UseVisualStyleBackColor = true;
            btnGetAllOrders.Click += btnGetAllOrders_Click;
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
            dataGridAllOrders.RightToLeft = RightToLeft.Yes;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            btnPrintInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            btnPrintInvoice.FlatStyle = FlatStyle.Flat;
            btnPrintInvoice.HeaderText = "طباعة الفاتورة";
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Text = "طباعة";
            btnPrintInvoice.UseColumnTextForButtonValue = true;
            // 
            // btnDeleteOrder
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            btnDeleteOrder.DefaultCellStyle = dataGridViewCellStyle3;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.HeaderText = "إلغاء الأوردر";
            btnDeleteOrder.Name = "btnDeleteOrder";
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
            ((System.ComponentModel.ISupportInitialize)numericSearchOrderNum).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numericOrderId;
        private Button btnMakeOrder;
        private Button btnReturnSuit;
        private Button btnSearch;
        private NumericUpDown numericSearchOrderNum;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridAllOrders;
        private Button btnGetAllOrders;
        private Button btnGetAllOutside;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn RentDays;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn RemainAmount;
        private DataGridViewTextBoxColumn BetAttachment;
        private DataGridViewButtonColumn btnPrintInvoice;
        private DataGridViewButtonColumn btnDeleteOrder;
    }
}
