using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp_Part1__
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.LoginPage();
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
