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
    public partial class frmDealerAndCustomerDetails : Form
    {
        DealerAndCustomerDAL dcDAL = new DealerAndCustomerDAL();
        public DataTable dtDealerAndCustomerDetails = new DataTable();
        public int rowNumber = 0;
        public frmDealerAndCustomerDetails()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDealerAndCustomerDetails_Load(object sender, EventArgs e)
        {
            dtDealerAndCustomerDetails = dcDAL.Select();
            grdDealerAndCustomerDetails.DataSource = dtDealerAndCustomerDetails;
        }

        private void displaySearchResultInGrid(string option)
        {
            if(option == "ALL")
            {
                dtDealerAndCustomerDetails = dcDAL.Select();
            }
            else if(option == "KEYWORD")
            {
                dtDealerAndCustomerDetails = dcDAL.Search(txtSearchKeyword.Text.Trim());
            }
            else if(option == "TYPE")
            {
                dtDealerAndCustomerDetails = dcDAL.SearchDealerAndCustomerBasedOntype(cmbType.Text.Trim());
            }
            grdDealerAndCustomerDetails.DataSource = dtDealerAndCustomerDetails;
        }

        private void btnTypeSearch_Click(object sender, EventArgs e)
        {
            displaySearchResultInGrid("TYPE");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            displaySearchResultInGrid("KEYWORD");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displaySearchResultInGrid("ALL");
        }

        private void grdDealerAndCustomerDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowNumber = e.RowIndex;
            this.DialogResult = DialogResult.OK;
        }
    }
}
