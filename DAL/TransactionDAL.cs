using EasyBilling.BLL;
using EasyBilling.BLL.Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyBilling.DAL
{
    class TransactionDAL
    {
        #region insert transactions 
        public bool insertTransactions(TransactionsBLL t,out int transactionId)
        {
            bool isSuccess = false;
            transactionId = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_InsertTransactions", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("id", SqlDbType.Int).Value = t.id;
                cmd.Parameters.Add("type", SqlDbType.VarChar).Value = t.type;
                cmd.Parameters.Add("dealer_customer_id", SqlDbType.Int).Value = t.dealer_customer_id;
                cmd.Parameters.Add("grandTotal", SqlDbType.Decimal).Value = t.grandTotal;
                cmd.Parameters.Add("transaction_date", SqlDbType.DateTime).Value = t.transaction_date;
                cmd.Parameters.Add("tax", SqlDbType.Decimal).Value = t.tax;
                cmd.Parameters.Add("discount", SqlDbType.Decimal).Value = t.discount;
                cmd.Parameters.Add("added_by", SqlDbType.Int).Value = t.added_by;
                Object o = cmd.ExecuteScalar();
                if (o!=null)
                {
                    transactionId = Common.ConvertToInt(o.ToString());
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region display all tranasactions
        public DataTable DisplayAllTransactions()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetAllTransactionDetails", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        #endregion
        #region display all tranasactions based on type
        public DataTable DisplayAllTransactionsBasedOnType(string type)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetAllTransactionDetailsBasedOnType", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("type", SqlDbType.VarChar).Value = type;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        #endregion
    }
}
