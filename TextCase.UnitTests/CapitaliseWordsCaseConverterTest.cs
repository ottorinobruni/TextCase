using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class CapitaliseWordsCaseConverterTest
    {
        [Theory]
        [InlineData("Hello World", "Hello World")]
        [InlineData("ICH BIN GLÜCKLICH", "Ich Bin Glücklich")]
        [InlineData("  che ore SONO? ", "  Che Ore Sono? ")]
        public void Convert_WhenCapitaliseCase_TextShouldBeCapitaliseCase(string input, string output)
        {
            // Setup
            var service = new CapitaliseWordsCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello World", "Hello World")]
        [InlineData("ICH BIN GLÜCKLICH", "Ich Bin Glücklich")]
        [InlineData("  che ore SONO? ", "  Che Ore Sono? ")]
        public void ToCapitaliseWordsCase_WhenCapitaliseCase_TextShouldBeCapitaliseCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToCapitaliseWordsCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}