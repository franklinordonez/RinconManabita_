using RinconManabita.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RinconManabita.Datos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dbebidas : ContentPage
    {
        public Dbebidas()
        {
            InitializeComponent();
        }

        private void btnPedido_Clicked(object sender, EventArgs e)
        {

        }

        private void btnLocalizacionViewMode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}