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
                string jsonPath = System.Windows.Forms.Application.StartupPath + @"\EasyBillingDBConnect.json";
                DatabaseDetails databaseDetails = JsonMethods.DeserializeObjectFromJson<DatabaseDetails>(jsonPath);
                string connectionString;
                if(String.IsNullOrEmpty(databaseDetails.UserName) && String.IsNullOrEmpty(databaseDetails.Password))
                {
                    connectionString = @"Data Source="+ databaseDetails.InstanceName +";Initial Catalog=" + databaseDetails.DatabaseName + ";Integrated Security=true;MultipleActiveResultSets=true";
                }
                else
                {
                    connectionString = @"Data Source="+ databaseDetails.InstanceName +";Initial Catalog="+ databaseDetails.DatabaseName +";User ID="+ databaseDetails.UserName +";Password="+ databaseDetails.Password +";Integrated Security=false;MultipleActiveResultSets=true";
                }
                //connectionString = @"Data Source=NAVYA\RELYONDB2008R2;Initial Catalog=EasyBilling;User ID=sa;Password=reladmin@123;Integrated Security=false";
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
