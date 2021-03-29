using System;
using TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class CamelCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "helloWorld")]
        [InlineData("icH bIn glückLICH", "ichBinGlücklich")]
        [InlineData("  che ore sono? ", "cheOreSono?")]
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
    }
}