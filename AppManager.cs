using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EasyBilling
{
    class AppManager
    {
        public static SqlConnection ConncetionManager;
        public static void LaunchApplication()
        {
            string connectionString;
            connectionString = @"Data Source=NAVYA\RELYONDB2008R2;Initial Catalog=EasyBilling;User ID=sa;Password=reladmin@123;Integrated Security=false";
            ConncetionManager = new SqlConnection(connectionString);
            ConncetionManager.Open();
        }
    }
}
