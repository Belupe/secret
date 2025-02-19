﻿using System;
using System.Globalization;
using System.Windows.Data;
using Ninja.Localization;
using Ninja.Profiles;

namespace Ninja.Converters
{
    using Localization;
    using Profiles;

    /// <summary>
    ///     Convert <see cref="ProfileName" /> to translated <see cref="string" /> or wise versa.
    /// </summary>
    public sealed class ProfileNameToTranslatedStringConverter : IValueConverter
    {
        /// <summary>
        ///     Convert <see cref="ProfileName" /> to translated <see cref="string" />.
        /// </summary>
        /// <param name="value">Object from type <see cref="ProfileName" />.</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>Translated <see cref="ProfileName" />.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not ProfileName name
                ? "-/-"
                : ResourceTranslator.Translate(new[] { ResourceIdentifier.ProfileName, ResourceIdentifier.ApplicationName },
                    name);
        }

        /// <summary>
        ///     !!! Method not implemented !!!
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}