using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextCase.Extensions
{
    public static class StringExtensions
    {
        internal static string ToFirstLetterUpperCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            value = value.Trim();
            return char.ToUpperInvariant(value[0]) + value.Substring(1).ToLowerInvariant();
        }
        
        /// <summary>
        /// Gets the number of characters in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of characters in the current string.</returns>
        internal static int GetTextCount(this string value)
        {
            return value?.Length ?? 0;
        }

        /// <summary>
        /// Gets the number of words in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of words in the current string.</returns>
        internal static int GetWordsCount(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return 0;
            }

            var words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        /// <summary>
        /// Gets the number of letters in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of letters in the current string.</returns>
        internal static int GetLettersCount(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return 0;
            }

            return value.Count(char.IsLetter);
        }

        /// <summary>
        /// Gets the number of sentences in the current String value.
        /// </summary>
        /// <param name="value">The string to count.</param>
        /// <returns>The number of sentences in the current string.</returns>
        internal static int GetSentencesCount(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return 0;
            }

            // Split sentences based on common sentence-ending punctuation marks.
            var sentenceSeparators = new char[] { '.', '!', '?' };
            var sentences = value.Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries)
                .Where(sentence => !string.IsNullOrWhiteSpace(sentence))
                .ToArray();

            return sentences.Length;
        }
        
        /// <summary>
        /// Converts the specified string to uppercase using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="value">The string to convert to uppercase case.</param>
        /// <returns>The specified text converted to uppercase case.</returns>
        public static string ToUpperCase(this string value)
        {
            return TextCase.Convert(value, Case.UpperCase);
        }

        /// <summary>
        /// Converts the specified string to lowercase using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="value">The string to convert to lowercase case.</param>
        /// <returns>The specified text converted to lowercase case.</returns>
        public static string ToLowerCase(this string value)
        {
            return TextCase.Convert(value, Case.LowerCase);
        }

        /// <summary>
        /// Converts the specified text to title case.
        /// </summary>
        /// <param name="value">The string to convert to title case.</param>
        /// <returns>The specified text converted to title case.</returns>
        public static string ToTitleCase(this string value)
        {
            return TextCase.Convert(value, Case.TitleCase);
        }

        /// <summary>
        /// Converts the specified text to capitalise case.
        /// </summary>
        /// <param name="value">The string to convert to capitalise case.</param>
        /// <returns>The specified text converted to capitalise case.</returns>
        public static string ToCapitaliseCase(this string value)
        {
            return TextCase.Convert(value, Case.CapitaliseCase);
        }
        
        /// <summary>
        /// Converts the specified text to capitalise words case.
        /// </summary>
        /// <param name="value">The string to convert to capitalise words case.</param>
        /// <returns>The specified text converted to capitalise words case.</returns>
        public static string ToCapitaliseWordsCase(this string value)
        {
            return TextCase.Convert(value, Case.CapitaliseWordsCase);
        }

        /// <summary>
        /// Converts the specified string to reverse case
        /// </summary>
        /// <param name="value">The string to convert to reverse case.</param>
        /// <returns>The specified text converted to reverse case.</returns>
        public static string ToReverseCase(this string value)
        {
            return TextCase.Convert(value, Case.ReverseCase);
        }

        /// <summary>
        /// Converts the specified text to alternate case.
        /// </summary>
        /// <param name="value">The string to convert to alternate case.</param>
        /// <returns>The specified text converted to alternate case.</returns>
        public static string ToAlternateCase(this string value)
        {
            return TextCase.Convert(value, Case.AlternateCase);
        }

        /// <summary>
        /// Converts the specified text to camel case.
        /// </summary>
        /// <param name="value">The string to convert to camel case.</param>
        /// <returns>The specified text converted to camel case.</returns>
        public static string ToCamelCase(this string value)
        {
            return TextCase.Convert(value, Case.CamelCase);
        }

        /// <summary>
        /// Converts the specified text to pascal case.
        /// </summary>
        /// <param name="value">The string to convert to pascal case.</param>
        /// <returns>The specified text converted to pascal case.</returns>
        public static string ToPascalCase(this string value)
        {
            return TextCase.Convert(value, Case.PascalCase);
        }

        /// <summary>
        /// Converts the specified text to kebab case.
        /// </summary>
        /// <param name="value">The string to convert to kebab case.</param>
        /// <returns>The specified text converted to kebab case.</returns>
        public static string ToKebabCase(this string value)
        {
            return TextCase.Convert(value, Case.KebabCase);
        }

        /// <summary>
        /// Converts the specified text to snack case.
        /// </summary>
        /// <param name="value">The string to convert to snack case.</param>
        /// <returns>The specified text converted to snack case.</returns>
        public static string ToSnackCase(this string value)
        {
            return TextCase.Convert(value, Case.SnackCase);
        }
    }
}
