using System;
using TextCase.Converters;
using TextCase.Extensions;
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
        
        [Theory]
        [InlineData("Hello World", "Hello world")]
        [InlineData("ICH BIN GLÜCKLICH", "Ich bin glücklich")]
        [InlineData("  che ore SONO? ", "Che ore sono?")]
        public void ToCapitaliseCase_WhenCapitaliseCase_TextShouldBeCapitaliseCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToCapitaliseCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
        
    }
}