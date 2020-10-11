using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorLoop
{
    public partial class App : Application
    {
        public App()
        {
            //MainPage = new ColorLoopPage();
            MainPage = new ColorListPage();
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
