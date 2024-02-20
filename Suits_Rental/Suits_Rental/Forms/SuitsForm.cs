using Suits_Rental.Contexts;
using Suits_Rental.IRepositories;
using Suits_Rental.Repositories;
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
    public partial class SuitsForm : Form
    {
        private readonly ISuitsRepository suitsRepository;

        public SuitsForm()
        {
            InitializeComponent();
            this.suitsRepository = new SuitsRepository();
        }

        private void SuitsForm_Load(object sender, EventArgs e)
        {
            this.lblAvailableSuits.Text = suitsRepository.GetAvailableSuits().ToString();
            this.lblOutsideSuits.Text = suitsRepository.GetOutsideSuits().ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ManageSuitForm manageSuitForm = new ManageSuitForm();
            manageSuitForm.ShowDialog();
        }
    }
}
