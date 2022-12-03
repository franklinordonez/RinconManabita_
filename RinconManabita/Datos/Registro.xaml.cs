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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text ;
            string apallido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;

        }
    }
}