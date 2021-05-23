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
    class LoginDAL
    {
        #region check user entered correct username,password and user type
        public bool LoginCheck(LoginBLL l)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_LoginCheck", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", SqlDbType.VarChar).Value = l.username;
                cmd.Parameters.Add("password", SqlDbType.VarChar).Value = l.password;
                cmd.Parameters.Add("user_type", SqlDbType.VarChar).Value = l.user_type;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if(dt.Rows.Count > 0)
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

    }
}
