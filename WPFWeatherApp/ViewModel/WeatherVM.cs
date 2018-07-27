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
        public ObservableCollection<List<City>> Cities { get; set; }
        


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

        private City selectedCity;

        public City SelectedCity
        {
            get { return selectedCity; }
            set
            {
                selectedCity = value;
                GetWeather();
            }
        }


        public WeatherVM()
        {
            Weather = new AccuWeather();
            Cities = new ObservableCollection<List<City>>();
            SelectedCity = new City();
        }

        private async void GetCities()
        {
            var cities = await WeatherAPI.GetAutoCompleteAsync(Query);

            Cities.Clear();
            

        }

        private async void GetWeather()
        {
            var weather = await WeatherAPI.GetWeatherInformationAsync(SelectedCity.Key);
            Weather.WeatherText = weather.WeatherText;
            Weather.Precipitation = weather.Precipitation;
            Weather.RealFeelTemperature = weather.RealFeelTemperature;
            Weather.Temperature = weather.Temperature;

        }
    }
}
