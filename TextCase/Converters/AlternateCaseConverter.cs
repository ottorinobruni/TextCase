﻿using System;
using System.Globalization;
using System.Text;
using TextCase.Extensions;

namespace TextCase.Converters
{
    /// <summary>
    /// Represents a title converter
    /// </summary>
    public class AlternateCaseConverter : ICaseConverter
    {
        /// <summary>
        /// Converts the specified text to alternate case.
        /// </summary>
        /// <param name="text">The string to convert to alternate case.</param>
        /// <returns>The specified text converted to alternate case.</returns>
        public string Convert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            var isUpper = true;

            foreach (var c in text)
            {
                if (!char.IsWhiteSpace(c))
                {
                    builder.Append(isUpper ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c));
                    isUpper = !isUpper;
                }
                else
                {
                    builder.Append(' ');
                }
            }

            return builder.ToString();
        }
    }
}
