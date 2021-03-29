using System;
using TextCase.Converters;
using Xunit;

namespace TextCase.UnitTests
{
    public class HashtagCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "#hello #world")]
        [InlineData("icH bIn glückLICH", "#icH #bIn #glückLICH")]
        [InlineData(" che ore sono? ", "#che #ore #sono?")]
        public void Convert_WhenHashtagCase_TextShouldBeHashtagCase(string input, string output)
        {
            // Setup
            var service = new HashtagCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}