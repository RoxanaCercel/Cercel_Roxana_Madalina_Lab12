﻿using Cercel_Roxana_Madalina_Lab12.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Cercel_Roxana_Madalina_Lab12.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
