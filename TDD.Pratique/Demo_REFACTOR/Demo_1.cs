using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD.Pratique.Demo_REFACTOR
{
    public class Demo_1
    {

        [Fact]
        public void FizzBuzz_return_1()
        {
            // Arrange

            var sut = new FizzBuzz();
            // Act
            var result = sut.Next(1);
            // Assert
            Assert.Equal("1", result);

        }
        [Fact]
        public void FizzBuzz_return_2()
        {
            // Arrange

            var sut = new FizzBuzz();
            // Act
            var result = sut.Next(2);
            // Assert
            Assert.Equal("2", result);

        }
        [Fact]
        public void FizzBuzz_return_Fizz()
        {
            // Arrange

            var sut = new FizzBuzz();
            // Act
            var result = sut.Next(3);
            // Assert
            Assert.Equal("Fizz", result);

        }
        #region Soluce
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        public void FizzBuzz_Theory(int value, string expected)
        {
            // Arrange

            var sut = new FizzBuzz();
            // Act
            var result = sut.Next(value);
            // Assert
            Assert.Equal(expected, result);

        }
        #endregion
    }

    public class FizzBuzz
    {
        public string Next(int value)
        {
            switch (value)
            {
                case 1:
                    return "1";
                case 2:
                    return "2";
                case 3:
                    return "Fizz";
                default:
                    return "";
            }
            #region Soluce
            switch (value)
            {
                case 1:
                case 2:
                    return value.ToString();
                case 3:
                    return "Fizz";
                default:
                    return "";
            }
            #endregion
        }
    }
}
