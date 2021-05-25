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
    public partial class frmPurchaseAndSales : Form
    {
        DealerAndCustomerDAL dcDal = new DealerAndCustomerDAL();
        ProductsDAL pDal = new ProductsDAL();
        DataTable dtTransaction = new DataTable();
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            string type = frmUserDashboard.transactionType;
            lblPurchaseAndSalesTop.Text = type;
            toolTipPurchaseAndSales.SetToolTip(txtDealerAndCustomerSearch, "Press enter key to search dealers and customers");
            toolTipPurchaseAndSales.SetToolTip(txtProductDetailsSearch, "Press enter key to search products");
            loadProductDetailsColumnInGrid();
        }

        private void txtDealerAndCustomerSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyWord = Common.ConvertToString(txtDealerAndCustomerSearch.Text.Trim());
            if (keyWord == "" || keyWord == null)
            {
                txtDealerAndCustomerName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                DealerAndCustomerBLL dc = new DealerAndCustomerBLL();
                dc = dcDal.SearchDealerAndCustomerForTransaction(keyWord);

                txtDealerAndCustomerName.Text = dc.name;
                txtEmail.Text = dc.email;
                txtContact.Text = dc.contact;
                txtAddress.Text = dc.address;
            }
        }

        private void txtProductDetailsSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyWord = Common.ConvertToString(txtProductDetailsSearch.Text.Trim());
            if (keyWord == "" || keyWord == null)
            {
                txtProductDetailsSearch.Text = "";
                txtProductDetailsName.Text = "";
                txtRate.Text = "";
                txtQuantity.Text = "";
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                ProductsBLL p = new ProductsBLL();
                p = pDal.SearchDealerAndCustomerForTransaction(keyWord);

                txtProductDetailsName.Text = Common.ConvertToString(p.name);
                txtRate.Text = Common.ConvertToString(p.rate);
                txtQuantity.Text = Common.ConvertToString(p.qty);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isProductDetailsValidated())
            {
                string productName = Common.ConvertToString(txtProductDetailsName.Text.Trim());
                double rate = Common.ConvertToDouble(txtRate.Text.Trim());
                double quantity = Common.ConvertToDouble(txtQuantity.Text.Trim());
                double total = rate * quantity;
                dtTransaction.Rows.Add(productName, rate, quantity, total);

                grdAddedProducts.DataSource = dtTransaction;

                txtSubTotal.Text = Common.ConvertToString(calculateSumOfColumnValuesFromDataTable(dtTransaction, "Total"));

                clearProductDetails();
            }
        }

        private bool isProductDetailsValidated()
        {
            if (String.IsNullOrEmpty(txtProductDetailsName.Text.Trim()))
            {
                MessageBox.Show("Enter Product Name");
                txtProductDetailsName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtRate.Text.Trim()) || txtRate.Text.Trim() == "0")
            {
                MessageBox.Show("Enter Rate");
                txtRate.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtQuantity.Text.Trim()) || txtQuantity.Text.Trim() == "0")
            {
                MessageBox.Show("Enter Quantity");
                txtQuantity.Focus();
                return false;
            }
            return true;
        }

        private void loadProductDetailsColumnInGrid()
        {
            dtTransaction.Columns.Add("ProductName", typeof(string));
            dtTransaction.Columns.Add("Rate", typeof(double));
            dtTransaction.Columns.Add("Quantity", typeof(double));
            dtTransaction.Columns.Add("Total", typeof(double));
        }

        private void clearProductDetails()
        {
            txtProductDetailsSearch.Text = "";
            txtProductDetailsName.Text = "";
            txtInventory.Text = "";
            txtRate.Text = "";
            txtQuantity.Text = "";
        }

        private double calculateSumOfColumnValuesFromDataTable(DataTable dt,string colName)
        {
            double subTotal = 0;
            DataTable tempDt = new DataTable();
            tempDt = dt;
            subTotal = Common.ConvertToDouble(tempDt.Compute("SUM("+ colName +")",""));
            tempDt.Dispose();
            return subTotal;
        }

        private void txtDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtDiscountPercentage.Text.Trim()))
            {
                MessageBox.Show("Enter discount percentage first");
            }
            else
            {
                double subTotal = Common.ConvertToDouble(txtSubTotal.Text.Trim());
                double discountPercentage = Common.ConvertToDouble(txtDiscountPercentage.Text.Trim());
                double grandTotal = ((100 - discountPercentage) / 100) * subTotal;

                txtGrandTotal.Text = Common.ConvertToString(grandTotal);
            }
        }

        private void txtGstPercentage_TextChanged(object sender, EventArgs e)
        {
            if(Common.ConvertToDouble(txtGrandTotal.Text.Trim()) == 0)
            {
                MessageBox.Show("Calculate the discount and set the grand total first");
            }
            else
            {
                double grandTotal = Common.ConvertToDouble(txtGrandTotal.Text.Trim());
                double gstPercentage = Common.ConvertToDouble(txtGstPercentage.Text.Trim());
                double grandTotalWithGst = ((100 + gstPercentage) / 100) * grandTotal;

                txtGrandTotal.Text = Common.ConvertToString(grandTotal);
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            double grandTotal = Common.ConvertToDouble(txtGrandTotal.Text.Trim());
            double paidAmount = Common.ConvertToDouble(txtPaidAmount.Text.Trim());

            double returnAmount = paidAmount - grandTotal;

            txtReturnAmount.Text = Common.ConvertToString(returnAmount);
        }
    }
}
