using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using RinconManabita.Modelo;

namespace RinconManabita.Modelo
{
    public class LocalizacionViewModel:LocalizacionMode
    {
        public Command LocalizameCommand { get; set; }
        public LocalizacionViewModel()
        {
            LocalizameCommand = new Command(Localizar);
        }
        private async void Localizar()
        {
            try
            {
                var localizacion = await Geolocation.GetLastKnownLocationAsync();
                if (localizacion == null)
                {
                    localizacion = await Geolocation.GetLocationAsync(new GeolocationRequest()
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(25)
                    });
                }
                if (localizacion == null)
                {
                    Error = "No se donde estoy";
                }
                else
                {
                    Longitud = localizacion.Longitude;
                    Latitud = localizacion.Latitude;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }

        }
    }
}