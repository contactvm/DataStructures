
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace StringProblems
{
    public class GetCountriesCountFromAPI
    {

        public static int getCountries(string s, int p)
        {
            string url = "https://jsonmock.hackerrank.com/api/countries/search?name=" + s + "&p=" + p;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonmock.hackerrank.com/api/");
                var response = client.GetAsync("countries/search?name=" + s + "&p=" + p);
                response.Wait();
                var result = response.Result;

                string result1 = result.Content.ReadAsStringAsync().Result;
                dynamic data = JObject.Parse(result1);
                Console.WriteLine(data.total);
                var responseObj = JsonConvert.DeserializeObject<DataTable>(result1);


                // Console.WriteLine(result.Content.ReadAsStringAsync());
            }
            return 0;

        }
        public static void DriverCode()
        {
            getCountries("un", 100090);

        }
    }
}