using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Test
{

    public class CalculatorTest 
    {

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { 1, 2, 3 },
            new object[] { -4, -6, -10 },
            new object[] { -2, 2, 0 },       
        };

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
        [InlineData(20,30,-10)]
        public void Subtract_TwoNumber_ShouldReturn_20_3_10(double x,double y,double expected)


        {
            //Arrange
            //Act
           double actual= calculator.Subtract(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }

        
        [Theory]
        [MemberData(nameof(Data))]
        public  void CanAddTheoryMemberDataProperty(double value1,double value2,double expected)
        {
            // Arrange
            //Act
            double actual = calculator.Add(value1, value2);

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

        [Theory]
        [MemberData(nameof(CalculatorData.Data), MemberType = typeof(CalculatorData))]
        public void CanAddTheoryMemberDataMethod(int value1, int value2, int expected)
        {
         
            var result = calculator.Add(value1, value2);

            Assert.Equal(expected, result);
        }
        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void CanAddTheoryClassData(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.Add(value1, value2);

            Assert.Equal(expected, result);
        }

    }
    public class CalculatorData
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
            new object[] { 1, 2, 3 },
            new object[] { -4, -6, -10 },
            new object[] { -2, 2, 0 },
            new object[] { int.MinValue,  int.MaxValue, -1},
            };
    }
    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { -4, -6, -10 };
            yield return new object[] { -2, 2, 0 };
            yield return new object[] { 50, 60, 110 };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
