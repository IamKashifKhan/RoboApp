using System;
using System.Globalization;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RoboApp.Converters
{
    public class StackHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            // Orientation (Landscape, Portrait, Square, Unknown)
            var orientation = mainDisplayInfo.Orientation;

            // Rotation (0, 90, 180, 270)
            var rotation = mainDisplayInfo.Rotation;

            // Width (in pixels)
            var width = mainDisplayInfo.Width;

            // Height (in pixels)
            var height = mainDisplayInfo.Height;

            // Screen density

            return height;
        }



        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return 0;
        }
    }
}
