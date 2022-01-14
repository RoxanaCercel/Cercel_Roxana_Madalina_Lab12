﻿using Cercel_Roxana_Madalina_Lab12.Services;
using Cercel_Roxana_Madalina_Lab12.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cercel_Roxana_Madalina_Lab12.Data;

namespace Cercel_Roxana_Madalina_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
