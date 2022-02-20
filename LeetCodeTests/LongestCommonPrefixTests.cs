using System;
using LeetCodeSolutions;
using Xunit;
using FluentAssertions;
namespace LeetCodeTests
{
    public class LongestCommonPrefixTests
    {
        LongestCommonPrefixProblem problem;
        [Fact]
        public void Returnsfl()
        {
            //Arrange
            problem = new LongestCommonPrefixProblem();
            string[] strs = new string[] { "flower", "flow", "flight" };
            //Act
            string result = problem.LongestCommonPrefix(strs);
            //Assert
            Assert.Equal("fl", result);
        }
        [Fact]
        public void Returnsab()
        {
            //Arrange
            problem = new LongestCommonPrefixProblem();
            string[] strs = new string[] { "abab", "aba", "abc" };
            //Act
            string result = problem.LongestCommonPrefix(strs);
            //Assert
            Assert.Equal("ab", result);
        }
        
    }
}
