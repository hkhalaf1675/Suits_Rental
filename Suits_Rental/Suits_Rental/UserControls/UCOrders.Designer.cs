namespace Suits_Rental.UserControls
{
    partial class UCOrders
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlpContainer = new TableLayoutPanel();
            tlpHead = new TableLayoutPanel();
            tlpOrderNoLabelText = new TableLayoutPanel();
            tlpOrderNoTextBox = new TableLayoutPanel();
            label1 = new Label();
            txtOrderId = new TextBox();
            tlpBuutons1 = new TableLayoutPanel();
            btnReturnSuit = new Button();
            btnSearch = new Button();
            tlpButtons2 = new TableLayoutPanel();
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
            btnDetails = new DataGridViewButtonColumn();
            btnPrintInvoice = new DataGridViewButtonColumn();
            btnDeleteOrder = new DataGridViewButtonColumn();
            tlpContainer.SuspendLayout();
            tlpHead.SuspendLayout();
            tlpOrderNoTextBox.SuspendLayout();
            tlpBuutons1.SuspendLayout();
            tlpButtons2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllOrders).BeginInit();
            SuspendLayout();
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 1;
            tlpContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContainer.Controls.Add(tlpHead, 0, 0);
            tlpContainer.Controls.Add(dataGridAllOrders, 0, 1);
            tlpContainer.Dock = DockStyle.Fill;
            tlpContainer.Location = new Point(0, 0);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RightToLeft = RightToLeft.Yes;
            tlpContainer.RowCount = 2;
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tlpContainer.Size = new Size(851, 577);
            tlpContainer.TabIndex = 0;
            // 
            // tlpHead
            // 
            tlpHead.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpHead.AutoSize = true;
            tlpHead.ColumnCount = 6;
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.41214F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.58786F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tlpHead.Controls.Add(tlpOrderNoLabelText, 1, 0);
            tlpHead.Controls.Add(tlpOrderNoTextBox, 2, 0);
            tlpHead.Controls.Add(tlpBuutons1, 3, 0);
            tlpHead.Controls.Add(tlpButtons2, 4, 0);
            tlpHead.Location = new Point(3, 3);
            tlpHead.Name = "tlpHead";
            tlpHead.RowCount = 1;
            tlpHead.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpHead.Size = new Size(845, 138);
            tlpHead.TabIndex = 0;
            // 
            // tlpOrderNoLabelText
            // 
            tlpOrderNoLabelText.ColumnCount = 1;
            tlpOrderNoLabelText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOrderNoLabelText.Dock = DockStyle.Fill;
            tlpOrderNoLabelText.Location = new Point(517, 3);
            tlpOrderNoLabelText.Name = "tlpOrderNoLabelText";
            tlpOrderNoLabelText.RowCount = 3;
            tlpOrderNoLabelText.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4090919F));
            tlpOrderNoLabelText.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5909081F));
            tlpOrderNoLabelText.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tlpOrderNoLabelText.Size = new Size(102, 132);
            tlpOrderNoLabelText.TabIndex = 0;
            // 
            // tlpOrderNoTextBox
            // 
            tlpOrderNoTextBox.ColumnCount = 1;
            tlpOrderNoTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOrderNoTextBox.Controls.Add(label1, 0, 0);
            tlpOrderNoTextBox.Controls.Add(txtOrderId, 0, 1);
            tlpOrderNoTextBox.Dock = DockStyle.Fill;
            tlpOrderNoTextBox.Location = new Point(402, 3);
            tlpOrderNoTextBox.Name = "tlpOrderNoTextBox";
            tlpOrderNoTextBox.RowCount = 3;
            tlpOrderNoTextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 51.136364F));
            tlpOrderNoTextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 48.863636F));
            tlpOrderNoTextBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpOrderNoTextBox.Size = new Size(109, 132);
            tlpOrderNoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(76, 27);
            label1.TabIndex = 14;
            label1.Text = "رقم الأوردر";
            // 
            // txtOrderId
            // 
            txtOrderId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtOrderId.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtOrderId.Location = new Point(3, 47);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.RightToLeft = RightToLeft.Yes;
            txtOrderId.Size = new Size(103, 35);
            txtOrderId.TabIndex = 3;
            txtOrderId.Text = "0";
            txtOrderId.TextAlign = HorizontalAlignment.Center;
            txtOrderId.KeyPress += txtOrderId_KeyPress;
            txtOrderId.Leave += txtOrderId_Leave;
            // 
            // tlpBuutons1
            // 
            tlpBuutons1.ColumnCount = 1;
            tlpBuutons1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuutons1.Controls.Add(btnReturnSuit, 0, 1);
            tlpBuutons1.Controls.Add(btnSearch, 0, 0);
            tlpBuutons1.Dock = DockStyle.Fill;
            tlpBuutons1.Location = new Point(287, 3);
            tlpBuutons1.Name = "tlpBuutons1";
            tlpBuutons1.RowCount = 2;
            tlpBuutons1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuutons1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuutons1.Size = new Size(109, 132);
            tlpBuutons1.TabIndex = 2;
            // 
            // btnReturnSuit
            // 
            btnReturnSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturnSuit.FlatStyle = FlatStyle.Flat;
            btnReturnSuit.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturnSuit.ForeColor = Color.Teal;
            btnReturnSuit.Location = new Point(3, 69);
            btnReturnSuit.Name = "btnReturnSuit";
            btnReturnSuit.Size = new Size(102, 60);
            btnReturnSuit.TabIndex = 5;
            btnReturnSuit.Text = "إرجاع بدلة";
            btnReturnSuit.UseVisualStyleBackColor = true;
            btnReturnSuit.Click += btnReturnSuit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Teal;
            btnSearch.Location = new Point(3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 60);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tlpButtons2
            // 
            tlpButtons2.ColumnCount = 1;
            tlpButtons2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtons2.Controls.Add(btnGetAllOutside, 0, 1);
            tlpButtons2.Controls.Add(btnGetAllOrders, 0, 0);
            tlpButtons2.Dock = DockStyle.Fill;
            tlpButtons2.Location = new Point(148, 3);
            tlpButtons2.Name = "tlpButtons2";
            tlpButtons2.RowCount = 2;
            tlpButtons2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpButtons2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpButtons2.Size = new Size(133, 132);
            tlpButtons2.TabIndex = 3;
            // 
            // btnGetAllOutside
            // 
            btnGetAllOutside.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetAllOutside.FlatStyle = FlatStyle.Flat;
            btnGetAllOutside.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetAllOutside.ForeColor = Color.Teal;
            btnGetAllOutside.Location = new Point(3, 69);
            btnGetAllOutside.Name = "btnGetAllOutside";
            btnGetAllOutside.Size = new Size(127, 60);
            btnGetAllOutside.TabIndex = 7;
            btnGetAllOutside.Text = "عرض كل الخارجة";
            btnGetAllOutside.UseVisualStyleBackColor = true;
            btnGetAllOutside.Click += btnGetAllOutside_Click;
            // 
            // btnGetAllOrders
            // 
            btnGetAllOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetAllOrders.FlatStyle = FlatStyle.Flat;
            btnGetAllOrders.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetAllOrders.ForeColor = Color.Teal;
            btnGetAllOrders.Location = new Point(3, 3);
            btnGetAllOrders.Name = "btnGetAllOrders";
            btnGetAllOrders.Size = new Size(127, 60);
            btnGetAllOrders.TabIndex = 6;
            btnGetAllOrders.Text = "عرض الكل";
            btnGetAllOrders.UseVisualStyleBackColor = true;
            btnGetAllOrders.Click += btnGetAllOrders_Click;
            // 
            // dataGridAllOrders
            // 
            dataGridAllOrders.AllowUserToAddRows = false;
            dataGridAllOrders.AllowUserToDeleteRows = false;
            dataGridAllOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridAllOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridAllOrders.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridAllOrders.ColumnHeadersHeight = 75;
            dataGridAllOrders.Columns.AddRange(new DataGridViewColumn[] { OrderId, CustomerName, OrderDate, RentDays, TotalPrice, RemainAmount, BetAttachment, btnDetails, btnPrintInvoice, btnDeleteOrder });
            dataGridAllOrders.Dock = DockStyle.Fill;
            dataGridAllOrders.Location = new Point(3, 147);
            dataGridAllOrders.Name = "dataGridAllOrders";
            dataGridAllOrders.ReadOnly = true;
            dataGridAllOrders.RightToLeft = RightToLeft.Yes;
            dataGridAllOrders.RowHeadersVisible = false;
            dataGridAllOrders.RowTemplate.Height = 25;
            dataGridAllOrders.Size = new Size(845, 427);
            dataGridAllOrders.TabIndex = 5;
            dataGridAllOrders.CellClick += dataGridAllOrders_CellClick;
            dataGridAllOrders.CellEnter += dataGridAllOrders_CellEnter;
            // 
            // OrderId
            // 
            OrderId.HeaderText = "رقم الأوردر";
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Width = 110;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "اسم المستاجر";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 121;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "التاريخ";
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 83;
            // 
            // RentDays
            // 
            RentDays.HeaderText = "عدد أيام الرهن";
            RentDays.Name = "RentDays";
            RentDays.ReadOnly = true;
            RentDays.Width = 133;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "المبلغ الكلي";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 103;
            // 
            // RemainAmount
            // 
            RemainAmount.HeaderText = "المبلغ المتبقي";
            RemainAmount.Name = "RemainAmount";
            RemainAmount.ReadOnly = true;
            RemainAmount.Width = 107;
            // 
            // BetAttachment
            // 
            BetAttachment.HeaderText = "المرفق المرهن";
            BetAttachment.Name = "BetAttachment";
            BetAttachment.ReadOnly = true;
            BetAttachment.Width = 117;
            // 
            // btnDetails
            // 
            btnDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.ForeColor = Color.White;
            btnDetails.DefaultCellStyle = dataGridViewCellStyle1;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.HeaderText = "التفاصيل";
            btnDetails.Name = "btnDetails";
            btnDetails.ReadOnly = true;
            btnDetails.Text = "التفاصيل";
            btnDetails.UseColumnTextForButtonValue = true;
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
            btnPrintInvoice.ReadOnly = true;
            btnPrintInvoice.Text = "طباعة";
            btnPrintInvoice.UseColumnTextForButtonValue = true;
            btnPrintInvoice.Width = 108;
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
            btnDeleteOrder.ReadOnly = true;
            btnDeleteOrder.Text = "إلغاء";
            btnDeleteOrder.UseColumnTextForButtonValue = true;
            btnDeleteOrder.Width = 101;
            // 
            // UCOrders
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpContainer);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 7, 5, 7);
            Name = "UCOrders";
            Size = new Size(851, 577);
            Load += UCOrders_Load;
            tlpContainer.ResumeLayout(false);
            tlpContainer.PerformLayout();
            tlpHead.ResumeLayout(false);
            tlpOrderNoTextBox.ResumeLayout(false);
            tlpOrderNoTextBox.PerformLayout();
            tlpBuutons1.ResumeLayout(false);
            tlpButtons2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAllOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpContainer;
        private TableLayoutPanel tlpHead;
        private TableLayoutPanel tlpOrderNoLabelText;
        private Label label1;
        private TableLayoutPanel tlpOrderNoTextBox;
        private TextBox txtOrderId;
        private TableLayoutPanel tlpBuutons1;
        private Button btnSearch;
        private Button btnReturnSuit;
        private TableLayoutPanel tlpButtons2;
        private Button btnGetAllOrders;
        private Button btnGetAllOutside;
        private DataGridView dataGridAllOrders;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn RentDays;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn RemainAmount;
        private DataGridViewTextBoxColumn BetAttachment;
        private DataGridViewButtonColumn btnDetails;
        private DataGridViewButtonColumn btnPrintInvoice;
        private DataGridViewButtonColumn btnDeleteOrder;
    }
}
