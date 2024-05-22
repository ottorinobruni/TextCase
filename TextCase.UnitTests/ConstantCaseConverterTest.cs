using TextCase.Converters;
using TextCase.Converters.TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class ConstantCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "HELLO_WORLD")]
        [InlineData("icH bIn glückLICH", "ICH_BIN_GLÜCKLICH")]
        [InlineData("indent_style = space, 2-\nindent_size = 2", "INDENT_STYLE_SPACE_2\nINDENT_SIZE_2")]
        public void Convert_WhenConstantCase_TextShouldBeConstantCase(string input, string expected)
        {
            // Setup
            var service = new ConstantCaseConverter();

            // Execute
            var actual = service.Convert(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}