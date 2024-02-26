using Microsoft.EntityFrameworkCore;
using Suits_Rental.Contexts;
using Suits_Rental.Core;
using Suits_Rental.Forms;
using System.Diagnostics;
using System.Windows.Forms;


namespace Suits_Rental.UserControls
{
    public partial class AdminUserControl : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        public AdminUserControl()
        {
            _dbContext = new ApplicationDbContext();
            InitializeComponent();
            GetAllAdminsData();
        }

        private async void GetAllAdminsData()
        {
            dgvAdmins.Rows.Clear();
            var admins = await _dbContext.Users.ToListAsync();
            foreach (var admin in admins)
            {
                dgvAdmins.Rows.Add(admin.Id, admin.Name, admin.UserName, admin.Role);
            }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            CustomDialogResult customDialogResult = addUser.CustomResult;
            if (customDialogResult == CustomDialogResult.OK)
                GetAllAdminsData();
        }

        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if you want to delete user
            if (e.ColumnIndex == dgvAdmins.Columns["deleteAdmin"].Index && e.RowIndex >= 0)
            {
                var userName = dgvAdmins.Rows[e.RowIndex].Cells[1].Value.ToString();
                // Handle button click here
                DialogResult dialogResult =  MessageBox.Show(userName + " : هل بالفعل تريد حذف هذا المستخدم" ,"!تحذير",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.OK)
                {
                    int userId = Convert.ToInt32(dgvAdmins.Rows[e.RowIndex].Cells[0].Value);
                    var user = _dbContext.Users.FirstOrDefault(u=>u.Id==userId);
                    if (user != null)
                    {
                        _dbContext.Users.Remove(user);
                        _dbContext.SaveChanges();
                        //refresh Data Grid View With new updated data
                        GetAllAdminsData();
                    }
                }
            }

            //Check if you want to update user

            if (e.ColumnIndex == dgvAdmins.Columns["editAdmin"].Index && e.RowIndex >= 0)
            {
                int userId = Convert.ToInt32(dgvAdmins.Rows[e.RowIndex].Cells[0].Value);
                UpdateUser updateUser = new UpdateUser(userId);
                updateUser.ShowDialog();
                CustomDialogResult customDialogResult = updateUser.CustomResult;
                //refresh Data Grid View With updated data
                GetAllAdminsData();
            }
        }
    }
}
