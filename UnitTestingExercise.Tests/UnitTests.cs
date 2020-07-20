using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1,3)]
        [InlineData(1, -1, 1, 1)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(100, 1000, 10000, 11100)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            int actual = sut.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(0, 1, -1)]
        [InlineData(200, 100, 100)]
        [InlineData(-10, -10, 0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            var actual = sut.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,1)]
        [InlineData(0, 100, 0)]
        [InlineData(-10, 10, -100)]
        [InlineData(10, 10, 100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            int actual = sut.Multiply(num1, num2);


            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10 ,2, 5)]
        [InlineData(-10, 2, -5)]
        [InlineData(1000, 20, 50)]
        [InlineData(10000, 20, 500)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            int actual = sut.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FrisbeeThrowing()
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            var actual = sut.FrisbeeThrowing();

            //Assert
            Assert.Equal("Throw Frisbee", actual);
        }

        [Fact]
        public void PayItForward()
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            var actual = sut.PayItForward();

            //Assert
            Assert.Equal("Make someones day!", actual);
        }
    }
}
