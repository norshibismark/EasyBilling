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
    class TrasactionDetailDAL
    {
        #region insert transaction detail
        public bool insertTransaction(TransactionDetailBLL t)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_InsertTransactionDetail", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = t.id;
                cmd.Parameters.Add("product_id", SqlDbType.Int).Value = t.product_id;
                cmd.Parameters.Add("rate", SqlDbType.Decimal).Value = t.rate;
                cmd.Parameters.Add("qty", SqlDbType.Decimal).Value = t.qty;
                cmd.Parameters.Add("total", SqlDbType.Decimal).Value = t.total;
                cmd.Parameters.Add("dealer_customer_id", SqlDbType.Int).Value = t.dealer_customer_id;
                cmd.Parameters.Add("added_date", SqlDbType.DateTime).Value = t.added_date;
                cmd.Parameters.Add("added_by", SqlDbType.Int).Value = t.added_by;
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
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
