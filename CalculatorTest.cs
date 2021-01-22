using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Test
{
   
    public  class CalculatorTest
    {
        Calculator calculator = new Calculator();
        [Fact]
        public void ShouldAddTwoNumber()
        {
            //Arrange
            int number1 = 10;
            int number2 = 15;
            int expected = 25;
            //Act 
           
            int actual = calculator.Add(number1, number2);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldSubtract()
        {
            // Arranage
            int number1 = 20;
            int number2 = 15;
            int expected = 5;
            //Act
            int actual = calculator.Subtract(number1, number2);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldMulTwoNumber()
        {
            //Arrange
            int number1 = 5;
            int number2 = 4;
            int expected = 20;
            //Act
          int actual=  calculator.Mul(number1, number2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
