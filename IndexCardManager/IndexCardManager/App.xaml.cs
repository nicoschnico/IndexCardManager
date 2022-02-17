using IndexCardManager.Models;
using IndexCardManager.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndexCardManager
{
    public partial class App : Application
    {
        public static NavigationPage Navigation { get; set; }
        public App()
        {
            InitializeComponent();

            Navigation = new NavigationPage(new MainPage());
            MainPage = Navigation;
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
