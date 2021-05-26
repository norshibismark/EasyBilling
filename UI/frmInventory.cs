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
    public partial class frmInventory : Form
    {
        CategoriesDAL cDAL = new CategoriesDAL();
        ProductsDAL pDAL = new ProductsDAL();
        public frmInventory()
        {
            InitializeComponent();
        }

        private void loadCategory()
        {
            DataTable dt = new DataTable();
            dt = cDAL.Select();
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void loadInventory(string category)
        {
            DataTable dt = new DataTable();
            if (category == "ALL")
            {
                dt = pDAL.Select();
            }
            else
            {
                dt = pDAL.DisplayProductsBasedOnCategory(category);
            }
            grdInventoryDetails.DataSource = dt;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            loadInventory("ALL");
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = Common.ConvertToString(cmbCategory.Text.Trim());
            loadInventory(category);
        }
    }
}
