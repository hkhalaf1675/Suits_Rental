using Suits_Rental.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void GetAllAdminsData()
        {
            var admins = _dbContext.Users.ToList();
            foreach (var admin in admins)
            {
                dgvAdmins.Rows.Add(admin.Id, admin.Name, admin.UserName, admin.Role);
            }
        }
    }
}
