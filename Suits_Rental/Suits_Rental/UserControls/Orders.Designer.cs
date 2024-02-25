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
            numericOrderId = new NumericUpDown();
            btnMakeOrder = new Button();
            btnReturnSuit = new Button();
            btnSearch = new Button();
            numericReturnOrderNum = new NumericUpDown();
            numericSearchOrderNum = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            dataGridAllOrders = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            RentDays = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            RemainAmount = new DataGridViewTextBoxColumn();
            BetAttachment = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericOrderId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericReturnOrderNum).BeginInit();
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
            btnMakeOrder.Location = new Point(893, 28);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(185, 80);
            btnMakeOrder.TabIndex = 6;
            btnMakeOrder.Text = "إضافة أوردر";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // btnReturnSuit
            // 
            btnReturnSuit.FlatStyle = FlatStyle.Flat;
            btnReturnSuit.ForeColor = Color.Teal;
            btnReturnSuit.Location = new Point(549, 28);
            btnReturnSuit.Name = "btnReturnSuit";
            btnReturnSuit.Size = new Size(144, 80);
            btnReturnSuit.TabIndex = 5;
            btnReturnSuit.Text = "إرجاع بدلة";
            btnReturnSuit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Teal;
            btnSearch.Location = new Point(22, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 80);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // numericReturnOrderNum
            // 
            numericReturnOrderNum.BorderStyle = BorderStyle.None;
            numericReturnOrderNum.Location = new Point(699, 68);
            numericReturnOrderNum.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericReturnOrderNum.Name = "numericReturnOrderNum";
            numericReturnOrderNum.RightToLeft = RightToLeft.Yes;
            numericReturnOrderNum.Size = new Size(120, 40);
            numericReturnOrderNum.TabIndex = 8;
            numericReturnOrderNum.TextAlign = HorizontalAlignment.Center;
            // 
            // numericSearchOrderNum
            // 
            numericSearchOrderNum.BorderStyle = BorderStyle.None;
            numericSearchOrderNum.Location = new Point(172, 68);
            numericSearchOrderNum.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericSearchOrderNum.Name = "numericSearchOrderNum";
            numericSearchOrderNum.RightToLeft = RightToLeft.Yes;
            numericSearchOrderNum.Size = new Size(120, 40);
            numericSearchOrderNum.TabIndex = 7;
            numericSearchOrderNum.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(708, 28);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 10;
            label1.Text = "رقم الأوردر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 28);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 9;
            label2.Text = "رقم الأوردر";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericSearchOrderNum);
            panel1.Controls.Add(numericReturnOrderNum);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnReturnSuit);
            panel1.Controls.Add(btnMakeOrder);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 137);
            panel1.TabIndex = 3;
            // 
            // dataGridAllOrders
            // 
            dataGridAllOrders.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridAllOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAllOrders.Columns.AddRange(new DataGridViewColumn[] { OrderId, CustomerName, OrderDate, RentDays, TotalPrice, RemainAmount, BetAttachment });
            dataGridAllOrders.Dock = DockStyle.Fill;
            dataGridAllOrders.Location = new Point(0, 137);
            dataGridAllOrders.Name = "dataGridAllOrders";
            dataGridAllOrders.RightToLeft = RightToLeft.Yes;
            dataGridAllOrders.RowTemplate.Height = 25;
            dataGridAllOrders.Size = new Size(1100, 563);
            dataGridAllOrders.TabIndex = 4;
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
            Size = new Size(1100, 700);
            ((System.ComponentModel.ISupportInitialize)numericOrderId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericReturnOrderNum).EndInit();
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
        private NumericUpDown numericReturnOrderNum;
        private NumericUpDown numericSearchOrderNum;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridAllOrders;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn RentDays;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn RemainAmount;
        private DataGridViewTextBoxColumn BetAttachment;
    }
}
