using System;
using Timestamp;
using Xunit;

namespace XUnitTestTimestamp
{
    public class UnitTestToDateTime
    {
        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void DateTimeShort(DateTimeKind kind)
        {
            // Arrange
            var factory = new TimestampFactory();
            var z = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            // Act
            if (z.Kind != kind) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);
            var zero = factory.ToDateTime(0, kind);

            // Assert
            Assert.Equal(kind, zero.Kind);
            Assert.Equal(z, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void DateTimeLong(DateTimeKind kind)
        {
            // Arrange
            var factory = new LongTimestampFactory();
            var z = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            // Act
            if (z.Kind != kind) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);
            var zero = factory.ToDateTime(0, kind);

            // Assert
            Assert.Equal(kind, zero.Kind);
            Assert.Equal(z, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void DateTimeUnix(DateTimeKind kind)
        {
            // Arrange
            var factory = new UnixTimestampFactory();
            var z = DateTime.UnixEpoch.ToUniversalTime();

            // Act
            if (z.Kind != kind) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);
            var zero = factory.ToDateTime(0, kind);

            // Assert
            Assert.Equal(kind, zero.Kind);
            Assert.Equal(z, zero);
        }

        [Theory]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        [InlineData(DateTimeKind.Utc)]
        public void DateTimeUnixLong(DateTimeKind kind)
        {
            // Arrange
            var factory = new UnixLongTimestampFactory();
            var z = DateTime.UnixEpoch.ToUniversalTime();

            // Act
            if (z.Kind != kind) z = z.ToLocalTime();
            if (kind == DateTimeKind.Unspecified) z = DateTime.SpecifyKind(z, DateTimeKind.Unspecified);
            var zero = factory.ToDateTime(0, kind);

            // Assert
            Assert.Equal(kind, zero.Kind);
            Assert.Equal(z, zero);
        }
    }
}
