﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Converter
{
    class YesNoToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Yes":return true;
                case "No": return false;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
            {
                if ((bool)value == true) return "Yes";
                else return "No";
            }
            return "No";
        }
    }
}
