using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eProdaja.MobileApp.ViewModels
{
    public class NarudzbaViewModel
    {
        public ObservableCollection<ProizvodiDetailViewModel> NarudzbaList { get; set; } = new ObservableCollection<ProizvodiDetailViewModel>();

        public void Init()
        {
            NarudzbaList.Clear();

            foreach (var cartValue in CartService.Cart.Values)
            {
                NarudzbaList.Add(cartValue);
            }
        }
    }
}
