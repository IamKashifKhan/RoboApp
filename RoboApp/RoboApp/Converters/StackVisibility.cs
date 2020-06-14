using System;
using System.Globalization;
using RoboApp.Enums;
using Xamarin.Forms;

namespace RoboApp.Converters
{
    public class StackVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int Mtype = (int)value;
            if (Mtype == (int)MotorType.Neck)
            {
                return true;
            }
            return false;
        }



        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return 0;
        }
    }
}
