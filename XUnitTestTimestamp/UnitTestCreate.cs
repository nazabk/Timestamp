using System;
using Timestamp;
using Xunit;

namespace XUnitTestTimestamp
{
    public class UnitTestCreate
    {
        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void Create(DateTimeKind kind)
        {
            // Arrange
            var factory = new TimestampFactory();
            var z = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            // Act
            if (kind != DateTimeKind.Utc) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);
            var zero = factory.Create(z);

            // Assert
            Assert.Equal(0, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void CreateLong(DateTimeKind kind)
        {
            // Arrange
            var factory = new LongTimestampFactory();
            var z = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            // Act
            if (kind != DateTimeKind.Utc) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);
            var zero = factory.Create(z);

            // Assert
            Assert.Equal(0, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void CreateUnix(DateTimeKind kind)
        {
            // Arrange
            var factory = new UnixTimestampFactory();
            var z = DateTime.UnixEpoch.ToUniversalTime();

            // Act
            if (kind != DateTimeKind.Utc) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);
            var zero = factory.Create(z);

            // Assert
            Assert.Equal(0, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void CreateUnixLong(DateTimeKind kind)
        {
            // Arrange
            var factory = new UnixLongTimestampFactory();
            var z = DateTime.UnixEpoch.ToUniversalTime();

            // Act
            if (kind != DateTimeKind.Utc) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);
            var zero = factory.Create(z);

            // Assert
            Assert.Equal(0, zero);
        }

        [Fact]
        public void CreateFromeTimeSpan()
        {
            // Arrange
            var factory = new TimestampFactory();

            // Act
            var zero = factory.Create(TimeSpan.Zero);

            // Assert
            Assert.Equal(0, zero);
        }

        [Fact]
        public void LongCreateFromeTimeSpan()
        {
            // Arrange
            var factory = new LongTimestampFactory();

            // Act
            var zero = factory.Create(TimeSpan.Zero);

            // Assert
            Assert.Equal(0, zero);
        }

        [Fact]
        public void UnixCreateFromeTimeSpan()
        {
            // Arrange
            var factory = new UnixTimestampFactory();

            // Act
            var zero = factory.Create(TimeSpan.Zero);

            // Assert
            Assert.Equal(0, zero);
        }

        [Fact]
        public void UnixLongCreateFromeTimeSpan()
        {
            // Arrange
            var factory = new UnixLongTimestampFactory();

            // Act
            var zero = factory.Create(TimeSpan.Zero);

            // Assert
            Assert.Equal(0, zero);
        }
    }
}
