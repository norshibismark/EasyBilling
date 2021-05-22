using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyBilling
{
    public class Common
    {
        public static double ConvertToDouble(object objValue)
        {
            double tempValue = 0;
            string tempString;
            tempString = ConvertToString(objValue);
            double.TryParse(tempString, out tempValue);
            return tempValue;
        }

        public static int ConvertToInt(object objValue)
        {
            int tempValue = 0;
            string tempString;
            tempString = ConvertToString(objValue);
            int.TryParse(tempString, out tempValue);
            return tempValue;
        }

        public static string ConvertToString(object objValue)
        {
            if (objValue is DBNull || objValue == null)
                return string.Empty;

            return Convert.ToString(objValue);
        }

        public static bool ConvertToBool(object objValue)
        {
            bool tempValue = false;
            string tempString;
            tempString = ConvertToString(objValue);
            bool.TryParse(tempString, out tempValue);
            return tempValue;
        }

        public static DateTime ConvertToDateTime(object objValue)
        {
            DateTime tempValue;
            try
            {
                if (objValue is DBNull || objValue == null)
                    return new DateTime();

                tempValue = Convert.ToDateTime(objValue);
            }
            catch
            {
                string tempString;
                tempString = ConvertToString(objValue);
                DateTime.TryParse(tempString, out tempValue);
            }
            return tempValue;
        }
    }
}
