using System;
using Xunit;

namespace TextCase.UnitTests
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("hello world", 11)]
        [InlineData("icH bIn glückLICH", 17)]
        [InlineData(" che ore sono? ", 15)]
        public void Convert_WhenSnackCase_TextShouldBeSnackCase(string input, int count)
        {
            // Execute
            var result = TextCase.GetTextCount(input);

            // Assert
            var expected = count;
            var actual = result;
            Assert.Equal(expected, actual);
        }
    }
}
