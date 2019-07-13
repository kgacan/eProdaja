using eProdaja.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.MobileApp
{
    public static class CartService
    {
        public static Dictionary<int, ProizvodiDetailViewModel> Cart { get; set; } = new Dictionary<int, ProizvodiDetailViewModel>();
    }
}
