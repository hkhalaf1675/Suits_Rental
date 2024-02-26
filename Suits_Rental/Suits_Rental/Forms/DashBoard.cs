
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

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders ucOrders = new Orders();
            addUserControl(ucOrders);
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

        //private void pbLogout_Click_1(object sender, EventArgs e)
        //{
        //    DialogResult result = System.Windows.Forms.MessageBox.Show("هل بالفعل تريد تسجيل الخروج", "تأكيد الخروج", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes)
        //    {

        //        CoreFunctions.SetLogOutAdmin();
        //        FormState.PreviousPage.Show();
        //        this.Close();
        //    }
        //}

        //private void btnHome_Click(object sender, EventArgs e)
        //{

        //    UC_Home uC_Home = new UC_Home();
        //    addUserControl(uC_Home);
        //    lblUCTitle.Text = btnHome.Text;
        //}

        //private void btnCustomers_Click(object sender, EventArgs e)
        //{

        //    UC_Customer uC_Customers = new UC_Customer();
        //    addUserControl(uC_Customers);
        //    lblUCTitle.Text = btnCustomers.Text;
        //}

        //private void btnbook_Click(object sender, EventArgs e)
        //{

        //    UCBooking uCBooking = new UCBooking();
        //    addUserControl(uCBooking);
        //    lblUCTitle.Text = btnbook.Text;
        //}

        //private void btnRestaurant_Click(object sender, EventArgs e)
        //{

        //    UCRestaurant uCRestaurant = new UCRestaurant();
        //    addUserControl(uCRestaurant);
        //    lblUCTitle.Text = btnRestaurant.Text;
        //}

        //private void btnMealOreder_Click(object sender, EventArgs e)
        //{

        //    UCMealOrder uCMealOrder = new UCMealOrder();
        //    addUserControl(uCMealOrder);
        //    lblUCTitle.Text = btnMealOreder.Text;
        //}

        //private void btnService_Click(object sender, EventArgs e)
        //{

        //    UCServicesOrdered uCServices = new UCServicesOrdered();
        //    addUserControl(uCServices);
        //    lblUCTitle.Text = btnService.Text;

        //}

        //private void btnRoom_Click(object sender, EventArgs e)
        //{

        //    UC_Room uC_Room = new UC_Room();
        //    addUserControl(uC_Room);
        //    lblUCTitle.Text = btnRoom.Text;
        //}

        //private void btnActicity_Click(object sender, EventArgs e)
        //{

        //    UC_ActivitiesEmploees uC_AmetiesRoom1 = new UC_ActivitiesEmploees();
        //    addUserControl(uC_AmetiesRoom1);
        //    lblUCTitle.Text = btnActicity.Text;
        //}

        //private void btnEmployee_Click(object sender, EventArgs e)
        //{

        //    UCEmployee uCEmployee = new UCEmployee();
        //    addUserControl(uCEmployee);
        //    lblUCTitle.Text = btnEmployee.Text;
        //}

        //private void btnExpenses_Click(object sender, EventArgs e)
        //{

        //    UC_Expenses uC_Expenses = new UC_Expenses();
        //    addUserControl(uC_Expenses);
        //    lblUCTitle.Text = btnExpenses.Text;
        //}

        //private void btnReport_Click(object sender, EventArgs e)
        //{
        //    UCReports uCReports = new UCReports();
        //    addUserControl(uCReports);
        //    lblUCTitle.Text = btnReport.Text;

        //}

        //private void PBCloseFromDash_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = System.Windows.Forms.MessageBox.Show("هل بالفعل تريد تسجيل الخروج", "تأكيد الخروج", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes)
        //    {

        //        CoreFunctions.SetLogOutAdmin();
        //        FormState.PreviousPage.Show();
        //        this.Close();
        //    }
        //}

        //private void btnIncomes_Click(object sender, EventArgs e)
        //{
        //    IncomReport incomReport = new IncomReport();
        //    addUserControl(incomReport);
        //    lblUCTitle.Text = btnIncomes.Text;
        //}

        //private void PBMinmized_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        //private void btnEmployeeAbs_Click(object sender, EventArgs e)
        //{
        //    UCEmployeeAbsence employeeAbsence = new UCEmployeeAbsence();
        //    addUserControl(employeeAbsence);
        //    lblUCTitle.Text = btnEmployeeAbs.Text;
        //}
    }
}
