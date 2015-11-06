using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IValueConverterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void StoplightButton_Click(object sender, RoutedEventArgs e)
        {
            Button stopLightButton = (Button)sender;
            ImageBrush sentImage = (ImageBrush)stopLightButton.Background;
            BitmapImage buttonImage = (BitmapImage)sentImage.ImageSource;

            if (buttonImage.UriSource.ToString()
                .Equals(@"ms-appx:/Assets/Icon/GrayLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            {
                ((ImageBrush)stopLightButton.Background).ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/RedLightTransBack.png"));
            }
            else if (buttonImage.UriSource.ToString()
                .Equals(@"ms-appx:/Assets/Icon/RedLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            {
                ((ImageBrush)stopLightButton.Background).ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/YellowLightTransBack.png"));
            }
            else if (buttonImage.UriSource.ToString()
                .Equals(@"ms-appx:/Assets/Icon/YellowLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            {
                ((ImageBrush)stopLightButton.Background).ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/GreenLightTransBack.png"));
            }
            else if (buttonImage.UriSource.ToString()
                .Equals(@"ms-appx:/Assets/Icon/GreenLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            {
                ((ImageBrush)stopLightButton.Background).ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/GrayLightTransBack.png"));
            }

            //Button stopLightButton = (Button)sender;
            //ImageBrush sentImage = (ImageBrush)stopLightButton.Background;
            //BitmapImage buttonImage = (BitmapImage)sentImage.ImageSource;

            //if (buttonImage.UriSource.ToString()
            //    .Equals(@"ms-appx:/Assets/Icon/GrayLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    var brush = new ImageBrush();
            //    brush.ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/RedLightTransBack.png"));
            //    stopLightButton.Background = brush;
            //}
            //else if (buttonImage.UriSource.ToString()
            //    .Equals(@"ms-appx:/Assets/Icon/RedLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    var brush = new ImageBrush();
            //    brush.ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/YellowLightTransBack.png"));
            //    stopLightButton.Background = brush;
            //}
            //else if (buttonImage.UriSource.ToString()
            //    .Equals(@"ms-appx:/Assets/Icon/YellowLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    var brush = new ImageBrush();
            //    brush.ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/GreenLightTransBack.png"));
            //    stopLightButton.Background = brush;
            //}
            //else if (buttonImage.UriSource.ToString()
            //    .Equals(@"ms-appx:/Assets/Icon/GreenLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    var brush = new ImageBrush();
            //    brush.ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/GrayLightTransBack.png"));
            //    stopLightButton.Background = brush;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(IB.ImageSource);
            //IB.ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/RedLightTransBack.png"));
            //System.Diagnostics.Debug.WriteLine(((BitmapImage)IB.ImageSource).UriSource);

            //var brush = new ImageBrush();
            //brush.ImageSource = new BitmapImage(new Uri(@"ms-appx:/Assets/Icon/GrayLightTransBack.png"));
            //StoplightButton.Background = brush;
        }
    }
}