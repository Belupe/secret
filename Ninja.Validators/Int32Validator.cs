﻿using System.Globalization;
using System.Windows.Controls;
using Ninja.Localization.Resources;

namespace Ninja.Validators
{
    public class Int32Validator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return int.TryParse(value as string, out var x) && x > 0
                ? ValidationResult.ValidResult
                : new ValidationResult(false, Strings.EnterValidNumber);
        }
    }
}