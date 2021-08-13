using TDD.Pratique.Code;
using Xunit;

namespace TDD.Pratique
{
    public class Demo_2
    {

        [Fact]
        public void Test_Trap()
        {
            // Arrange
            var sut = new Connection();
            // Act
            sut.Status = Status.CONNECTED;
            // Assert
            Assert.Equal(Status.CONNECTED, sut.Status);
        }

    }

    public class Connection
    {
        public Status Status { get; set; }
        public Connection()
        {
            
        }
    }
}
