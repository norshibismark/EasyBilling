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
    public partial class frmProductDetails : Form
    {
        CategoriesDAL cDAL = new CategoriesDAL();
        ProductsDAL pDAL = new ProductsDAL();

        public DataTable dtProductDetails = new DataTable();
        public int rowNumber = 0;
        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadCategory()
        {
            DataTable dt = new DataTable();
            dt = cDAL.Select();
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";
        }

        private void loadInventoryInGrid(string option)
        {
            if (option == "ALL")
            {
                dtProductDetails = pDAL.Select();
            }
            else if(option == "CATEGORY")
            {
                dtProductDetails = pDAL.DisplayProductsBasedOnCategory(cmbCategory.Text.Trim());
            }
            else if(option == "KEYWORD")
            {
                dtProductDetails = pDAL.Search(txtSearchKeyword.Text.Trim());
            }
            grdProductDetails.DataSource = dtProductDetails;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInventoryInGrid("CATEGORY");
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void grdProductDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowNumber = e.RowIndex;
            this.DialogResult = DialogResult.OK;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadInventoryInGrid("KEYWORD");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            loadInventoryInGrid("ALL");
        }
    }
}
