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
	public partial class Dplatos : ContentPage
	{
		public Dplatos ()
		{
			InitializeComponent ();
		}

        private void btnbebidas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Datos.Dbebidas());
        }
    }
}