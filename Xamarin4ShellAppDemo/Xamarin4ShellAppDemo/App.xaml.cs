using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin4ShellAppDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new MainShell();
            MainPage = new FlyOutMainShell();
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
