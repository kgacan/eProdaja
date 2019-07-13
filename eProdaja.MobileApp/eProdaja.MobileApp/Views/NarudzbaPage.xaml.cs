using eProdaja.MobileApp.ViewModels;
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
	public partial class NarudzbaPage : ContentPage
	{
        private NarudzbaViewModel model = null;
        public NarudzbaPage ()
		{
			InitializeComponent ();
            BindingContext = model = new NarudzbaViewModel();


		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }
    }
}