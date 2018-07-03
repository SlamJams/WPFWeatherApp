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
        private int _value;
        public int Value
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

    public class AccuWeather : INotifyPropertyChanged
    {

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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
