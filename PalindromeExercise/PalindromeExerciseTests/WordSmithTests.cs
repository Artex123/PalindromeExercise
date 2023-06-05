using PalindromeExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordSmithTests
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("tattarrattat", true)]
        [InlineData("deified", true)]
        [InlineData("mississippi", false)]
        [InlineData("antifungal", false)]
        
        
        public void IsAPalindrome_Test(string word, bool expected)
        {
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }

    }
}
