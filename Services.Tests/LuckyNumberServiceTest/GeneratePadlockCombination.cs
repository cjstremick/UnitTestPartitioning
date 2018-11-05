using System.Linq;
using NSubstitute;
using Services.NumberGenerators;
using Xunit;

namespace Services.Tests.LuckyNumberServiceTest
{
    public partial class LuckyNumberServiceTest
    {
        [Fact]
        public void GeneratePadlockCombination_Returns_Three_Numbers()
        {
            // Arrange
            var numberGeneratorMock = Substitute.For<INumberGenerator>();
            var subject = new LuckyNumberService(numberGeneratorMock);

            // Act
            var result = subject.GeneratePadlockCombination();

            // Assert
            Assert.Equal(3, result.Count());
        }
    }
}