using System;
using TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class CapitaliseCaseConverterTest
    {
        [Theory]
        [InlineData("Hello World", "Hello world")]
        [InlineData("ICH BIN GLÜCKLICH", "Ich bin glücklich")]
        [InlineData("  che ore SONO? ", "Che ore sono?")]
        public void Convert_WhenCapitaliseCase_TextShouldBeCapitaliseCase(string input, string output)
        {
            // Setup
            var service = new CapitaliseCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}