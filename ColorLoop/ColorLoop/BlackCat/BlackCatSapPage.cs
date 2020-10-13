﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace BlackCat
{
    class BlackCatSapPage : ContentPage
    {
        public BlackCatSapPage()
        {
            StackLayout mainStack = new StackLayout();
            StackLayout textStack = new StackLayout
            {
                Padding = new Thickness(5),
                Spacing = 10
            };

            // Get access to the text resource.
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            string resource = "ColorLoop.Texts.TheBlackCat.txt";

            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        resource = "BlackCat.iOS.Texts.TheBlackCat.txt";
            //        break;
            //    case Device.Android:
            //        resource = "BlackCat.Droid.Texts.TheBlackCat.txt";
            //        break;
            //    case Device.UWP:
            //        resource = "BlackCat.UWP.Texts.TheBlackCat.txt";
            //        break;
            //}
#if __IOS__
            resource = "BlackCat.iOS.Texts.TheBlackCat.txt";
#elif __ANDROID__
            resource = "BlackCat.Droid.Texts.TheBlackCat.txt";
#elif WINDOWS_UWP
            resource = "BlackCat.UWP.Texts.TheBlackCat.txt";
#endif

            using (Stream stream = assembly.GetManifestResourceStream(resource))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    bool gotTitle = false;
                    string line;

                    // Read in a line (which is actually a paragraph).
                    while (null != (line = reader.ReadLine()))
                    {
                        Label label = new Label
                        {
                            Text = line,

                            // Black text for ebooks!
                            TextColor = Color.Black
                        };

                        if (!gotTitle)
                        {
                            // Add first label (the title) to mainStack.
                            label.HorizontalOptions = LayoutOptions.Center;
                            label.FontSize = Device.GetNamedSize(NamedSize.Medium, label);
                            label.FontAttributes = FontAttributes.Bold;
                            mainStack.Children.Add(label);
                            gotTitle = true;
                        }
                        else
                        {
                            // Add subsequent labels to textStack.
                            textStack.Children.Add(label);
                        }
                    }
                }
            }

            // Put the textStack in a ScrollView with FillAndExpand.
            ScrollView scrollView = new ScrollView
            {
                Content = textStack,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 0),
            };

            // Add the ScrollView as a second child of mainStack.
            mainStack.Children.Add(scrollView);

            // Set page content to mainStack.
            Content = mainStack;

            // White background for ebooks!
            BackgroundColor = Color.White;

            // Add some iOS padding for the page
            Padding = new Thickness(0, Device.RuntimePlatform == Device.iOS ? 20 : 0, 0, 0);
        }
    }
}
