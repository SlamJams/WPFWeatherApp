using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFWeatherApp.Model
{
    public class Metric : INotifyPropertyChanged
    {
        private double _value;
        public double Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        private string unit;
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        private int unitType;
        public int UnitType
        {
            get { return unitType; }
            set
            {
                unitType = value;
                OnPropertyChanged("UnitType");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Imperial : INotifyPropertyChanged
    {
        private double _value;
        public double Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        private string unit;
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        private int unitType;
        public int UnitType
        {
            get { return unitType; }
            set
            {
                unitType = value;
                OnPropertyChanged("UnitType");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Temperature : INotifyPropertyChanged
    {

        private Metric metric;
        public Metric Metric
        {
            get { return metric; }
            set
            {
                metric = value;
                OnPropertyChanged("Metric");
            }
        }

        private Imperial imperial;
        public Imperial Imperial
        {
            get { return imperial; }
            set
            {
                imperial = value;
                OnPropertyChanged("Imperial");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class RealFeelTemperature
    {
        private Metric metric;
        public Metric Metric
        {
            get { return metric; }
            set
            {
                metric = value;
                OnPropertyChanged("Metric");
            }
        }

        private Imperial imperial;
        public Imperial Imperial
        {
            get { return imperial; }
            set
            {
                imperial = value;
                OnPropertyChanged("Imperial");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Precipitation
    {
        private Metric metric;
        public Metric Metric
        {
            get { return metric; }
            set
            {
                metric = value;
                OnPropertyChanged("Metric");
            }
        }

        private Imperial imperial;
        public Imperial Imperial
        {
            get { return imperial; }
            set
            {
                imperial = value;
                OnPropertyChanged("Imperial");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class AccuWeather : INotifyPropertyChanged
    {

        private string cityName;

        public string CityName
        {
            get { return cityName; }
            set
            {
                cityName = value;
                OnPropertyChanged("CityName");
            }
        }


        private DateTime localObservationDateTime;
        public DateTime LocalObservationDateTime
        {
            get { return localObservationDateTime; }
            set
            {
                localObservationDateTime = value;
                OnPropertyChanged("LocalObservationDateTime");
            }
        }

        private int epochTime;
        public int EpochTime
        {
            get { return epochTime; }
            set
            {
                epochTime = value;
                OnPropertyChanged("EpochTime");
            }
        }

        private string weatherText;
        public string WeatherText
        {
            get { return weatherText; }
            set
            {
                weatherText = value;
                OnPropertyChanged("WeatherText");
            }
        }

        private int weatherIcon;
        public int WeatherIcon
        {
            get { return weatherIcon; }
            set
            {
                weatherIcon = value;
                OnPropertyChanged("WeatherIcon");
            }
        }

        private bool isDayTime;
        public bool IsDayTime
        {
            get { return isDayTime; }
            set
            {
                isDayTime = value;
                OnPropertyChanged("IsDayTime");
            }
        }

        private Temperature temperature;
        public Temperature Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                OnPropertyChanged("Temperature");
            }
        }

        private RealFeelTemperature realFeelTemperature;
        public RealFeelTemperature RealFeelTemperature
        {
            get { return realFeelTemperature; }
            set
            {
                realFeelTemperature = value;
                OnPropertyChanged("RealFeelTemperature");
            }
        }

        private Precipitation precipitation;

        public Precipitation Precipitation
        {
            get { return precipitation; }
            set
            {
                precipitation = value;
                OnPropertyChanged("Precipitation");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public AccuWeather()
        {
                Temperature = new Temperature()
                {
                    Imperial = new Imperial()
                    {
                        Value = 82,
                        Unit = "F",
                        UnitType = 22
                    }
                };

                RealFeelTemperature = new RealFeelTemperature()
                {
                    Imperial = new Imperial()
                    {
                        Value = 100,
                        Unit = "F",
                        UnitType = 22
                    }
                };

                Precipitation = new Precipitation()
                {
                    Imperial = new Imperial()
                    {
                        Value = 25,
                        Unit = "%",
                        UnitType = 22
                    }
                };

                WeatherText = "Sunny";
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
