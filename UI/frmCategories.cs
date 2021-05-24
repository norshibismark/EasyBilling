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
    public partial class frmCategories : Form
    {
        CategoriesBLL c = new CategoriesBLL();
        CategoriesDAL dal = new CategoriesDAL();
        UserDAL userDal = new UserDAL();

        public frmCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            txtCategoryId.Text = Common.ConvertToString(dal.getMaxUserId() + 1);
            loadCategoriesInGrid();
        }

        private void loadCategoriesInGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dal.Select();
                grdCategories.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearAll()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtCategoryId.Text = Common.ConvertToString(dal.getMaxUserId() + 1);
            txtTitle.Focus();
        }

        private bool isValidated()
        {
            if(String.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                MessageBox.Show("Enter Title");
                txtTitle.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Enter Description");
                txtDescription.Focus();
                return false;
            }
            return true;
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
                c.id = Common.ConvertToInt(txtCategoryId.Text.Trim());
                c.title = Common.ConvertToString(txtTitle.Text.Trim());
                c.description = Common.ConvertToString(txtDescription.Text.Trim());
                c.added_date = DateTime.Now;

                string loggedInUser = frmLogin.loggedInUser;
                UserBLL usr = userDal.getUserIdFromUserName(loggedInUser);
                c.added_by = usr.id;

                isSuccess = dal.insertAndUpdate(c);
                if(isSuccess)
                {
                    MessageBox.Show("Category saved successfully");
                }
                else
                {
                    MessageBox.Show("Failed to insert category");
                }
                clearAll();
                loadCategoriesInGrid();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                DataTable dt = dal.Search(Common.ConvertToString(txtSearch.Text.Trim()));
                grdCategories.DataSource = dt;
            }
            else
            {
                loadCategoriesInGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtCategoryId.Text.Trim()))
            {
                MessageBox.Show("Category Id is missing");
                return;
            }
            bool isSuccess = false;
            c.id = Common.ConvertToInt(txtCategoryId.Text.Trim());
            isSuccess = dal.delete(c);
            if(isSuccess)
            {
                MessageBox.Show("Categories deleted");
                clearAll();
                loadCategoriesInGrid();
            }
            else
            {
                MessageBox.Show("Failed to delete categories");
            }
        }

        private void grdCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtCategoryId.Text = Common.ConvertToString(grdCategories.Rows[rowIndex].Cells["id"].Value);
            txtTitle.Text = Common.ConvertToString(grdCategories.Rows[rowIndex].Cells["title"].Value);
            txtDescription.Text = Common.ConvertToString(grdCategories.Rows[rowIndex].Cells["description"].Value);
        }
    }
}
