﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Hub.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var IsValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (IsValid && dateTime > DateTime.Now);
        }
    }
}