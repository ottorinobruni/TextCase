using System;
using TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class TitleCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "Hello World")]
        [InlineData("icH bIn glückLICH", "Ich Bin Glücklich")]
        [InlineData("  che ore sono? ", "  Che Ore Sono? ")]
        [InlineData("UNICEF and children", "UNICEF And Children")]
        public void Convert_WhenTitleCase_TextShouldBeTitleCase(string input, string output)
        {
            // Setup
            var service = new TitleCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}