using System;
using NSubstitute;
using Services.NumberGenerators;
using Xunit;

namespace Services.Tests.LuckyNumberServiceTest
{
    public partial class LuckyNumberServiceTest
    {
        [Fact]
        public void GenerateFavoriteNumber_Returns_Generated_Number()
        {
            // Arrange
            var numberGeneratorMock = Substitute.For<INumberGenerator>();
            numberGeneratorMock.GetRandom(Arg.Any<int>(), Arg.Any<int>()).Returns(13);
            var subject = new LuckyNumberService(numberGeneratorMock);

            // Act
            var result = subject.GenerateFavoriteNumber();

            // Assert
            Assert.Equal(13, result);
        }

        [Fact]
        public void GenerateFavoriteNumber_Throws_ArgumentException_When_Min_Is_Greater_Then_Max()
        {
            // Arrange
            var numberGeneratorMock = Substitute.For<INumberGenerator>();
            var subject = new LuckyNumberService(numberGeneratorMock);

            // Act
            void Action()
            {
                subject.GenerateFavoriteNumber(10, 1);
            }

            // Assert
            Assert.Throws<ArgumentException>(() => Action());
        }

        [Fact]
        public void GenerateFavoriteNumber_Throws_ArgumentOutOfRangeException_When_Max_Is_Greater_Then_100()
        {
            // Arrange
            var numberGeneratorMock = Substitute.For<INumberGenerator>();
            var subject = new LuckyNumberService(numberGeneratorMock);

            // Act
            void Action()
            {
                subject.GenerateFavoriteNumber(1, 101);
            }

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Action());
        }

        [Fact]
        public void GenerateFavoriteNumber_Throws_ArgumentOutOfRangeException_When_Min_Is_Less_Then_1()
        {
            // Arrange
            var numberGeneratorMock = Substitute.For<INumberGenerator>();
            var subject = new LuckyNumberService(numberGeneratorMock);

            // Act
            void Action()
            {
                subject.GenerateFavoriteNumber(-1);
            }

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Action());
        }
    }
}