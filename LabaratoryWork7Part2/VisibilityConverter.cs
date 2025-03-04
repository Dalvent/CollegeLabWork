﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace LabaratoryWork7Part2
{
    class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (bool)value;
            if(boolValue)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibilityValue = (Visibility)value;
            switch (visibilityValue)
            {
                case Visibility.Visible:
                    return true;
                case Visibility.Hidden:
                    return false;
                default:
                    throw new Exception();
            }
        }
    }
}