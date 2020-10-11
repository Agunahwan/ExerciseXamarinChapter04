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
    public partial class FramedTextPage : ContentPage
    {
        public FramedTextPage()
        {
            Padding = new Thickness(20);
            BackgroundColor = Color.Aqua;
            Content = new Frame
            {
                BorderColor = Color.Black,
                BackgroundColor = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "I've been framed!",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    FontAttributes = FontAttributes.Italic,
                    TextColor = Color.Blue
                }
            };
        }
    }
}