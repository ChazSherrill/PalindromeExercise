using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("apple", false)]
        [InlineData("abccba", true)]
        public void PalindromeTester(string word, bool expected)
        {
            var smithOWords = new Wordsmith();

            var actual = smithOWords.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
