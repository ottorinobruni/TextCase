﻿using TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class ConstantCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "HELLO_WORLD")]
        [InlineData("icH bIn glückLICH", "ICH_BIN_GLÜCKLICH")]
        [InlineData("indent_style = space, 2-\nindent_size = 2", "INDENT_STYLE_SPACE_2\nINDENT_SIZE_2")]
        [InlineData("Hello World!", "HELLO_WORLD")]
        [InlineData("123 test", "123_TEST")]
        [InlineData("test with multiple   spaces", "TEST_WITH_MULTIPLE_SPACES")]
        [InlineData("test_with_underscore", "TEST_WITH_UNDERSCORE")]
        [InlineData("test-with-dash", "TEST_WITH_DASH")]
        [InlineData("test.with.period", "TEST_WITH_PERIOD")]
        [InlineData("test/with/slash", "TEST_WITH_SLASH")]
        [InlineData("test\\with\\backslash", "TEST_WITH_BACKSLASH")]
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