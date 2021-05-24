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
    public partial class frmProducts : Form
    {
        ProductsBLL p = new ProductsBLL();
        ProductsDAL dal = new ProductsDAL();
        UserDAL udal = new UserDAL();

        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidated()
        {
            if(String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Enter Product Name");
                txtName.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(cmbCategory.Text.Trim()))
            {
                MessageBox.Show("Select Category");
                cmbCategory.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Enter Description");
                txtDescription.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtRate.Text.Trim()))
            {
                MessageBox.Show("Enter Rate");
                txtRate.Focus();
                return false;
            }
            return true;
        }

        private void clearAll()
        {
            txtName.Text = "";
            cmbCategory.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtProductId.Text = Common.ConvertToString(dal.getMaxProductId() + 1);
            txtName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                DataTable dt = new DataTable();
                dt = dal.Search(Common.ConvertToString(txtSearch.Text.Trim()));
                grdProducts.DataSource = dt;
            }
            else
            {
                loadProductsDetailsIngrid();
            }
        }

        private void loadProductsDetailsIngrid()
        {
            DataTable dt = new DataTable();
            dt = dal.Select();
            grdProducts.DataSource = dt;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            loadCategoriesFromDb();
            loadProductsDetailsIngrid();
            txtProductId.Text = Common.ConvertToString(dal.getMaxProductId() + 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            try
            {
                p.id = Common.ConvertToInt(txtProductId.Text.Trim());
                p.name = Common.ConvertToString(txtName.Text.Trim());
                p.category = Common.ConvertToString(cmbCategory.Text.Trim());
                p.rate = Common.ConvertToDouble(txtRate.Text.Trim());
                p.qty = 0;
                p.description = Common.ConvertToString(txtDescription.Text.Trim());
                p.added_date = DateTime.Now;
                string loggedInUser = frmLogin.loggedInUser;
                UserBLL usr = udal.getUserIdFromUserName(loggedInUser);
                p.added_by = usr.id;

                isSuccess = dal.insertAndUpdate(p);
                if(isSuccess)
                {
                    MessageBox.Show("Saved successfully");
                }
                else
                {
                    MessageBox.Show("Save failed");
                }

                clearAll();
                loadProductsDetailsIngrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Product Id is missing");
                return;
            }
            bool isSuccess = false;
            p.id = Common.ConvertToInt(txtProductId.Text.Trim());
            isSuccess = dal.delete(p);
            if(isSuccess)
            {
                MessageBox.Show("Product deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete product");
            }
            clearAll();
            loadProductsDetailsIngrid();
        }

        private void loadCategoriesFromDb()
        {
            CategoriesDAL cdal = new CategoriesDAL();
            DataTable categoriesDt = new DataTable();
            categoriesDt = cdal.Select();
            cmbCategory.DataSource = categoriesDt;
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";
        }

        private void grdProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtProductId.Text = Common.ConvertToString(grdProducts.Rows[rowIndex].Cells["id"].Value);
            txtName.Text = Common.ConvertToString(grdProducts.Rows[rowIndex].Cells["name"].Value);
            cmbCategory.Text = Common.ConvertToString(grdProducts.Rows[rowIndex].Cells["category"].Value);
            txtDescription.Text = Common.ConvertToString(grdProducts.Rows[rowIndex].Cells["description"].Value);
            txtRate.Text = Common.ConvertToString(grdProducts.Rows[rowIndex].Cells["rate"].Value);
        }
    }
}
