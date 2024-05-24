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
        [InlineData("icH bIn glückLICH", 3)]
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

        [Theory]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        [InlineData("This is a single sentence.", 1)]
        [InlineData("This is the first sentence. This is the second one! Is this the third? Yes, it is.", 4)]
        [InlineData("First sentence.\nSecond sentence!\nThird sentence?", 3)]
        [InlineData("First sentence.   Second sentence!  Third sentence?   ", 3)]
        [InlineData("First sentence.Second sentence!Third sentence?", 3)]
        [InlineData("This is a sentence with a Mr Smith. And here's another one! Finally, this is the last one?", 3)]
        public void GetSentencesCount_WhenInput_SentencesShouldBeCount(string input, int count)
        {
            // Execute
            var result = TextCase.GetSentencesCount(input);

            // Assert
            var expected = count;
            var actual = result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        [InlineData("This is a single paragraph.", 1)]
        [InlineData("This is the first paragraph.\n\nThis is the second paragraph.\n\nThis is the third paragraph.", 3)]
        [InlineData("First paragraph.\r\n\r\nSecond paragraph.\r\n\r\nThird paragraph.", 3)]
        [InlineData("First paragraph.  \n\n  Second paragraph!  \n\n  Third paragraph?  ", 3)]
        [InlineData("First paragraph.\nSecond paragraph!  \n\nThird paragraph?", 2)]
        [InlineData("First paragraph.\n\n\nSecond paragraph!\n\n\n\nThird paragraph?", 3)]
        public void GetParagraphsCount_VariousInputs_ReturnsExpectedResult(string input, int expected)
        {
            // Act
            int result = TextCase.GetParagraphsCount(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
