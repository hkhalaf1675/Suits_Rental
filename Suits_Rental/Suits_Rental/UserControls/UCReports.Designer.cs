namespace Suits_Rental.UserControls
{
    partial class UCReports
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
            tlpContainer = new TableLayoutPanel();
            dataGridReportData = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            RentDays = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            RemainAmount = new DataGridViewTextBoxColumn();
            tlpHead = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            dateTimeStart = new DateTimePicker();
            btnSearch = new Button();
            btnGetAll = new Button();
            dateTimeEnd = new DateTimePicker();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblTotalIncome = new Label();
            label3 = new Label();
            lbltotalRemainText = new Label();
            lblTotalRemain = new Label();
            tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReportData).BeginInit();
            tlpHead.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 1;
            tlpContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContainer.Controls.Add(dataGridReportData, 0, 1);
            tlpContainer.Controls.Add(tlpHead, 0, 0);
            tlpContainer.Dock = DockStyle.Fill;
            tlpContainer.ImeMode = ImeMode.NoControl;
            tlpContainer.Location = new Point(0, 0);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RightToLeft = RightToLeft.Yes;
            tlpContainer.RowCount = 2;
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpContainer.Size = new Size(866, 591);
            tlpContainer.TabIndex = 0;
            // 
            // dataGridReportData
            // 
            dataGridReportData.AllowUserToAddRows = false;
            dataGridReportData.AllowUserToDeleteRows = false;
            dataGridReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReportData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridReportData.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridReportData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReportData.Columns.AddRange(new DataGridViewColumn[] { OrderId, CustomerName, OrderDate, RentDays, TotalPrice, RemainAmount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arabic Typesetting", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridReportData.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridReportData.Dock = DockStyle.Fill;
            dataGridReportData.Location = new Point(3, 121);
            dataGridReportData.Name = "dataGridReportData";
            dataGridReportData.RightToLeft = RightToLeft.Yes;
            dataGridReportData.RowHeadersVisible = false;
            dataGridReportData.RowTemplate.Height = 25;
            dataGridReportData.Size = new Size(860, 467);
            dataGridReportData.TabIndex = 6;
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
            // tlpHead
            // 
            tlpHead.ColumnCount = 2;
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.34884F));
            tlpHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.65116F));
            tlpHead.Controls.Add(tableLayoutPanel3, 0, 0);
            tlpHead.Controls.Add(tableLayoutPanel4, 1, 0);
            tlpHead.Dock = DockStyle.Fill;
            tlpHead.Location = new Point(3, 3);
            tlpHead.Name = "tlpHead";
            tlpHead.RowCount = 1;
            tlpHead.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpHead.Size = new Size(860, 112);
            tlpHead.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.6608467F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.33915F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(dateTimeStart, 1, 0);
            tableLayoutPanel3.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel3.Controls.Add(btnGetAll, 2, 1);
            tableLayoutPanel3.Controls.Add(dateTimeEnd, 1, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(344, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(513, 106);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(373, 53);
            label2.Name = "label2";
            label2.Size = new Size(29, 27);
            label2.TabIndex = 10;
            label2.Text = "إلي";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeStart.Location = new Point(115, 3);
            dateTimeStart.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(252, 29);
            dateTimeStart.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Teal;
            btnSearch.Location = new Point(3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 44);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnGetAll
            // 
            btnGetAll.FlatStyle = FlatStyle.Flat;
            btnGetAll.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetAll.ForeColor = Color.Teal;
            btnGetAll.Location = new Point(3, 56);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(106, 45);
            btnGetAll.TabIndex = 14;
            btnGetAll.Text = "عرض الكل";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Font = new Font("Arabic Typesetting", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeEnd.Location = new Point(115, 56);
            dateTimeEnd.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(252, 29);
            dateTimeEnd.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(373, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 27);
            label1.TabIndex = 9;
            label1.Text = "من";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.9253731F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.07462F));
            tableLayoutPanel4.Controls.Add(lblTotalIncome, 0, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(lbltotalRemainText, 1, 0);
            tableLayoutPanel4.Controls.Add(lblTotalRemain, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(335, 106);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalIncome.ForeColor = Color.Green;
            lblTotalIncome.Location = new Point(221, 53);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(111, 37);
            lblTotalIncome.TabIndex = 8;
            lblTotalIncome.Text = "0.0";
            lblTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(221, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 37);
            label3.TabIndex = 7;
            label3.Text = "الدخل الكلي";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltotalRemainText
            // 
            lbltotalRemainText.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotalRemainText.ForeColor = Color.Maroon;
            lbltotalRemainText.Location = new Point(53, 0);
            lbltotalRemainText.Name = "lbltotalRemainText";
            lbltotalRemainText.Size = new Size(162, 37);
            lbltotalRemainText.TabIndex = 9;
            lbltotalRemainText.Text = "المبالغ المتبقية";
            lbltotalRemainText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalRemain
            // 
            lblTotalRemain.Font = new Font("Arabic Typesetting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalRemain.ForeColor = Color.Maroon;
            lblTotalRemain.Location = new Point(53, 53);
            lblTotalRemain.Name = "lblTotalRemain";
            lblTotalRemain.Size = new Size(162, 37);
            lblTotalRemain.TabIndex = 10;
            lblTotalRemain.Text = "0.0";
            lblTotalRemain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCReports
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpContainer);
            Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 7, 5, 7);
            Name = "UCReports";
            Size = new Size(866, 591);
            Load += UCReports_Load;
            tlpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridReportData).EndInit();
            tlpHead.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpContainer;
        private TableLayoutPanel tlpHead;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimeStart;
        private DateTimePicker dateTimeEnd;
        private Button btnSearch;
        private Button btnGetAll;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label lblTotalIncome;
        private Label lbltotalRemainText;
        private Label lblTotalRemain;
        private DataGridView dataGridReportData;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn RentDays;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn RemainAmount;
    }
}
