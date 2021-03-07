using CamelCase;
using System;
using Xunit;

namespace CamelCase.Tests
{
    public class CamelCaseTests
    {
        [Theory]
        [InlineData("one", 1)]
        [InlineData("oneTwo", 2)]
        [InlineData("twojStaryWiniary", 3)]
        public void CountWordsTest(string name, int expectedNoOfWords)
        {
            int actual = CamelCase.CountWords(name);

            Assert.Equal(expectedNoOfWords, actual);
        }
    }
}
