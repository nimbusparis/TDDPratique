using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD.Pratique.Demo_GREEN
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

    }

    public class FizzBuzz
    {
        public string Next(int value)
        {
            throw new NotImplementedException();
            #region Soluce
            return "1";
            #endregion
        }
    }
}
