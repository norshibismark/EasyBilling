using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyBilling.BLL;
using EasyBilling.BLL.Application;

namespace EasyBilling.DAL
{
    class UserDAL
    {
        
        #region select data from users table
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetUsers", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                dt = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        #endregion
        #region insert and update data
        public bool insertAndUpdate(UserBLL u)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_InsertUsersDetails", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = u.id;
                cmd.Parameters.Add("first_name", SqlDbType.VarChar).Value = u.first_name;
                cmd.Parameters.Add("last_name", SqlDbType.VarChar).Value = u.last_name;
                cmd.Parameters.Add("email", SqlDbType.VarChar).Value = u.email;
                cmd.Parameters.Add("username", SqlDbType.VarChar).Value = u.username;
                cmd.Parameters.Add("password", SqlDbType.VarChar).Value = u.password;
                cmd.Parameters.Add("contact", SqlDbType.VarChar).Value = u.contact;
                cmd.Parameters.Add("address", SqlDbType.VarChar).Value = u.address;
                cmd.Parameters.Add("gender", SqlDbType.VarChar).Value = u.gender;
                cmd.Parameters.Add("user_type", SqlDbType.VarChar).Value = u.user_type;
                cmd.Parameters.Add("added_date", SqlDbType.DateTime).Value = u.added_date;
                cmd.Parameters.Add("added_by", SqlDbType.Int).Value = u.added_by;
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region delete users
        public bool delete(UserBLL u)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_DeleteUsers", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = u.id;
                int row = cmd.ExecuteNonQuery();
                if(row > 0)
                {
                    isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region get max user Id
        public int getMaxUserId()
        {
            int maxUserId = 0;
            SqlCommand cmd;
            SqlDataReader reader;
            try
            {
                cmd = new SqlCommand("USP_GetUsersMaxId", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        maxUserId = Common.ConvertToInt(reader["MAXID"]);
                    }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return maxUserId;
        }
        #endregion
        #region search users based on keyword
        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_SearchUsers", AppManager.ConnectionManager);
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
        #region get user Id from user name
        public UserBLL getUserIdFromUserName(string userName)
        {
            UserBLL u = new UserBLL();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetUserIdFromUserName", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("userName", SqlDbType.VarChar).Value = userName;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                adapter.Dispose();
                if(dt.Rows.Count > 0)
                {
                    u.id = Common.ConvertToInt(dt.Rows[0]["id"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return u;
        }
        #endregion
    }

}
