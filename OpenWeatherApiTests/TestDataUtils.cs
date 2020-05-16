using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApiTests
{
    class TestDataUtils
    {
        //private static string apiKeyName = "API_KEY";

        public static string baseUrl = "https://api.openweathermap.org";
        public static string oneCallApi = "/data/2.5/onecall?";

        public static string getApiKey()
        {
            return Properties.Settings.Default.API_KEY.ToString();
            //return Environment.GetEnvironmentVariable(apiKeyName).ToString();
        }

        public static string getCityLatitude(string city)
        {
            string resource = Properties.Resources.ResourceManager.GetString(city);
            return resource.Split(':')[0];
        }

        public static string getCityLongitude(string city)
        {
            string resource = Properties.Resources.ResourceManager.GetString(city);
            return resource.Split(':')[1];
        }

        public static string getCityTimezone(string city)
        {
            string resource = Properties.Resources.ResourceManager.GetString(city);
            return resource.Split(':')[2];
        }
    }
}
