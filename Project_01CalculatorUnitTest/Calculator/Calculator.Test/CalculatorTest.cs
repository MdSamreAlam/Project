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
           
            double actual = calculator.Add(number1, number2);

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
            double actual = calculator.Subtract(number1, number2);

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
          double actual=  calculator.Mul(number1, number2);
            //Assert
            Assert.Equal(expected, actual);
        }
        

        [Theory]
        [InlineData(10,15,25)]
        [InlineData(20,25,45)]
        public void  Add_SimpleValueCalculation(double x,double y,double expected)
        {
            //Arrange
            //Act

          double actual=  calculator.Add(x, y);
            //Assert
            Assert.Equal(actual, expected);
        }
        
        [Theory]
        [InlineData(30,10,20)]
        [InlineData(15,12,3)]
        public void Subtract_TwoNumber_ShouldReturn_20_3(double x,double y,double expected)
        {
            //Arrange
            //Act
           double actual= calculator.Subtract(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ShouldDivideByZero()
        {
            //Arrange
            double expected = 0;
            //Act
            double actual = calculator.Divide(15, 0);
            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
