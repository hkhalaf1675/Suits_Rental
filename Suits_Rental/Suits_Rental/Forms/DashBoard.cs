
using Suits_Rental.Core;
using Suits_Rental.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace HotelManagementSystem.forms
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            //UC_Home uC_Home = new UC_Home();
            //addUserControl(uC_Home);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormState.PreviousPage.Show();
            // this.Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = 0;
            this.Top = 0;

            MainScreen ucMainScreen = new MainScreen();
            addUserControl(ucMainScreen);
            lblUCTitle.Text = "الرئيسية";
        }



        private void pbLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show("هل بالفعل تريد تسجيل الخروج", "تأكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
                FormState.PreviousPage.Show();
            }
        }

        private void pbAdminProfile_Click(object sender, EventArgs e)
        {
            AdminUserControl uCAdmins = new AdminUserControl();
            addUserControl(uCAdmins);
            lblUCTitle.Text = "المستخدمين";
        }

        private void PBMinmized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders ucOrder = new Orders();
            addUserControl(ucOrder);
            lblUCTitle.Text = "الحجوزات";
        }

        private void btnSuits_Click(object sender, EventArgs e)
        {
            Suits ucSuits = new Suits();
            addUserControl(ucSuits);
            lblUCTitle.Text = "البدل";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports ucReports = new Reports();
            addUserControl(ucReports);
            lblUCTitle.Text = "التقارير";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainScreen ucMainScreen = new MainScreen();
            addUserControl(ucMainScreen);
            lblUCTitle.Text = "الرئيسية";
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customser ucCustomers = new Customser();
            addUserControl(ucCustomers);
            lblUCTitle.Text = "العملاء";
        }
    }
}
