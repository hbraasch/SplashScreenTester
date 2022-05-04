using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplashScreenTester
{
    internal class StartupPage : ContentPage
    {
        Image image;
        public StartupPage()
        {
            Title = "StartupPage";
            BackgroundImageSource = "background.png";


            var button = new Button { Text = "Display image" };
            button.Clicked += (s, e) => { image.IsVisible = true; };
            image = new Image { Source = "background.png", IsVisible = false };


            Content = new VerticalStackLayout { Children = { button, image } };


        }
    }
}
