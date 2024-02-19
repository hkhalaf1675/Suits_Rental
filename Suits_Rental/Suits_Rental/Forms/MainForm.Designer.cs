namespace Suits_Rental.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            btnMinmize = new PictureBox();
            btnMaxmize = new PictureBox();
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelContent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinmize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaxmize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 78, 82);
            panel1.Controls.Add(btnMinmize);
            panel1.Controls.Add(btnMaxmize);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 94);
            panel1.TabIndex = 0;
            // 
            // btnMinmize
            // 
            btnMinmize.Dock = DockStyle.Left;
            btnMinmize.Image = (Image)resources.GetObject("btnMinmize.Image");
            btnMinmize.Location = new Point(96, 0);
            btnMinmize.Margin = new Padding(0);
            btnMinmize.Name = "btnMinmize";
            btnMinmize.Size = new Size(48, 35);
            btnMinmize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinmize.TabIndex = 3;
            btnMinmize.TabStop = false;
            btnMinmize.Click += btnMinmize_Click;
            // 
            // btnMaxmize
            // 
            btnMaxmize.Dock = DockStyle.Left;
            btnMaxmize.Image = (Image)resources.GetObject("btnMaxmize.Image");
            btnMaxmize.Location = new Point(48, 0);
            btnMaxmize.Margin = new Padding(0);
            btnMaxmize.Name = "btnMaxmize";
            btnMaxmize.Size = new Size(48, 35);
            btnMaxmize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaxmize.TabIndex = 2;
            btnMaxmize.TabStop = false;
            btnMaxmize.Click += btnMaxmize_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Left;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(0, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 35);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1072, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(73, 78, 82);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(862, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 514);
            panel2.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 94);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(862, 514);
            panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1072, 608);
            Controls.Add(panelContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinmize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaxmize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox btnClose;
        private PictureBox btnMinmize;
        private PictureBox btnMaxmize;
        private Panel panelContent;
    }
}