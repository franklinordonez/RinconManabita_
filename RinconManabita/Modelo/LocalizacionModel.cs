using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Xamarin.Forms;

namespace RinconManabita.Modelo
{
	public class LocalizacionMode : INotifyPropertyChanged
    {
        private string error;

        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
        private double longitud;

        public double Longitud
        {
            get { return longitud; }
            set
            {
                longitud = value;
                OnPropertyChanged();
            }
        }
        private double latitud;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Latitud
        {
            get { return latitud; }
            set
            {
                latitud = value;
                OnPropertyChanged();
            }
        }
    }
}