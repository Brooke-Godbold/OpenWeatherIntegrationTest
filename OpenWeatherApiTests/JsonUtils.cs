using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OpenWeatherApiTests
{
    public class JsonUtils
    {
        public static string getFieldFromJson(string jsonString, string field)
        {
            return JObject.Parse(jsonString)[field].ToString();
        }

        public static List<string> getListFromJsonByField(string jsonString, string field)
        {
            JArray jArray = JArray.Parse(jsonString);
            List<string> list = new List<string>();
            jArray.ToList().ForEach(jToken => list.Add(jToken[field].ToString()));
            return list;
        }
    }
}
