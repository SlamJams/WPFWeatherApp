using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWeatherApp.Model;

namespace WPFWeatherApp.ViewModel
{
    public class WeatherVM
    {
        public AccuWeather Weather { get; set; }

        public WeatherVM()
        {
            Weather = new AccuWeather();
        }

    }
}
