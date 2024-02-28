namespace Suits_Rental.UserControls
{
    partial class Reports
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
            panelHead = new Panel();
            panelInfoSection = new Panel();
            lblTotalRemain = new Label();
            lblTotalIncome = new Label();
            lbltotalRemainText = new Label();
            label3 = new Label();
            panelSearchSection = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnGetAll = new Button();
            btnSearch = new Button();
            dateTimeEnd = new DateTimePicker();
            dateTimeStart = new DateTimePicker();
            panelContent = new Panel();
            dataGridReportData = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            RentDays = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            RemainAmount = new DataGridViewTextBoxColumn();
            panelHead.SuspendLayout();
            panelInfoSection.SuspendLayout();
            panelSearchSection.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReportData).BeginInit();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.Controls.Add(panelInfoSection);
            panelHead.Controls.Add(panelSearchSection);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(930, 122);
            panelHead.TabIndex = 0;
            // 
            // panelInfoSection
            // 
            panelInfoSection.Controls.Add(lblTotalRemain);
            panelInfoSection.Controls.Add(lblTotalIncome);
            panelInfoSection.Controls.Add(lbltotalRemainText);
            panelInfoSection.Controls.Add(label3);
            panelInfoSection.Dock = DockStyle.Right;
            panelInfoSection.Location = new Point(36, 0);
            panelInfoSection.Name = "panelInfoSection";
            panelInfoSection.Size = new Size(356, 122);
            panelInfoSection.TabIndex = 4;
            // 
            // lblTotalRemain
            // 
            lblTotalRemain.ForeColor = Color.Maroon;
            lblTotalRemain.Location = new Point(3, 68);
            lblTotalRemain.Name = "lblTotalRemain";
            lblTotalRemain.Size = new Size(182, 37);
            lblTotalRemain.TabIndex = 3;
            lblTotalRemain.Text = "0.0";
            lblTotalRemain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.ForeColor = Color.Green;
            lblTotalIncome.Location = new Point(202, 68);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(148, 37);
            lblTotalIncome.TabIndex = 4;
            lblTotalIncome.Text = "0.0";
            lblTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltotalRemainText
            // 
            lbltotalRemainText.ForeColor = Color.Maroon;
            lbltotalRemainText.Location = new Point(6, 18);
            lbltotalRemainText.Name = "lbltotalRemainText";
            lbltotalRemainText.Size = new Size(182, 37);
            lbltotalRemainText.TabIndex = 5;
            lbltotalRemainText.Text = "المبالغ المتبقية";
            lbltotalRemainText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.ForeColor = Color.Green;
            label3.Location = new Point(205, 18);
            label3.Name = "label3";
            label3.Size = new Size(148, 37);
            label3.TabIndex = 6;
            label3.Text = "الدخل الكلي";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSearchSection
            // 
            panelSearchSection.Controls.Add(label2);
            panelSearchSection.Controls.Add(label1);
            panelSearchSection.Controls.Add(btnGetAll);
            panelSearchSection.Controls.Add(btnSearch);
            panelSearchSection.Controls.Add(dateTimeEnd);
            panelSearchSection.Controls.Add(dateTimeStart);
            panelSearchSection.Dock = DockStyle.Right;
            panelSearchSection.Location = new Point(392, 0);
            panelSearchSection.Name = "panelSearchSection";
            panelSearchSection.Size = new Size(538, 122);
            panelSearchSection.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 68);
            label2.Name = "label2";
            label2.Size = new Size(38, 37);
            label2.TabIndex = 7;
            label2.Text = "إلي";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(443, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 37);
            label1.TabIndex = 8;
            label1.Text = "من";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGetAll
            // 
            btnGetAll.FlatStyle = FlatStyle.Flat;
            btnGetAll.ForeColor = Color.Teal;
            btnGetAll.Location = new Point(56, 64);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(152, 44);
            btnGetAll.TabIndex = 5;
            btnGetAll.Text = "عرض الكل";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Teal;
            btnSearch.Location = new Point(56, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 44);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(214, 64);
            dateTimeEnd.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(223, 44);
            dateTimeEnd.TabIndex = 3;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Location = new Point(214, 14);
            dateTimeStart.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(223, 44);
            dateTimeStart.TabIndex = 4;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dataGridReportData);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 122);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(930, 468);
            panelContent.TabIndex = 1;
            // 
            // dataGridReportData
            // 
            dataGridReportData.AllowUserToAddRows = false;
            dataGridReportData.AllowUserToDeleteRows = false;
            dataGridReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReportData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridReportData.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReportData.Columns.AddRange(new DataGridViewColumn[] { OrderId, CustomerName, OrderDate, RentDays, TotalPrice, RemainAmount });
            dataGridReportData.Dock = DockStyle.Fill;
            dataGridReportData.Location = new Point(0, 0);
            dataGridReportData.Name = "dataGridReportData";
            dataGridReportData.RightToLeft = RightToLeft.Yes;
            dataGridReportData.RowHeadersVisible = false;
            dataGridReportData.RowTemplate.Height = 25;
            dataGridReportData.Size = new Size(930, 468);
            dataGridReportData.TabIndex = 5;
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
            // Reports
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelHead);
            Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Reports";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(930, 590);
            Load += Reports_Load;
            panelHead.ResumeLayout(false);
            panelInfoSection.ResumeLayout(false);
            panelSearchSection.ResumeLayout(false);
            panelSearchSection.PerformLayout();
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridReportData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Panel panelContent;
        private DataGridView dataGridReportData;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn RentDays;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn RemainAmount;
        private Panel panelInfoSection;
        private Label lblTotalRemain;
        private Label lblTotalIncome;
        private Label lbltotalRemainText;
        private Label label3;
        private Panel panelSearchSection;
        private Label label2;
        private Label label1;
        private Button btnGetAll;
        private Button btnSearch;
        private DateTimePicker dateTimeEnd;
        private DateTimePicker dateTimeStart;
    }
}
