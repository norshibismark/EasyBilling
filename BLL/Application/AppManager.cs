using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyBilling.BLL.Application
{
    public class AppManager
    {
        public static SqlConnection ConnectionManager;
        public static bool isConnectionOpened;
        public static void LaunchApplication()
        {
            try
            {
                string connectionString;
                connectionString = @"Data Source=NAVYA\RELYONDB2008R2;Initial Catalog=EasyBilling;User ID=sa;Password=reladmin@123;Integrated Security=false";
                ConnectionManager = new SqlConnection(connectionString);
                ConnectionManager.Open();
                isConnectionOpened = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                isConnectionOpened = false;
            }
        }
    }
}
