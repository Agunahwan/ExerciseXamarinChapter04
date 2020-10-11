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
            //MainPage = new ColorListPage();
            MainPage = new ReflectedColorsPage();
            //MainPage = new VerticalOptionsDemoPage();
            //MainPage = new FramedTextPage();
            //MainPage = new SizedBoxViewPage();
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
