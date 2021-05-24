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
    public partial class frmDealerAndCustomer : Form
    {
        DealerAndCustomerBLL d = new DealerAndCustomerBLL();
        DealerAndCustomerDAL dal = new DealerAndCustomerDAL();
        UserDAL udal = new UserDAL();
        public frmDealerAndCustomer()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDealersAndCustomersDetailsInGrid()
        {
            DataTable dt = new DataTable();
            dt = dal.Select();
            grdDealerAndCustomer.DataSource = dt;
        }

        private void frmDealerAndCustomer_Load(object sender, EventArgs e)
        {
            loadDealersAndCustomersDetailsInGrid();
            txtDealerAndCustomerId.Text = Common.ConvertToString(dal.getMaxDealerAndCustomersId() + 1);
        }

        private void clearAll()
        {
            cmbType.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtDealerAndCustomerId.Text = Common.ConvertToString(dal.getMaxDealerAndCustomersId() + 1);
            cmbType.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
            loadDealersAndCustomersDetailsInGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                DataTable dt = new DataTable();
                dt = dal.Search(Common.ConvertToString(txtSearch.Text.Trim()));
                grdDealerAndCustomer.DataSource = dt;
            }
            else
            {
                loadDealersAndCustomersDetailsInGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtDealerAndCustomerId.Text.Trim()))
            {
                MessageBox.Show("Dealer and customer Id is blank");
                return;
            }
            bool isSuccess = false;
            d.id = Common.ConvertToInt(txtDealerAndCustomerId.Text.Trim());
            isSuccess = dal.delete(d);
            if(isSuccess)
            {
                if(cmbType.Text.Trim() == "Dealer")
                {
                    MessageBox.Show("Dealer deleted successfully");
                }
                else if(cmbType.Text.Trim() == "Customer")
                {
                    MessageBox.Show("Customer deleted successfully");
                }
                clearAll();
                loadDealersAndCustomersDetailsInGrid();
            }
            else
            {
                if (cmbType.Text.Trim() == "Dealer")
                {
                    MessageBox.Show("Dealer delete failed");
                }
                else if (cmbType.Text.Trim() == "Customer")
                {
                    MessageBox.Show("Customer delete failed");
                }
            }
        }

        private void grdDealerAndCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtDealerAndCustomerId.Text = Common.ConvertToString(grdDealerAndCustomer.Rows[rowIndex].Cells["id"].Value);
            cmbType.Text = Common.ConvertToString(grdDealerAndCustomer.Rows[rowIndex].Cells["type"].Value);
            txtName.Text = Common.ConvertToString(grdDealerAndCustomer.Rows[rowIndex].Cells["name"].Value);
            txtEmail.Text = Common.ConvertToString(grdDealerAndCustomer.Rows[rowIndex].Cells["email"].Value);
            txtContact.Text = Common.ConvertToString(grdDealerAndCustomer.Rows[rowIndex].Cells["contact"].Value);
            txtAddress.Text = Common.ConvertToString(grdDealerAndCustomer.Rows[rowIndex].Cells["address"].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                bool isSuccess = false;
                d.id = Common.ConvertToInt(txtDealerAndCustomerId.Text.Trim());
                d.type = Common.ConvertToString(cmbType.Text.Trim());
                d.name = Common.ConvertToString(txtName.Text.Trim());
                d.email = Common.ConvertToString(txtEmail.Text.Trim());
                d.contact = Common.ConvertToString(txtContact.Text.Trim());
                d.address = Common.ConvertToString(txtAddress.Text.Trim());
                d.added_date = DateTime.Now;
                string loggedInUser = frmLogin.loggedInUser;
                UserBLL usr = udal.getUserIdFromUserName(loggedInUser);
                d.added_by = usr.id;

                isSuccess = dal.insertAndUpdate(d);
                if (isSuccess)
                {
                    if (cmbType.Text.Trim() == "Dealer")
                    {
                        MessageBox.Show("Dealer saved successfully");
                    }
                    else if (cmbType.Text.Trim() == "Customer")
                    {
                        MessageBox.Show("Customer saved successfully");
                    }
                }
                else
                {
                    if (cmbType.Text.Trim() == "Dealer")
                    {
                        MessageBox.Show("Dealer save failed");
                    }
                    else if (cmbType.Text.Trim() == "Customer")
                    {
                        MessageBox.Show("Customer save failed");
                    }
                }
                clearAll();
                loadDealersAndCustomersDetailsInGrid();
            }
        }

        private bool isValidated()
        {
            if(String.IsNullOrEmpty(cmbType.Text.Trim()))
            {
                MessageBox.Show("Select type");
                cmbType.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Enter Name");
                txtName.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Enter Email Id");
                txtEmail.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtContact.Text.Trim()))
            {
                MessageBox.Show("Enter contact");
                txtContact.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Enter address");
                txtAddress.Focus();
                return false;
            }
            return true;
        }
    }
}
