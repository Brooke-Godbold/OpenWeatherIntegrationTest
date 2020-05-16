using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenWeatherApiTests
{
    public class RequestUtils
    {
        public static async Task<string> GetRequest(string url)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            HttpResponseMessage httpResponseMessage = await client.GetAsync(url);
            string response = await httpResponseMessage.Content.ReadAsStringAsync();
            return response;
        }
    }
}
