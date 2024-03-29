﻿using eProdaja.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class LogimViewModel :BaseViewModel
    {
        private readonly APIService _service = new APIService("JediniceMjere");
        public LogimViewModel()
        {
            LoginCommand = new Command(async () => await Login()); 
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                await _service.Get<dynamic>(null);

                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
