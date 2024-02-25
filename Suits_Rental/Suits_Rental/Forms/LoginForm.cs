using HotelManagementSystem.forms;
using Microsoft.Data.SqlClient;
using Suits_Rental.Contexts;
using Suits_Rental.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suits_Rental.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ApplicationDbContext _dbContext;
        public LoginForm()
        {
            _dbContext = new ApplicationDbContext();
            InitializeComponent();
            lblErrorMsg.Visible = false;
        }

        private void btnCloseLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnHideLoginForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Private Methods
        // Hashing function using SHA-256 with salt
        //private byte[] HashPassword(string password, byte[] salt)
        //{
        //    using (var sha256 = SHA256.Create())
        //    {
        //        // Combine password and salt
        //        byte[] combinedBytes = Encoding.UTF8.GetBytes(password).Concat(salt).ToArray();

        //        // Compute hash
        //        return sha256.ComputeHash(combinedBytes);
        //    }
        //}
        // Generate a random salt
        //private byte[] GenerateSalt()
        //{
        //    byte[] salt = new byte[16]; // 128 bits
        //    using (var rng = new RNGCryptoServiceProvider())
        //    {
        //        rng.GetBytes(salt);
        //    }
        //    return salt;
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UserName == txtUsername.Text && u.Password == txtPassword.Text);
            if (user == null || string.IsNullOrEmpty(txtUsername.Text)|| string.IsNullOrEmpty(txtPassword.Text))
            {
                lblErrorMsg.Visible = true;
                //txtPassword.Clear();
                //txtUsername.Clear();
                MessageBox.Show("لا يمكن تسجيل الدخول تاكد من اسم المستخدم وكلمة المرور ثم حاول مره اخري", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //holds the current admin infromation
            CurrentUser.Name = user!.Name!;
            CurrentUser.Txtusername = user!.UserName!;
            CurrentUser.DateIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            CurrentUser.Role = user!.Role!;

            DashBoard dashBoard = new DashBoard();
            this.Hide();
            //hold the previus form 
            FormState.PreviousPage = this;
            txtPassword.Clear();
            txtUsername.Clear();
            //open dashboard

            dashBoard.Show();
        }
    }
}
