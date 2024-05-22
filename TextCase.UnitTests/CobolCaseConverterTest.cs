using TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class CobolCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "HELLO-WORLD")]
        [InlineData("icH bIn glückLICH", "ICH-BIN-GLÜCKLICH")]
        [InlineData("indent_style = space, 2-\nindent_size = 2", "INDENT-STYLE-SPACE-2\nINDENT-SIZE-2")]
        [InlineData("Hello World!", "HELLO-WORLD")]
        [InlineData("123 test", "123-TEST")]
        [InlineData("test with multiple   spaces", "TEST-WITH-MULTIPLE-SPACES")]
        [InlineData("test_with_underscore", "TEST-WITH-UNDERSCORE")]
        [InlineData("test-with-dash", "TEST-WITH-DASH")]
        [InlineData("test.with.period", "TEST-WITH-PERIOD")]
        [InlineData("test/with/slash", "TEST-WITH-SLASH")]
        [InlineData("test\\with\\backslash", "TEST-WITH-BACKSLASH")]
        public void Convert_WhenConstantCase_TextShouldBeConstantCase(string input, string expected)
        {
            // Setup
            var service = new CobolCaseConverter();

            // Execute
            var actual = service.Convert(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}