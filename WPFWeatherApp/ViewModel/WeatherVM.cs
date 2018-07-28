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
        public ObservableCollection<City> Cities { get; set; }
        


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
                if (selectedCity.Key != null)
                {
                    GetWeather();
                }
            }
        }


        public WeatherVM()
        {
            Weather = new AccuWeather();
            Cities = new ObservableCollection<City>();
            SelectedCity = new City();
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

        private async void GetWeather()
        {
            var weather = await WeatherAPI.GetWeatherInformationAsync(SelectedCity.Key);
            Weather.WeatherText = weather[0].WeatherText;
            Weather.Precipitation = weather[0].Precipitation;
            Weather.RealFeelTemperature = weather[0].RealFeelTemperature;
            Weather.Temperature = weather[0].Temperature;
            Weather.CityName = selectedCity.LocalizedName;
        }
    }
}
