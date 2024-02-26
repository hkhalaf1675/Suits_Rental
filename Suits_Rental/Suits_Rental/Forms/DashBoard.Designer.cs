namespace HotelManagementSystem.forms
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            panelContainer = new Panel();
            panel2 = new Panel();
            PBMinmized = new PictureBox();
            PBCloseFromDash = new PictureBox();
            lblUCTitle = new Label();
            panel3 = new Panel();
            btnReports = new Button();
            panel1 = new Panel();
            pbLogout = new PictureBox();
            pbAdminProfile = new PictureBox();
            btnSuits = new Button();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnHome = new Button();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBMinmized).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCloseFromDash).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdminProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.BackColor = Color.White;
            panelContainer.Location = new Point(-1, 42);
            panelContainer.Margin = new Padding(0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1111, 626);
            panelContainer.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(73, 78, 82);
            panel2.Controls.Add(PBMinmized);
            panel2.Controls.Add(PBCloseFromDash);
            panel2.Controls.Add(lblUCTitle);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(-1, 1);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 40);
            panel2.TabIndex = 0;
            // 
            // PBMinmized
            // 
            PBMinmized.Dock = DockStyle.Left;
            PBMinmized.Image = (Image)resources.GetObject("PBMinmized.Image");
            PBMinmized.Location = new Point(41, 0);
            PBMinmized.Margin = new Padding(9);
            PBMinmized.Name = "PBMinmized";
            PBMinmized.Size = new Size(41, 40);
            PBMinmized.SizeMode = PictureBoxSizeMode.StretchImage;
            PBMinmized.TabIndex = 1;
            PBMinmized.TabStop = false;
            PBMinmized.Click += PBMinmized_Click;
            // 
            // PBCloseFromDash
            // 
            PBCloseFromDash.Dock = DockStyle.Left;
            PBCloseFromDash.Image = (Image)resources.GetObject("PBCloseFromDash.Image");
            PBCloseFromDash.Location = new Point(0, 0);
            PBCloseFromDash.Margin = new Padding(9);
            PBCloseFromDash.Name = "PBCloseFromDash";
            PBCloseFromDash.Size = new Size(41, 40);
            PBCloseFromDash.SizeMode = PictureBoxSizeMode.StretchImage;
            PBCloseFromDash.TabIndex = 0;
            PBCloseFromDash.TabStop = false;
            PBCloseFromDash.Click += pbLogout_Click;
            // 
            // lblUCTitle
            // 
            lblUCTitle.AutoSize = true;
            lblUCTitle.BackColor = Color.Transparent;
            lblUCTitle.FlatStyle = FlatStyle.Flat;
            lblUCTitle.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUCTitle.ForeColor = Color.White;
            lblUCTitle.Location = new Point(606, 3);
            lblUCTitle.Margin = new Padding(0);
            lblUCTitle.Name = "lblUCTitle";
            lblUCTitle.Size = new Size(69, 25);
            lblUCTitle.TabIndex = 0;
            lblUCTitle.Text = "الرئيسية";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnReports);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(btnSuits);
            panel3.Controls.Add(btnCustomers);
            panel3.Controls.Add(btnOrders);
            panel3.Controls.Add(btnHome);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(1110, 1);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 667);
            panel3.TabIndex = 8;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.White;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.CheckedBackColor = Color.FromArgb(234, 55, 6);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 55, 6);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 281);
            btnReports.Margin = new Padding(4, 35, 4, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(176, 44);
            btnReports.TabIndex = 19;
            btnReports.Text = "التقرير";
            btnReports.TextAlign = ContentAlignment.MiddleRight;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(173, 101, 49);
            panel1.Controls.Add(pbLogout);
            panel1.Controls.Add(pbAdminProfile);
            panel1.Location = new Point(176, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(42, 667);
            panel1.TabIndex = 0;
            // 
            // pbLogout
            // 
            pbLogout.Image = (Image)resources.GetObject("pbLogout.Image");
            pbLogout.Location = new Point(1, 0);
            pbLogout.Margin = new Padding(4, 3, 4, 3);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(40, 40);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 3;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // pbAdminProfile
            // 
            pbAdminProfile.Image = (Image)resources.GetObject("pbAdminProfile.Image");
            pbAdminProfile.Location = new Point(1, 55);
            pbAdminProfile.Margin = new Padding(4, 3, 4, 3);
            pbAdminProfile.Name = "pbAdminProfile";
            pbAdminProfile.Size = new Size(38, 39);
            pbAdminProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdminProfile.TabIndex = 2;
            pbAdminProfile.TabStop = false;
            pbAdminProfile.Click += pbAdminProfile_Click;
            // 
            // btnSuits
            // 
            btnSuits.BackColor = Color.White;
            btnSuits.FlatAppearance.BorderSize = 0;
            btnSuits.FlatAppearance.CheckedBackColor = Color.FromArgb(234, 55, 6);
            btnSuits.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 55, 6);
            btnSuits.FlatStyle = FlatStyle.Flat;
            btnSuits.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuits.Image = (Image)resources.GetObject("btnSuits.Image");
            btnSuits.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuits.Location = new Point(0, 228);
            btnSuits.Margin = new Padding(4, 35, 4, 3);
            btnSuits.Name = "btnSuits";
            btnSuits.Size = new Size(176, 44);
            btnSuits.TabIndex = 14;
            btnSuits.Text = "البدل";
            btnSuits.TextAlign = ContentAlignment.MiddleRight;
            btnSuits.UseVisualStyleBackColor = false;
            btnSuits.Click += btnSuits_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.White;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.CheckedBackColor = Color.FromArgb(234, 55, 6);
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 55, 6);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 128);
            btnCustomers.Margin = new Padding(4, 35, 4, 3);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(176, 44);
            btnCustomers.TabIndex = 13;
            btnCustomers.Text = "العملاء";
            btnCustomers.TextAlign = ContentAlignment.MiddleRight;
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.White;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatAppearance.CheckedBackColor = Color.FromArgb(234, 55, 6);
            btnOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 55, 6);
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 179);
            btnOrders.Margin = new Padding(0);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(176, 44);
            btnOrders.TabIndex = 10;
            btnOrders.Text = "الحجوزات";
            btnOrders.TextAlign = ContentAlignment.MiddleRight;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHome.BackColor = Color.White;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.CheckedBackColor = Color.FromArgb(234, 55, 6);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 55, 6);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 78);
            btnHome.Margin = new Padding(4, 35, 4, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(176, 45);
            btnHome.TabIndex = 9;
            btnHome.Text = "الرئيسية";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 667);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashBoard";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += DashBoard_FormClosed;
            Load += DashBoard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBMinmized).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCloseFromDash).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdminProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUCTitle;
        private System.Windows.Forms.PictureBox PBCloseFromDash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.PictureBox pbAdminProfile;
        private System.Windows.Forms.Button btnSuits;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PBMinmized;
    }
}