
using Suits_Rental.Core;
using Suits_Rental.UserControls;

namespace HotelManagementSystem.forms
{
    public partial class DashBoard : Form
    {
        private System.Windows.Forms.Timer timer;

        public DashBoard()
        {
            InitializeComponent();
            //UC_Home uC_Home = new UC_Home();
            //addUserControl(uC_Home);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;

            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Fetch live data and update UI
            string liveData = FetchLiveData();
            UpdateUI(liveData);
        }
        private string FetchLiveData()
        {
            // Code to fetch live data from a source
            // For demonstration purposes, returning a dummy value
            return DateTime.Now.ToString();
        }
        private void UpdateUI(string liveData)
        {
            // Update UI controls with live data
            lblLiveWatch.Text = liveData;
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
            //this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            //this.Left = 0;
            //this.Top = 0;

            MakeOrder ucMakeOrder = new MakeOrder();
            addUserControl(ucMakeOrder);
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
            UCOrders ucOrder = new UCOrders();
            addUserControl(ucOrder);
            lblUCTitle.Text = "الحجوزات";
        }

        private void btnSuits_Click(object sender, EventArgs e)
        {
            UCSuits ucSuits = new UCSuits();
            addUserControl(ucSuits);
            lblUCTitle.Text = "البدل";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UCReports ucReports = new UCReports();
            addUserControl(ucReports);
            lblUCTitle.Text = "التقارير";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MakeOrder ucMakeOrder = new MakeOrder();
            addUserControl(ucMakeOrder);
            lblUCTitle.Text = "الرئيسية";
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customser customser = new Customser();
            addUserControl(customser);
            lblUCTitle.Text = "العملاء";
        }
    }
}
