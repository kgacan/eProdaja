using eProdaja.MobileApp.ViewModels;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.MobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProizvodDetailPage : ContentPage
	{
        private ProizvodiDetailViewModel model = null;
		public ProizvodDetailPage (Proizvod Proizvod)
		{
			InitializeComponent ();
            BindingContext = model = new ProizvodiDetailViewModel
            {
                Proizvod = Proizvod
            };
		}
	}
}