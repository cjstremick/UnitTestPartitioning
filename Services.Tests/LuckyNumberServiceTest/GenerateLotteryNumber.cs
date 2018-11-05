using System.Linq;
using NSubstitute;
using Services.NumberGenerators;
using Xunit;

namespace Services.Tests.LuckyNumberServiceTest
{
    public partial class LuckyNumberServiceTest
    {
        [Fact]
        public void GenerateLotteryNumber_Returns_Five_Numbers()
        {
            // Arrange
            var numberGeneratorMock = Substitute.For<INumberGenerator>();
            var subject = new LuckyNumberService(numberGeneratorMock);

            // Act
            var result = subject.GenerateLotteryNumber();

            // Assert
            Assert.Equal(5, result.Count());
        }

    }
}