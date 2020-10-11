using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorLoop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SizedBoxViewPage : ContentPage
    {
        public SizedBoxViewPage()
        {
            BackgroundColor = Color.Pink;

            Content = new BoxView
            {
                Color = Color.Navy,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 200,
                HeightRequest = 100
            };
        }
    }
}