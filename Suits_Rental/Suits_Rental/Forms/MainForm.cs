using Suits_Rental.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suits_Rental.Forms
{
    public partial class MainForm : Form
    {
        int _FormSuits = 0;
        UserControl _ActiveForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(UserControl childForm, object btnSender)
        {
            _ActiveForm = childForm;
            childForm.Dock = DockStyle.Fill;

            this.panelContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
                rect.Location = new Point(0, 0);
                this.MaximizedBounds = rect;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinmize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSuits_Click(object sender, EventArgs e)
        {
            if(_FormSuits == 0)
            {
                _FormSuits = 1;
                OpenChildForm(new Orders(), sender);
            }
        }
    }
}
