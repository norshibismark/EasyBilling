using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EasyBilling.BLL.Application
{
    class JsonMethods
    {
        public static T DeserializeObjectFromJson<T>(string jsonPath)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(jsonPath);
                string text = String.Empty;
                if(streamReader != null)
                {
                    text = streamReader.ReadToEnd();
                }
                return JsonConvert.DeserializeObject<T>(text);
            }
            catch(Exception)
            {
                return default(T);
            }
            finally
            {
                streamReader?.Close();
            }
        }
    }
}
