﻿using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class ProizvodiDetailViewModel : BaseViewModel
    {
        public ProizvodiDetailViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            NaruciCommand = new Command(() => Naruci());
        }
        public Proizvod Proizvod { get; set; }

        decimal _kolicina = 0;
        public decimal Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }

        public ICommand NaruciCommand { get; set; }

        public void Naruci()
        {
            if (CartService.Cart.ContainsKey(Proizvod.ProizvodId))
            {
                CartService.Cart.Remove(Proizvod.ProizvodId);
            }
            CartService.Cart.Add(Proizvod.ProizvodId, this);
        }
    }
}
