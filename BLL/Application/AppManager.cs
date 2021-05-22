using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EasyBilling.BLL.Application
{
    public class AppManager
    {
        public static SqlConnection ConnectionManager;
        public static void LaunchApplication()
        {
            string connectionString;
            connectionString = @"Data Source=NAVYA\RELYONDB2008R2;Initial Catalog=EasyBilling;User ID=sa;Password=reladmin@123;Integrated Security=false";
            ConnectionManager = new SqlConnection(connectionString);
            ConnectionManager.Open();
        }
    }
}
