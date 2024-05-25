using System;
using System.Collections.Generic;
using System.Linq;
using TextCase.Converters;
using TextCase.Extensions;

namespace TextCase
{
    public enum Case
    {
        UpperCase,
        LowerCase,
        TitleCase,
        CapitalizeCase,
        CapitalizeWordsCase,
        ReverseCase,
        AlternateCase,
        CamelCase,
        PascalCase,
        KebabCase,
        SnackCase,
        HashTagCase,
        ConstantCase,
        CobolCase,
        TrainCase,
        InverseCase,
        Base64EncodeCase,
        Base64DecodeCase
    }

    public static class TextCase
    {
        /// <summary>
        /// Convert text to specified case
        /// </summary>
        /// <param name="text">Text to convert</param>
        /// <param name="textCase">Text case to convert</param>
        /// <returns>The converted text</returns>
        public static string Convert(string text, Case textCase)
        {
            return TextCaseFactory.GetCaseConverter(textCase).Convert(text);
        }

        /// <summary>
        /// Get all available cases
        /// </summary>
        /// <returns>Returns all available cases</returns>
        public static IEnumerable<Case> GetAllCases()
        {
            return Enum.GetValues(typeof(Case)).Cast<Case>();
        }

        public static int GetTextCount(string text)
        {
            return text.GetTextCount();
        }

        public static int GetWordsCount(string text)
        {
            return text.GetWordsCount();
        }

        public static int GetLettersCount(string text)
        {
            return text.GetLettersCount();
        }

        public static int GetSentencesCount(string text)
        {
            return text.GetSentencesCount();
        }

        public static int GetParagraphsCount(string text)
        {
            return text.GetParagraphsCount();
        }
    }
}
