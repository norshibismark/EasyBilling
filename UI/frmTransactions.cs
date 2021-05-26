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
    public partial class frmTransactions : Form
    {
        TransactionDAL tDAL = new TransactionDAL();
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void displayTransactions(string type)
        {
            DataTable dt = new DataTable();
            if(type == "ALL")
            {
                dt = tDAL.DisplayAllTransactions();
            }
            else if(type == "PURCHASE" || type == "SALES")
            {
                dt = tDAL.DisplayAllTransactionsBasedOnType(type);
            }
            grdTransactionDetails.DataSource = dt;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displayTransactions("ALL");
        }

        private void cmbTranasactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = Common.ConvertToString(cmbTranasactionType.Text.Trim());
            displayTransactions(type);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlPurchaseAndSalesTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTransactionsTop_Click(object sender, EventArgs e)
        {

        }

        private void lblTransactionType_Click(object sender, EventArgs e)
        {

        }

        private void grdTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
