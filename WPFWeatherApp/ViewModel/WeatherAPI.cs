using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPFWeatherApp.Model;
using Newtonsoft.Json;

namespace WPFWeatherApp.ViewModel
{
    class WeatherAPI
    {
        public const string API_KEY = "pIdABsEBSEAllimmMYA4EtdkxJukxDzB";
        public const string BASE_URL = "http://dataservice.accuweather.com/currentconditions/v1/{0}?apikey={1}";
        public const string BASE_URL_AUTOCOMPLETE = "http://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey={0}&q={1}";

        public static async Task<AccuWeather> GetWeatherInformationAsync(string cityKey)
        {
            AccuWeather result = new AccuWeather();

            string url = String.Format(BASE_URL, cityKey ,API_KEY);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<AccuWeather>(json);
            }

            return result;
        }

        public static async Task<List<City>> GetAutoCompleteAsync(string query)
        {
            List<City> cities = new List<City>();

            string url = String.Format(BASE_URL_AUTOCOMPLETE, API_KEY, query);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                cities = JsonConvert.DeserializeObject<List<City>>(json);
            }

            return cities;
        }
    }
}
