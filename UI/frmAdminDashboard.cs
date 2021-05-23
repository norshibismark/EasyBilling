﻿using EasyBilling.BLL.Application;
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
            AppManager.LaunchApplication();
        }

        private void frmAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppManager.ConnectionManager.Close();
        }
    }
}
