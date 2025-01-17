﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace NETworkManager.Converters;

public sealed class BooleanToStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null && (bool) value)
            return Localization.Resources.Strings.Yes;

        return Localization.Resources.Strings.No;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
