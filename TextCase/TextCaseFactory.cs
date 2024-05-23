using System;
using TextCase.Converters;

namespace TextCase
{
    internal static class TextCaseFactory
    {
        internal static ICaseConverter GetCaseConverter(Case textCase)
        {
            return textCase switch
            {
                Case.UpperCase => new UpperCaseConverter(),
                Case.LowerCase => new LowerCaseConverter(),
                Case.TitleCase => new TitleCaseConverter(),
                Case.CapitalizeCase => new CapitaliseCaseConverter(),
                Case.CapitalizeWordsCase => new CapitaliseWordsCaseConverter(),
                Case.ReverseCase => new ReverseCaseConverter(),
                Case.AlternateCase => new AlternateCaseConverter(),
                Case.CamelCase => new CamelCaseConverter(),
                Case.PascalCase => new PascalCaseConverter(),
                Case.KebabCase => new KebabCaseConverter(),
                Case.SnackCase => new SnackCaseConverter(),
                Case.HashTagCase => new HashTagCaseConverter(),
                Case.ConstantCase => new ConstantCaseConverter(),
                Case.CobolCase => new CobolCaseConverter(),
                Case.TrainCase => new TrainCaseConverter(),
                Case.InverseCase => new InverseCaseConverter(),
                _ => throw new ArgumentException("No valid TextCase"),
            };
        }
    }
}
