using System;
using TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class PascalCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "HelloWorld")]
        [InlineData("icH bIn glückLICH", "IchBinGlücklich")]
        [InlineData("  che ore sono? ", "CheOreSono?")]
        public void Convert_WhenPascalCase_TextShouldBePascalCase(string input, string output)
        {
            // Setup
            var service = new PascalCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}