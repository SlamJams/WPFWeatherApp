using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWeatherApp.Model;

namespace WPFWeatherApp.ViewModel
{
    public class WeatherVM
    {
        public AccuWeather Weather { get; set; }

        private string query;

        public string Query
        {
            get { return query; }
            set
            {
                query = value;
                GetCities();
            }
        }

        public ObservableCollection<City> Cities { get; set; }

        public WeatherVM()
        {
            Weather = new AccuWeather();
            Cities = new ObservableCollection<City>();
        }

        private async void GetCities()
        {
            var cities = await WeatherAPI.GetAutoCompleteAsync(Query);

            Cities.Clear();
            foreach (var city in cities)
            {
                Cities.Add(city);
            }
        }
    }
}
