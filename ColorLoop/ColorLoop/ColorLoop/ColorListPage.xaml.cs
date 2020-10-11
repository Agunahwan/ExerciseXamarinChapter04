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
    public partial class ColorListPage : ContentPage
    {
        public ColorListPage()
        {
            Padding = new Thickness(5, 5, 5, 5);
            double fontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            Content = new StackLayout
            {
                Spacing = 0,
                Children =
                {
                    new Label
                    {
                        Text="White",
                        TextColor=Color.White,
                        FontSize=fontSize
                    },
                    new Label
                    {
                        Text="Silver",
                        TextColor=Color.Silver,
                        FontSize=fontSize
                    },
                    new Label
                    {
                        Text="Fuchsia",
                        TextColor=Color.Fuchsia,
                        FontSize=fontSize
                    },
                    new Label
                    {
                        Text="Purple",
                        TextColor=Color.Purple,
                        FontSize=fontSize
                    }
                }
            };
        }
    }
}