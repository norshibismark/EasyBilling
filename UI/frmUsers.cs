using EasyBilling.BLL;
using EasyBilling.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyBilling.UI
{
    public partial class frmUsers : Form
    {
        UserBLL u = new UserBLL();
        UserDAL dal = new UserDAL();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidated()
        {
            if(String.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                MessageBox.Show("Enter First Name");
                txtFirstName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Enter Last Name");
                txtLastName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Enter Email");
                txtEmail.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Enter User Name");
                txtUserName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Enter Password");
                txtPassword.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtContact.Text.Trim()))
            {
                MessageBox.Show("Enter Contact");
                txtContact.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Enter Address");
                txtAddress.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(cmbgender.Text.Trim()))
            {
                MessageBox.Show("Enter Gender");
                cmbgender.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(cmbUserType.Text.Trim()))
            {
                MessageBox.Show("Enter User Type");
                cmbUserType.Focus();
                return false;
            }
            return true;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            txtUserId.Text = Common.ConvertToString(dal.getMaxUserId() + 1);
            loadUserDetailsInGrid();
        }

        private void clearAll()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbgender.Text = "";
            cmbUserType.Text = "";
            txtUserId.Text = Common.ConvertToString(dal.getMaxUserId() + 1);
            txtFirstName.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isValidated())
            {
                bool isSuccess = false;
                //getting data from ui
                u.id = Common.ConvertToInt(txtUserId.Text.Trim());
                u.first_name = txtFirstName.Text.Trim();
                u.last_name = txtLastName.Text.Trim();
                u.email = txtEmail.Text.Trim();
                u.username = txtUserName.Text.Trim();
                u.password = txtPassword.Text.Trim();
                u.contact = txtContact.Text.Trim();
                u.address = txtAddress.Text.Trim();
                u.gender = cmbgender.Text.Trim();
                u.user_type = cmbUserType.Text.Trim();
                u.added_date = DateTime.Now;
                u.added_by = 2;
                isSuccess = dal.insertAndUpdate(u);
                if (isSuccess)
                {
                    MessageBox.Show("Saved successfully");
                }
                else
                {
                    MessageBox.Show("Save failed");
                }
                clearAll();
                loadUserDetailsInGrid();
            }
        }

        private void loadUserDetailsInGrid()
        {
            try
            {
                DataTable dt = dal.Select();
                grdUsers.DataSource = dt;
                grdUsers.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserId.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["id"].Value);
            txtFirstName.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["first_name"].Value);
            txtLastName.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["last_name"].Value);
            txtEmail.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["email"].Value);
            txtUserName.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["username"].Value);
            txtPassword.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["password"].Value);
            txtContact.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["contact"].Value);
            txtAddress.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["address"].Value);
            cmbgender.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["gender"].Value);
            cmbUserType.Text = Common.ConvertToString(grdUsers.Rows[rowIndex].Cells["user_type"].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            u.id = Common.ConvertToInt(txtUserId.Text.Trim());
            isSuccess = dal.delete(u);
            if(isSuccess)
            {
                MessageBox.Show("User deleted");
                clearAll();
                loadUserDetailsInGrid();
            }
            else
            {
                MessageBox.Show("Failed to delete user");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Search(Common.ConvertToString(txtSearch.Text.Trim()));
            grdUsers.DataSource = dt;
        }
    }
}
