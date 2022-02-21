using System;
using Xunit;
using LeetCodeSolutions;
namespace LeetCodeTests
{
    public class MaxSubArrayTests
    {
        MaxSubArrayProblem problem;
        public MaxSubArrayTests()
        {
            problem = new MaxSubArrayProblem();
        }
        [Fact]
        public void Returns6 ()
        {
            int result =problem.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.Equal(6, result);
        }
        [Fact]
        public void Returns1()
        {
            int result = problem.MaxSubArray(new int[] {1});
            Assert.Equal(1, result);
        }
        [Fact]
        public void Returns23()
        {
            int result = problem.MaxSubArray(new int[] { 5, 4, -1, 7, 8 });
            Assert.Equal(23, result);
        }
        [Fact]
        public void Returns1_2()
        {
            int result = problem.MaxSubArray(new int[] { -2, 1 });
            Assert.Equal(1, result);
        }
        [Fact]
        public void ReturnsMinus1()
        {
            int result = problem.MaxSubArray(new int[] { -1 });
            Assert.Equal(-1, result);
        }
        [Fact]
        public void ReturnsMinus1_2()
        {
            int result = problem.MaxSubArray(new int[] { -2, -1 });
            Assert.Equal(-1, result);
        }
        [Fact]
        public void ReturnsMinus1_3()
        {
            int result = problem.MaxSubArray(new int[] { -1, -2 });
            Assert.Equal(-1, result);
        }
    }
}
