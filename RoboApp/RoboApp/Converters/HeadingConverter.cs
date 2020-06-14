using System;
using System.Globalization;
using RoboApp.Enums;
using RoboApp.Helpers.Extensions;
using Xamarin.Forms;

namespace RoboApp.Converters
{
    public class HeadingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int Mtype = (int)value;

            MotorType motortype = (MotorType)Enum.Parse(typeof(MotorType), Mtype.ToString());
            string Motor = "";

            Motor = motortype.GetMotorDescription();

            return Motor;
        }



        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return 0;
        }
    }

}
