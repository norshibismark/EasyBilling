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
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        //set public static method to specify whether the form is purchase or sales
        public static string transactionType;
        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedInUser;
        }

        private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "PURCHASE";
            frmPurchaseAndSales purchase = new frmPurchaseAndSales();
            purchase.Show();
        }
         
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "SALES";
            frmPurchaseAndSales purchase = new frmPurchaseAndSales(); 
            purchase.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDealerAndCustomer dealerAndCustomer = new frmDealerAndCustomer();
            dealerAndCustomer.Show();
        }
    }
}
