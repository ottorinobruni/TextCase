using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class CamelCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "helloWorld")]
        [InlineData("icH bIn glückLICH", "ichBinGlücklich")]
        [InlineData("  che ore sono? ", "cheOreSono?")]
        [InlineData("Enter \"your text here...root = true\n\n[*.{csproj,props,targets}]\"", "enter\"YourTextHere...Root=True\n\n[*.{Csproj,Props,Targets}]\"")]
        public void Convert_WhenCamelCase_TextShouldBeCamelCase(string input, string output)
        {
            // Setup
            var service = new CamelCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "helloWorld")]
        [InlineData("icH bIn glückLICH", "ichBinGlücklich")]
        [InlineData("  che ore sono? ", "cheOreSono?")]
        [InlineData("Enter \"your text here...root = true\n\n[*.{csproj,props,targets}]\"", "enter\"YourTextHere...Root=True\n\n[*.{Csproj,Props,Targets}]\"")]
        public void ToCamelCase_WhenCamelCase_TextShouldBeCamelCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToCamelCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}