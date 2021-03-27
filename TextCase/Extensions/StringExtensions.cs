﻿using System;
using System.Globalization;

namespace TextCase.Extensions
{
    public static class StringExtensions
    {
        public static string ToFirstLetterUpperCase(this string value)
        {
            var firstPart = value.Trim().Substring(0, 1).ToUpperInvariant();
            var secondPart = value.Trim().Length > 1 ? value.Trim()[1..].ToLowerInvariant() : "";
            return String.Format("{0}{1}", firstPart, secondPart);
        }

        public static string ToTitleCase(this string value)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(value);
        }
    }
}