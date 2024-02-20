namespace Suits_Rental.Forms
{
    partial class SuitsForm
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
            label1 = new Label();
            lblAvailableSuits = new Label();
            label2 = new Label();
            lblOutsideSuits = new Label();
            btnAddNew = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(220, 50, 44);
            label1.Location = new Point(665, 25);
            label1.Name = "label1";
            label1.Size = new Size(208, 42);
            label1.TabIndex = 0;
            label1.Text = "عدد البدلات الموجودة";
            // 
            // lblAvailableSuits
            // 
            lblAvailableSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAvailableSuits.AutoSize = true;
            lblAvailableSuits.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailableSuits.ForeColor = Color.Black;
            lblAvailableSuits.Location = new Point(616, 25);
            lblAvailableSuits.Name = "lblAvailableSuits";
            lblAvailableSuits.Size = new Size(44, 42);
            lblAvailableSuits.TabIndex = 0;
            lblAvailableSuits.Text = "24";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(220, 50, 44);
            label2.Location = new Point(385, 25);
            label2.Name = "label2";
            label2.Size = new Size(198, 42);
            label2.TabIndex = 0;
            label2.Text = "عدد البدلات الخارجة";
            // 
            // lblOutsideSuits
            // 
            lblOutsideSuits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOutsideSuits.AutoSize = true;
            lblOutsideSuits.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutsideSuits.ForeColor = Color.Black;
            lblOutsideSuits.Location = new Point(347, 25);
            lblOutsideSuits.Name = "lblOutsideSuits";
            lblOutsideSuits.Size = new Size(31, 42);
            lblOutsideSuits.TabIndex = 0;
            lblOutsideSuits.Text = "0";
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.BackColor = Color.White;
            btnAddNew.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arabic Typesetting", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddNew.ForeColor = Color.FromArgb(33, 150, 243);
            btnAddNew.Location = new Point(66, 23);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(249, 47);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "إضافة بدلة";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // SuitsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 510);
            Controls.Add(btnAddNew);
            Controls.Add(lblOutsideSuits);
            Controls.Add(lblAvailableSuits);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuitsForm";
            Text = "SuitsForm";
            Load += SuitsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAvailableSuits;
        private Label label2;
        private Label lblOutsideSuits;
        private Button btnAddNew;
    }
}