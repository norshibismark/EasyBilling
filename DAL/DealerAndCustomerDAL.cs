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
    class DealerAndCustomerDAL
    {
        #region select data from dealers and customer table
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetDealerAndCustomerDetails", AppManager.ConnectionManager);
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
        #region insert and update data
        public bool insertAndUpdate(DealerAndCustomerBLL d)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_InsertDealerAndCustomerDetails", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = d.id;
                cmd.Parameters.Add("type", SqlDbType.VarChar).Value = d.type;
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = d.name;
                cmd.Parameters.Add("email", SqlDbType.VarChar).Value = d.email;
                cmd.Parameters.Add("contact", SqlDbType.VarChar).Value = d.contact;
                cmd.Parameters.Add("address", SqlDbType.VarChar).Value = d.address;
                cmd.Parameters.Add("added_date", SqlDbType.DateTime).Value = d.added_date;
                cmd.Parameters.Add("added_by", SqlDbType.Int).Value = d.added_by;
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region delete dealers and customers
        public bool delete(DealerAndCustomerBLL d)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_DeleteDealersAndCustomers", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = d.id;
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region search dealers and customers based on keyword
        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_SearchDealersAndCustomers", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("keyword", SqlDbType.VarChar).Value = keyword;
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
        #region get max dealers and customer Id
        public int getMaxDealerAndCustomersId()
        {
            int maxDealerAndCustomerId = 0;
            SqlCommand cmd;
            SqlDataReader reader;
            try
            {
                cmd = new SqlCommand("USP_GetDealersAndCustomerMaxId", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        maxDealerAndCustomerId = Common.ConvertToInt(reader["MAXID"]);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return maxDealerAndCustomerId;
        }
        #endregion
        #region search dealers and customers for transation based on keyword
        public DealerAndCustomerBLL SearchDealerAndCustomerForTransaction(string keyword)
        {
            DataTable dt = new DataTable();
            DealerAndCustomerBLL dc = new DealerAndCustomerBLL();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_SearchDealersAndCustomersForTransaction", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("keyword", SqlDbType.VarChar).Value = keyword;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                dt = ds.Tables[0];
                if(dt.Rows.Count > 0)
                {
                    dc.name = Common.ConvertToString(dt.Rows[0]["name"]);
                    dc.email = Common.ConvertToString(dt.Rows[0]["email"]);
                    dc.contact = Common.ConvertToString(dt.Rows[0]["contact"]);
                    dc.address = Common.ConvertToString(dt.Rows[0]["address"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dc;
        }
        #endregion
        #region get dealer or customer Id from name
        public DealerAndCustomerBLL getDealerOrCustomerIdFromName(string name)
        {
            DealerAndCustomerBLL dc = new DealerAndCustomerBLL();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetDealerOrCustomerIdFromName", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("dealerOrCustomerName", SqlDbType.VarChar).Value = name;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                adapter.Dispose();
                if (dt.Rows.Count > 0)
                {
                    dc.id = Common.ConvertToInt(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dc;
        }
        #endregion
    }
}
