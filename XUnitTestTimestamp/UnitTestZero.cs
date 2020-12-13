using System;
using Timestamp;
using Xunit;

namespace XUnitTestTimestamp
{
    public class UnitTestZero
    {
        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void Zero(DateTimeKind kind)
        {
            // Arrange
            var factory = new TimestampFactory();
            var z = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            // Act
            var zero = factory.GetZero(kind);
            if (z.Kind != kind) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);

            // Assert
            Assert.Equal(kind, zero.Kind);
            Assert.Equal(z, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void ZeroLong(DateTimeKind kind)
        {
            // Arrange
            var factory = new LongTimestampFactory();
            var z = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            // Act
            var zero = factory.GetZero(kind);
            if (z.Kind != kind) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);

            // Assert
            Assert.Equal(kind, zero.Kind);
            Assert.Equal(z, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void ZeroUnix(DateTimeKind kind)
        {
            // Arrange
            var factory = new UnixTimestampFactory();
            var z = DateTime.UnixEpoch.ToUniversalTime();

            // Act
            var zero = factory.GetZero(kind);
            if (z.Kind != kind) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);

            // Assert
            Assert.Equal(kind, zero.Kind);
            Assert.Equal(z, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void ZeroUnixLong(DateTimeKind kind)
        {
            // Arrange
            var factory = new UnixLongTimestampFactory();
            var z = DateTime.UnixEpoch.ToUniversalTime();

            // Act
            var zero = factory.GetZero(kind);
            if (z.Kind != kind) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);

            // Assert
            Assert.Equal(kind, zero.Kind);
            Assert.Equal(z, zero);
        }
    }
}
