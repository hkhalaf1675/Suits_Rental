using Suits_Rental.Contexts;
using Suits_Rental.Core;
using Suits_Rental.Models;
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
    public partial class AddUser : Form
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomDialogResult CustomResult { get; private set; }
        public AddUser()
        {
            _dbContext = new ApplicationDbContext();
            CustomResult = CustomDialogResult.Cancel;
            InitializeComponent();
        }

        private void btnCloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveNewUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) || cmbUserPermission.SelectedIndex == -1)
            {
                MessageBox.Show("!برجاء إدخال قيم صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new();
                user.Name = txtName.Text;
                user.Password = txtPassword.Text;
                user.UserName = txtUserName.Text;
                user.Role = cmbUserPermission.Text;
                _dbContext.Users.Add(user);
                if (_dbContext.SaveChanges() > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("تمت إضافة مستخدم بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        CustomResult = CustomDialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}
