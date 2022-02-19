using System;
using Xunit;
using LeetCodeSolutions;
namespace LeetCodeTests
{
    public class RomanToIntTests
    {
        RomanToIntProblem romanToIntClass;        
        [Fact]
        public void Returns3ForIII()
        {
            //Arrange
            romanToIntClass = new RomanToIntProblem();
            //Act
            int result = romanToIntClass.RomanToInt("III");
            //Assert
            Assert.True(result == 3);
        }
        [Fact]
        public void Returns58ForLVIII()
        {
            //Arrange
            romanToIntClass = new RomanToIntProblem();
            //Act
            int result = romanToIntClass.RomanToInt("LVIII");
            //Assert
            Assert.Equal(58, result);
        }
        [Fact]
        public void Returns1994ForMCMXCIV()
        {
            //Arrange
            romanToIntClass = new RomanToIntProblem();
            //Act
            int result = romanToIntClass.RomanToInt("MCMXCIV");
            //Assert
            Assert.Equal(1994, result);
        }
        [Fact]
        public void Returns9ForIX()
        {
            //Arrange
            romanToIntClass = new RomanToIntProblem();
            //Act
            int result = romanToIntClass.RomanToInt("IX");
            //Assert
            Assert.Equal(9, result);
        }
    }
}
