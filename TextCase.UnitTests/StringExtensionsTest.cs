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
        public void GetTextCount_WhenInput_TextShouldBeCount(string input, int count)
        {
            // Execute
            var result = TextCase.GetTextCount(input);

            // Assert
            var expected = count;
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("hello world", 2)]
        [InlineData("icH bIn glückLICH", 4)]
        [InlineData(" che ore sono? ", 3)]
        public void GetWordsCount_WhenInput_WordsShouldBeCount(string input, int count)
        {
            // Execute
            var result = TextCase.GetWordsCount(input);

            // Assert
            var expected = count;
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("hello world", 10)]
        [InlineData("icH bIn glückLICH", 15)]
        [InlineData(" che ore sono? ", 10)]
        public void GetLettersCount_WhenInput_LettersShouldBeCount(string input, int count)
        {
            // Execute
            var result = TextCase.GetLettersCount(input);

            // Assert
            var expected = count;
            var actual = result;
            Assert.Equal(expected, actual);
        }
    }
}
