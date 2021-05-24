using EasyBilling.BLL.Application;
using EasyBilling.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyBilling
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            //AppManager.LaunchApplication();
            lblLoggedInUser.Text = frmLogin.loggedInUser;
        }

        private void frmAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            //AppManager.ConnectionManager.Close();
        }

        private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories categories = new frmCategories();
            categories.Show();
         }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts product = new frmProducts();
            product.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDealerAndCustomer dealerAndCustomer = new frmDealerAndCustomer();
            dealerAndCustomer.Show();
        }
    }
}
