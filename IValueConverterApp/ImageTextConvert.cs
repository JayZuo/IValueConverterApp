using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace IValueConverterApp
{
    public class ImageTextConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string light = value as string;
            switch (light)
            {
                case "Gray":
                    return @"ms-appx:/Assets/Icon/GrayLightTransBack.png";

                case "Green":
                    return @"ms-appx:/Assets/Icon/GreenLightTransBack.png";

                case "Red":
                    return @"ms-appx:/Assets/Icon/RedLightTransBack.png";

                case "Yellow":
                    return @"ms-appx:/Assets/Icon/YellowLightTransBack.png";

                default:
                    return @"ms-appx:/Assets/Icon/GrayLightTransBack.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            //BitmapImage sentImage = ((ImageBrush)value).ImageSource as BitmapImage;
            BitmapImage sentImage = (BitmapImage)value;
            System.Diagnostics.Debug.WriteLine("Convert  " + sentImage.UriSource);
            if (sentImage.UriSource.ToString()
                .Equals(@"ms-appx:/Assets/Icon/GrayLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            {
                return "Gray";
            }
            else if (sentImage.UriSource.ToString()
                .Equals(@"ms-appx:/Assets/Icon/GreenLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            {
                return "Green";
            }
            else if (sentImage.UriSource.ToString()
                .Equals(@"ms-appx:/Assets/Icon/RedLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            {
                return "Red";
            }
            else if (sentImage.UriSource.ToString()
                .Equals(@"ms-appx:/Assets/Icon/YellowLightTransBack.png", StringComparison.CurrentCultureIgnoreCase))
            {
                return "Yellow";
            }

            return null;
        }
    }
}