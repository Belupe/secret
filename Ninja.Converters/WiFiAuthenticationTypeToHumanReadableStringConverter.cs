﻿using System;
using System.Globalization;
using System.Windows.Data;
using Windows.Networking.Connectivity;
using Ninja.Models.Network;

namespace Ninja.Converters
{
    using Models.Network;

    public sealed class WiFiAuthenticationTypeToHumanReadableStringConverter : IValueConverter
    {
        /* Translate the name of the accent */
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not NetworkAuthenticationType type
                ? "-/-"
                : $"{WiFi.GetHumanReadableNetworkAuthenticationType(type)}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}