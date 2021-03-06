﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppDelivery.Pages.Users;

using Xamarin.Forms;

namespace AppDelivery
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            InitializeComponent();
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Login());

            }
            else
            {
                MainPage = new NavigationPage(new AppDelivery.MainPage());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
