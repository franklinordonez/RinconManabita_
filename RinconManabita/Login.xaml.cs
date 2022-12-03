using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RinconManabita
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "fordonez";
            string contrasena = "123456789";
            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContrasena.Text;
            if (usuario == tUsuario & contrasena == tContrasena)
            {
                
                Navigation.PushAsync(new Datos.Dplatos());
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO NO EXISITE", "Cerrar");
            }


        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Datos.Registro());
        }
    }
}