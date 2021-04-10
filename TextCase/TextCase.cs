using System;
using TextCase.Converters;
using TextCase.Extensions;

namespace TextCase
{
    public enum Case
    {
        UpperCase,
        LowerCase,
        TitleCase,
        CapitaliseCase,
        CapitaliseWordsCase,
        ReverseCase,
        AlternateCase,
        CamelCase,
        PascalCase,
        KebabCase,
        SnackCase,
        HashtagCase
    }

    public static class TextCase
    {
        public static string Convert(string text, Case textCase)
        {
            return TextCaseFactory.GetCaseConverter(textCase).Convert(text);
        }

        public static int GetTextCount(string text)
        {
            return text.GetTextCount();
        }
    }
}
