using Suits_Rental.Contexts;
using Suits_Rental.Core;

namespace Suits_Rental.Forms
{
    public partial class UpdateUser : Form
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomDialogResult CustomResult { get; private set; }
        public int UserId;
        public UpdateUser(int userId)
        {
            _dbContext = new ApplicationDbContext();
            CustomResult = CustomDialogResult.Cancel;
            InitializeComponent();
            UserId = userId;
            GetUserData(userId);
        }
        private void GetUserData(int userId)
        {
            var user = _dbContext.Users.First(u => u.Id == userId);
            txtName.Text = user.Name;
            txtUserName.Text = user.UserName;
            lblCurrentUserPermission.Text = user.Role;
        }
        private void btnCloseAddUserForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnUpdateUser_Click(object sender, EventArgs e)
        {
            var user = _dbContext.Users.First(u => u.Id == UserId);
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUserName.Text) 
                || cmbUserPermission.SelectedIndex == -1)
            {
                MessageBox.Show("!برجاء إدخال قيم صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.Name = txtName.Text;
                user.UserName = txtUserName.Text;
                user.Role = cmbUserPermission.Text;
                if (await _dbContext.SaveChangesAsync() > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("تمت تعديل بيانات المستخدم بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK || dialogResult==DialogResult.Cancel)
                    {
                        CustomResult = CustomDialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}
