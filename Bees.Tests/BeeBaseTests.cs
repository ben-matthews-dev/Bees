using Bees.Core;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Bees.Tests
{
    public class BeeBaseTests
    {
        private QueenBee _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new QueenBee();
        }

        [Test]
        public void Damage_StatusTypeIsDead_Return()
        {
            // Arrange
            _sut.StatusType = StatusType.Dead;

            // Act
            _sut.Damage(1);

            // Assert
            Assert.AreEqual(100, _sut.Health);
        }

        [Test]
        public void Damage_InvalidMiniusPercentageArgument_Return()
        {
            // Arrange
            var expectedValue = 1f;
            _sut.Health = expectedValue;

            // Act
            _sut.Damage((int)-expectedValue);

            // Assert
            Assert.AreEqual(expectedValue, _sut.Health);
            Assert.AreEqual(StatusType.Alive, _sut.StatusType);
        }

        [Test]
        public void Damage_InvalidPercentageArgument_Return()
        {
            // Arrange
            var expectedValue = 101f;
            _sut.Health = expectedValue;

            // Act
            _sut.Damage((int)expectedValue);

            // Assert
            Assert.AreEqual(expectedValue, _sut.Health);
            Assert.AreEqual(StatusType.Alive, _sut.StatusType);
        }

        [Test]
        public void Damage_ValidPercentageArgument_ReduceHealth()
        {
            // Arrange
            var percentage = 1;
            var expectedValue = _sut.Health * (100 - percentage) / 100;

            // Act
            _sut.Damage(percentage);

            // Assert
            Assert.AreEqual(expectedValue, _sut.Health);
            Assert.AreEqual(StatusType.Alive, _sut.StatusType);
        }

        [Test]
        public void Damage_ValidPercentageArgument_StatusTypeIsDead()
        {
            // Arrange
            var percentage = (int)_sut.Health - (_sut.PronouncedDeadPercentage - 1);
            var expectedValue = _sut.Health * (100 - percentage) / 100;

            // Act
            _sut.Damage(percentage);

            // Assert
            Assert.AreEqual(expectedValue, _sut.Health);
            Assert.AreEqual(StatusType.Dead, _sut.StatusType);
        }
    }
}