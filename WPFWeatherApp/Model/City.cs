using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFWeatherApp.Model
{
    public class Country : INotifyPropertyChanged
    {
        private string localizedName;

        public string LocalizedName
        {
            get { return localizedName; }
            set
            {
                localizedName = value;
                OnPropertyChanged("LocalizedName");
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

    public class AdministrativeArea : INotifyPropertyChanged
    {
        private string localizedName;

        public string LocalizedName
        {
            get { return localizedName; }
            set
            {
                localizedName = value;
                OnPropertyChanged("LocalizedName");
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

    public class City : INotifyPropertyChanged
    {
        private string localizedName;

        public string LocalizedName
        {
            get
            {
                return localizedName;
            }
            set
            {
                localizedName = value;
                OnPropertyChanged("LocalizedName");
            }
        }


        private Country country;

        public Country Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        
        private AdministrativeArea administrative;

        public AdministrativeArea AdministrativeArea
        {
            get { return administrative; }
            set
            {
                administrative = value;
                OnPropertyChanged("AdministrativeArea");
            }
        }


        private string key;

        public string Key
        {
            get { return key; }
            set
            {
                key = value;
                OnPropertyChanged("Key");
            }
        }


        public City()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                localizedName = "LocalName";
                Country = new Country()
                {
                    LocalizedName = "Country_Name"
                };

                AdministrativeArea = new AdministrativeArea()
                {
                    LocalizedName = "Admin_location"
                };
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
