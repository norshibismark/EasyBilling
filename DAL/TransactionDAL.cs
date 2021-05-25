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
    }
}
