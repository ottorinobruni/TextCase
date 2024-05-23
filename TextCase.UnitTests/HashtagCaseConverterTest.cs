using System;
using TextCase.Converters;
using TextCase.Extensions;
using Xunit;

namespace TextCase.UnitTests
{
    public class HashTagCaseConverterTest
    {
        [Theory]
        [InlineData("hello world", "#hello #world")]
        [InlineData("icH bIn glückLICH", "#icH #bIn #glückLICH")]
        [InlineData(" che ore sono? ", "#che #ore #sono?")]
        [InlineData("Today i am happy\nToday i am happy", "#Today #i #am #happy\n#Today #i #am #happy")]
        public void Convert_WhenHashTagCase_TextShouldBeHashTagCase(string input, string output)
        {
            // Setup
            var service = new HashTagCaseConverter();

            // Execute
            var convertedText = service.Convert(input);

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello world", "#hello #world")]
        [InlineData("icH bIn glückLICH", "#icH #bIn #glückLICH")]
        [InlineData(" che ore sono? ", "#che #ore #sono?")]
        [InlineData("Today i am happy\nToday i am happy", "#Today #i #am #happy\n#Today #i #am #happy")]
        public void ToHashTagCase_WhenHashTagCase_TextShouldBeHashTagCase(string input, string output)
        {
            // Execute
            var convertedText = input.ToHashTagCase();

            // Assert
            var expected = output;
            var actual = convertedText;
            Assert.Equal(expected, actual);
        }
    }
}