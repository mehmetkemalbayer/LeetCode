using System;
using Xunit;
using LeetCodeSolutions;
namespace LeetCodeTests
{
    public class ValidParenthesesTests
    {
        public ValidParenthesesTests()
        {
        }
        ValidParentheses problem = new ValidParentheses();
        [Fact]
        public void ReturnsTrue1()
        {
            string input = "()";
            bool result = problem.IsValid(input);
            Assert.True(result);
        }
        [Fact]
        public void ReturnsTrue2()
        {
            string input = "()[]{}";
            bool result = problem.IsValid(input);
            Assert.True(result);
        }
        [Fact]
        public void ReturnsFalse()
        {
            string input = "(]";
            bool result = problem.IsValid(input);
            Assert.False(result);
        }
        [Fact]
        public void ReturnsTrue3()
        {
            string input = "{[]}";
            bool result = problem.IsValid(input);
            Assert.True(result);
        }
        [Fact]
        public void ReturnsFalse2()
        {
            string input = "[";
            bool result = problem.IsValid(input);
            Assert.False(result);
        }
        [Fact]
        public void ReturnsFalse3()
        {
            string input = "]";
            bool result = problem.IsValid(input);
            Assert.False(result);
        }
    }
}
