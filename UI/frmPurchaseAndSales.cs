using EasyBilling.BLL;
using EasyBilling.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace EasyBilling.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        DealerAndCustomerDAL dcDAL = new DealerAndCustomerDAL();
        ProductsDAL pDAL = new ProductsDAL();
        UserDAL uDAL = new UserDAL();
        TransactionDAL tDAL = new TransactionDAL();
        TrasactionDetailDAL tdDAL = new TrasactionDetailDAL();
        DataTable dtTransaction = new DataTable();
        private double _grandTotal = 0;
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
                dc = dcDAL.SearchDealerAndCustomerForTransaction(keyWord);

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
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQuantity.Text = "";
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                ProductsBLL p = new ProductsBLL();
                p = pDAL.SearchDealerAndCustomerForTransaction(keyWord);

                txtProductDetailsName.Text = Common.ConvertToString(p.name);
                txtRate.Text = Common.ConvertToString(p.rate);
                txtInventory.Text = Common.ConvertToString(p.qty);
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

        private void clearCalculationDetails()
        {
            txtSubTotal.Text = "";
            txtDiscountPercentage.Text = "";
            txtGstPercentage.Text = "";
            txtGrandTotal.Text = "";
            txtPaidAmount.Text = "";
            txtReturnAmount.Text = "";
        }
        private void clearDealerAndCustomerDetails()
        {
            txtDealerAndCustomerSearch.Text = "";
            txtDealerAndCustomerName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            dtpBillDate.Value = DateTime.Now;
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
                _grandTotal = grandTotal;
                txtGrandTotal.Text = Common.ConvertToString(grandTotal);
            }
        }

        private void txtGstPercentage_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtGstPercentage.Text.Trim()) || txtGstPercentage.Text.Trim() == "0")
            {
                txtGrandTotal.Text = Common.ConvertToString(_grandTotal);
            }

            if (String.IsNullOrEmpty(txtGrandTotal.Text.Trim()) || txtGrandTotal.Text.Trim() == "0")
            {
                MessageBox.Show("Calculate the discount and set the grand total first");
            }
            else
            {
                double grandTotal = Common.ConvertToDouble(txtGrandTotal.Text.Trim());
                double gstPercentage = Common.ConvertToDouble(txtGstPercentage.Text.Trim());
                double grandTotalWithGst = ((100 + gstPercentage) / 100) * grandTotal;

                txtGrandTotal.Text = Common.ConvertToString(grandTotalWithGst);
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            double grandTotal = Common.ConvertToDouble(txtGrandTotal.Text.Trim());
            double paidAmount = Common.ConvertToDouble(txtPaidAmount.Text.Trim());

            double returnAmount = paidAmount - grandTotal;

            txtReturnAmount.Text = Common.ConvertToString(returnAmount);
        }

        private void btnClearDealerAndCustomerDetails_Click(object sender, EventArgs e)
        {
            clearDealerAndCustomerDetails();
        }

        private void btnClearProductDetails_Click(object sender, EventArgs e)
        {
            clearProductDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TransactionsBLL transaction = new TransactionsBLL();
            transaction.type = lblPurchaseAndSalesTop.Text;

            string dealerOrCustomerName = Common.ConvertToString(txtDealerAndCustomerName.Text.Trim());

            //if (!String.IsNullOrEmpty(dealerOrCustomerName))
            //{
                DealerAndCustomerBLL dc = dcDAL.getDealerOrCustomerIdFromName(dealerOrCustomerName);
                transaction.dealer_customer_id = dc.id;
            //}
            //else
            //{
            //    transaction.dealer_customer_id = 0;
            //}

            transaction.grandTotal = Common.ConvertToDouble(txtGrandTotal.Text.Trim());
            //transaction.transaction_date = DateTime.Now;
            transaction.transaction_date = dtpBillDate.Value;
            transaction.tax = Common.ConvertToDouble(txtGstPercentage.Text.Trim());
            transaction.discount = Common.ConvertToDouble(txtDiscountPercentage.Text.Trim());
            string loggedInUser = frmLogin.loggedInUser;
            UserBLL usr = uDAL.getUserIdFromUserName(loggedInUser);
            transaction.added_by = usr.id;
            transaction.transactionDetails = dtTransaction;

            bool isSuccess = false;

            //insert transaction details

            using(TransactionScope scope = new TransactionScope())
            {
                int transactionId = -1;
                string transactionType = lblPurchaseAndSalesTop.Text;
                bool x = tDAL.insertTransactions(transaction, out transactionId);

                for (int i = 0; i < grdAddedProducts.Rows.Count; i++)
                {
                    TransactionDetailBLL transactionDetails = new TransactionDetailBLL();

                    string productName = Common.ConvertToString(grdAddedProducts.Rows[i].Cells["ProductName"].Value);

                    ProductsBLL p = pDAL.getProductIdFromName(productName);
                    transactionDetails.product_id = p.id;
                    transactionDetails.rate = Common.ConvertToDouble(grdAddedProducts.Rows[i].Cells["Rate"].Value);
                    transactionDetails.qty = Common.ConvertToDouble(grdAddedProducts.Rows[i].Cells["Quantity"].Value);
                    transactionDetails.total = Common.ConvertToDouble(grdAddedProducts.Rows[i].Cells["Total"].Value);
                    transactionDetails.dealer_customer_id = dc.id;
                    transactionDetails.added_date = dtpBillDate.Value;
                    transactionDetails.added_by = usr.id;
                    transactionDetails.tranId = transactionId;

                    //increase or decrease the product quantity based on purchase and sales
                    
                    bool isPSIncreaseDecrease = false;
                    if(transactionType == "PURCHASE")
                    {
                        //increase the product quantity
                        isPSIncreaseDecrease = pDAL.increaseProductQuantity(transactionDetails.product_id, transactionDetails.qty);
                    }
                    else if(transactionType == "SALES")
                    {
                        //decrease the product quantity
                        isPSIncreaseDecrease = pDAL.decreaseProductQuantity(transactionDetails.product_id, transactionDetails.qty);
                    }

                    bool y = tdDAL.insertTransactionDetail(transactionDetails);
                    isSuccess = x && y && isPSIncreaseDecrease;
                } 
                
                if(isSuccess)
                {
                    scope.Complete();
                    if (transactionType == "PURCHASE")
                    {
                        MessageBox.Show("Purchase successfull");
                    }
                    else if (transactionType == "SALES")
                    {
                        MessageBox.Show("Sales successfull");
                    }
                    dtTransaction.Clear();
                    grdAddedProducts.DataSource = null;
                    clearDealerAndCustomerDetails();
                    clearProductDetails();
                    clearCalculationDetails();
                }
                else
                {
                    MessageBox.Show("Transaction failed");
                }
            }
        }
    }
}
