using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD.Pratique.Demo_GREEN
{
    public class Demo_2
    {

        [Fact]
        public void FizzBuzz_return_1()
        {
            // Arrange

            var sut = new FizzBuzz2();
            // Act
            var result = sut.Next(1);
            // Assert
            Assert.Equal("1", result);

        }

    }

    public class FizzBuzz2
    {
        public string Next(int value)
        {
            switch (value)
            {
                case 1:
                    return "1";
                case 2:
                    return "2";
                default: 
                    return "";
            }
        }
    }
}
