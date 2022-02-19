using System;
using LeetCodeSolutions;
using Xunit;
using FluentAssertions;
namespace LeetCodeTests
{
    public class TwoSumTests
    {
        TwoSumProblem romanToIntClass;
        [Fact]
        public void Returns1And0()
        {
            //Arrange
            romanToIntClass = new TwoSumProblem();
            //Act
            int[] result = romanToIntClass.TwoSum(new int[] { 2, 7, 11, 15}, 9);
            //Assert
            result.Should().Contain(new int[] { 0, 1});
        }
        [Fact]
        public void Returns2And1()
        {
            //Arrange
            romanToIntClass = new TwoSumProblem();
            //Act
            int[] result = romanToIntClass.TwoSum(new int[] { 3, 2, 4 }, 6);
            //Assert
            result.Should().Contain(new int[] { 2, 1 });
        }
        [Fact]
        public void Returns1And0ForSix()
        {
            //Arrange
            romanToIntClass = new TwoSumProblem();
            //Act
            int[] result = romanToIntClass.TwoSum(new int[] { 3, 3}, 6);
            //Assert
            result.Should().Contain(new int[] { 0, 1 });
        }
    }
}
