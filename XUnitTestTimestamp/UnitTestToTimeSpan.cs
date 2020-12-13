using System;
using Timestamp;
using Xunit;

namespace XUnitTestTimestamp
{
    public class UnitTestToTimeSpan
    {
        [Fact]
        public void TimeShort()
        {
            // Arrange
            var factory = new TimestampFactory();

            // Act
            var zero = factory.ToTimeSpan(0);

            // Assert
            Assert.Equal(TimeSpan.Zero, zero);
        }

        [Fact]
        public void TimeLong()
        {
            // Arrange
            var factory = new LongTimestampFactory();

            // Act
            var zero = factory.ToTimeSpan(0);

            // Assert
            Assert.Equal(TimeSpan.Zero, zero);
        }

        [Fact]
        public void TimeUnix()
        {
            // Arrange
            var factory = new UnixTimestampFactory();

            // Act
            var zero = factory.ToTimeSpan(0);

            // Assert
            Assert.Equal(TimeSpan.Zero, zero);
        }

        [Fact]
        public void TimeUnixLong()
        {
            // Arrange
            var factory = new UnixLongTimestampFactory();

            // Act
            var zero = factory.ToTimeSpan(0);

            // Assert
            Assert.Equal(TimeSpan.Zero, zero);
        }
    }
}
