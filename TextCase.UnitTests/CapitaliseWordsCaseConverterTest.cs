using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class CapitalizeWordsCaseConverterTest
    {
        [Theory]
        [InlineData("Hello World", "Hello World")]
        [InlineData("ICH BIN GLÜCKLICH", "Ich Bin Glücklich")]
        [InlineData("  che ore SONO? ", "  Che Ore Sono? ")]
        public void Convert_WhenCapitalizeCase_TextShouldBeCapitalizeCase(string input, string output)
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
        public void ToCapitalizeWordsCase_WhenCapitalizeCase_TextShouldBeCapitalizeCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToCapitalizeWordsCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}