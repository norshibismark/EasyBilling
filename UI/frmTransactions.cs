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

        private void displayTransactionsInGrid(string option)
        {
            DataTable dt = new DataTable();
            if(option == "ALL")
            {
                dt = tDAL.DisplayAllTransactions();
            }
            //else if (option == "TRANTYPE")
            //{
            //    dt = tDAL.DisplayAllTransactionsBasedOnType(cmbTranasactionType.Text.Trim());
            //}
            else if(option == "TRANTYPEDATE")
            {
                dt = tDAL.DisplayAllTransactionsBasedOnTypeAndTransactionDate(cmbTranasactionType.Text.Trim(),dtpTransactionDate.Value);
            }
            grdTransactionDetails.DataSource = dt;

            txtTotal.Text = Common.ConvertToString(calculateSumOfColumnValuesFromDataTable(dt, "grandTotal"));
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displayTransactionsInGrid("ALL");
        }

        private void cmbTranasactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayTransactionsInGrid("TRANTYPEDATE");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double calculateSumOfColumnValuesFromDataTable(DataTable dt, string colName)
        {
            double subTotal = 0;
            DataTable tempDt = new DataTable();
            tempDt = dt;
            subTotal = Common.ConvertToDouble(tempDt.Compute("SUM(" + colName + ")", ""));
            tempDt.Dispose();
            return subTotal;
        }

        private void dtpTransactionDate_ValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbTranasactionType.Text.Trim()))
            {
                MessageBox.Show("Select transaction type");
                cmbTranasactionType.Focus();
                return;
            }

            displayTransactionsInGrid("TRANTYPEDATE");
        }
    }
}
