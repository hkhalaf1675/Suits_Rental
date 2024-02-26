namespace Suits_Rental.UserControls
{
    partial class MainScreen
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
            panelSuitsInfoSection = new Panel();
            lblOutsideSuits = new Label();
            lblAvailableSuits = new Label();
            label2 = new Label();
            label1 = new Label();
            panelSuitsButtonsSection = new Panel();
            numericSuitId = new NumericUpDown();
            btnSuitSearch = new Button();
            btnAddNewSuit = new Button();
            panelOrderSection = new Panel();
            numericOrderId = new NumericUpDown();
            btnReturnSuit = new Button();
            btnAddOrder = new Button();
            panelContent = new Panel();
            dataGridSuits = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            SuitSize = new DataGridViewTextBoxColumn();
            RentalPrice = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            AttachmentsCount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panelHead.SuspendLayout();
            panelSuitsInfoSection.SuspendLayout();
            panelSuitsButtonsSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSuitId).BeginInit();
            panelOrderSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericOrderId).BeginInit();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSuits).BeginInit();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.Controls.Add(panelSuitsInfoSection);
            panelHead.Controls.Add(panelSuitsButtonsSection);
            panelHead.Controls.Add(panelOrderSection);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(930, 164);
            panelHead.TabIndex = 0;
            // 
            // panelSuitsInfoSection
            // 
            panelSuitsInfoSection.Controls.Add(lblOutsideSuits);
            panelSuitsInfoSection.Controls.Add(lblAvailableSuits);
            panelSuitsInfoSection.Controls.Add(label2);
            panelSuitsInfoSection.Controls.Add(label1);
            panelSuitsInfoSection.Dock = DockStyle.Right;
            panelSuitsInfoSection.Location = new Point(0, 0);
            panelSuitsInfoSection.Name = "panelSuitsInfoSection";
            panelSuitsInfoSection.Size = new Size(315, 164);
            panelSuitsInfoSection.TabIndex = 13;
            // 
            // lblOutsideSuits
            // 
            lblOutsideSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOutsideSuits.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutsideSuits.ForeColor = Color.Black;
            lblOutsideSuits.Location = new Point(21, 94);
            lblOutsideSuits.Name = "lblOutsideSuits";
            lblOutsideSuits.RightToLeft = RightToLeft.Yes;
            lblOutsideSuits.Size = new Size(58, 42);
            lblOutsideSuits.TabIndex = 11;
            lblOutsideSuits.Text = "0";
            lblOutsideSuits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvailableSuits
            // 
            lblAvailableSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAvailableSuits.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailableSuits.ForeColor = Color.Black;
            lblAvailableSuits.Location = new Point(21, 28);
            lblAvailableSuits.Name = "lblAvailableSuits";
            lblAvailableSuits.RightToLeft = RightToLeft.Yes;
            lblAvailableSuits.Size = new Size(58, 42);
            lblAvailableSuits.TabIndex = 12;
            lblAvailableSuits.Text = "24";
            lblAvailableSuits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(85, 94);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(208, 42);
            label2.TabIndex = 13;
            label2.Text = "عدد البدلات الخارجة";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(85, 28);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(208, 42);
            label1.TabIndex = 14;
            label1.Text = "عدد البدلات الموجودة";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSuitsButtonsSection
            // 
            panelSuitsButtonsSection.Controls.Add(numericSuitId);
            panelSuitsButtonsSection.Controls.Add(btnSuitSearch);
            panelSuitsButtonsSection.Controls.Add(btnAddNewSuit);
            panelSuitsButtonsSection.Dock = DockStyle.Right;
            panelSuitsButtonsSection.Location = new Point(315, 0);
            panelSuitsButtonsSection.Name = "panelSuitsButtonsSection";
            panelSuitsButtonsSection.Size = new Size(302, 164);
            panelSuitsButtonsSection.TabIndex = 12;
            // 
            // numericSuitId
            // 
            numericSuitId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericSuitId.BackColor = Color.Gainsboro;
            numericSuitId.BorderStyle = BorderStyle.None;
            numericSuitId.Location = new Point(196, 96);
            numericSuitId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericSuitId.Name = "numericSuitId";
            numericSuitId.RightToLeft = RightToLeft.Yes;
            numericSuitId.Size = new Size(85, 40);
            numericSuitId.TabIndex = 8;
            numericSuitId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSuitSearch
            // 
            btnSuitSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSuitSearch.BackColor = Color.White;
            btnSuitSearch.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnSuitSearch.FlatStyle = FlatStyle.Flat;
            btnSuitSearch.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuitSearch.ForeColor = Color.Teal;
            btnSuitSearch.Location = new Point(21, 93);
            btnSuitSearch.Name = "btnSuitSearch";
            btnSuitSearch.Size = new Size(169, 47);
            btnSuitSearch.TabIndex = 9;
            btnSuitSearch.Text = "بحث";
            btnSuitSearch.UseVisualStyleBackColor = false;
            btnSuitSearch.Click += btnSuitSearch_Click;
            // 
            // btnAddNewSuit
            // 
            btnAddNewSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewSuit.BackColor = Color.White;
            btnAddNewSuit.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnAddNewSuit.FlatStyle = FlatStyle.Flat;
            btnAddNewSuit.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewSuit.ForeColor = Color.Teal;
            btnAddNewSuit.Location = new Point(21, 25);
            btnAddNewSuit.Name = "btnAddNewSuit";
            btnAddNewSuit.Size = new Size(260, 47);
            btnAddNewSuit.TabIndex = 7;
            btnAddNewSuit.Text = "إضافة بدلة";
            btnAddNewSuit.UseVisualStyleBackColor = false;
            btnAddNewSuit.Click += btnAddNewSuit_Click;
            // 
            // panelOrderSection
            // 
            panelOrderSection.Controls.Add(numericOrderId);
            panelOrderSection.Controls.Add(btnReturnSuit);
            panelOrderSection.Controls.Add(btnAddOrder);
            panelOrderSection.Dock = DockStyle.Right;
            panelOrderSection.Location = new Point(617, 0);
            panelOrderSection.Name = "panelOrderSection";
            panelOrderSection.Size = new Size(313, 164);
            panelOrderSection.TabIndex = 11;
            // 
            // numericOrderId
            // 
            numericOrderId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericOrderId.BackColor = Color.Gainsboro;
            numericOrderId.BorderStyle = BorderStyle.None;
            numericOrderId.Location = new Point(201, 95);
            numericOrderId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericOrderId.Name = "numericOrderId";
            numericOrderId.RightToLeft = RightToLeft.Yes;
            numericOrderId.Size = new Size(85, 40);
            numericOrderId.TabIndex = 5;
            numericOrderId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnReturnSuit
            // 
            btnReturnSuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturnSuit.BackColor = Color.White;
            btnReturnSuit.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnReturnSuit.FlatStyle = FlatStyle.Flat;
            btnReturnSuit.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturnSuit.ForeColor = Color.Teal;
            btnReturnSuit.Location = new Point(26, 92);
            btnReturnSuit.Name = "btnReturnSuit";
            btnReturnSuit.Size = new Size(169, 47);
            btnReturnSuit.TabIndex = 6;
            btnReturnSuit.Text = "إرجاع بدلة";
            btnReturnSuit.UseVisualStyleBackColor = false;
            btnReturnSuit.Click += btnReturnSuit_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddOrder.BackColor = Color.White;
            btnAddOrder.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("Arabic Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddOrder.ForeColor = Color.Teal;
            btnAddOrder.Location = new Point(26, 26);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(260, 47);
            btnAddOrder.TabIndex = 4;
            btnAddOrder.Text = "إضافة أوردر";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dataGridSuits);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 164);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(930, 426);
            panelContent.TabIndex = 1;
            // 
            // dataGridSuits
            // 
            dataGridSuits.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridSuits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSuits.Columns.AddRange(new DataGridViewColumn[] { ID, SuitSize, RentalPrice, SalePrice, AttachmentsCount, Status });
            dataGridSuits.Dock = DockStyle.Fill;
            dataGridSuits.Location = new Point(0, 0);
            dataGridSuits.Name = "dataGridSuits";
            dataGridSuits.RightToLeft = RightToLeft.Yes;
            dataGridSuits.RowTemplate.Height = 25;
            dataGridSuits.Size = new Size(930, 426);
            dataGridSuits.TabIndex = 3;
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
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelHead);
            Font = new Font("Arabic Typesetting", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainScreen";
            Size = new Size(930, 590);
            Load += MainScreen_Load;
            panelHead.ResumeLayout(false);
            panelSuitsInfoSection.ResumeLayout(false);
            panelSuitsButtonsSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericSuitId).EndInit();
            panelOrderSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericOrderId).EndInit();
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridSuits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Panel panelContent;
        private DataGridView dataGridSuits;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SuitSize;
        private DataGridViewTextBoxColumn RentalPrice;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn AttachmentsCount;
        private DataGridViewTextBoxColumn Status;
        private Panel panelSuitsInfoSection;
        private Label lblOutsideSuits;
        private Label lblAvailableSuits;
        private Label label2;
        private Label label1;
        private Panel panelSuitsButtonsSection;
        private NumericUpDown numericSuitId;
        private Button btnSuitSearch;
        private Button btnAddNewSuit;
        private Panel panelOrderSection;
        private NumericUpDown numericOrderId;
        private Button btnReturnSuit;
        private Button btnAddOrder;
    }
}
