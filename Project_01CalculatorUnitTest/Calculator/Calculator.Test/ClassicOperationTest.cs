using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Test
{
   public class ClassicOperationTest
    {
        [Fact]
        public void IsEven_ValueTest_Whenpassing_EvenNumber()
        {
            //Arrange
            ClassicProgram classicProgram = new ClassicProgram();
            bool Expected = true;

            // Act
            bool actual = classicProgram.IsEven(10);

            // Aseert
            Assert.Equal(actual, Expected);

        }
        [Fact]
        public void IsOdd_ValueTest_Whenpassing_OddNumber()
        {
            //Arrange
            ClassicProgram classicProgram = new ClassicProgram();
            bool Expected = true;

            // Act
            bool actual = classicProgram.IsOdd(11);

            // Aseert
            Assert.Equal(actual, Expected);

        }
        [Fact]
        public void IsPrimeNumber_Test_Whenpassing_Number()
        {
            //Arrange
            ClassicProgram classicProgram = new ClassicProgram();
            bool Expected = true;

            // Act
            bool actual = classicProgram.IsPrime(11);

            // Aseert
            Assert.Equal(actual, Expected);

        }
    }
}
