using System;

namespace Timestamp
{
    /// <summary>
    /// Time stamp factory.
    /// </summary>
    /// <remarks>Generate timestamps as number of seconds elapsed since
    /// begining of the century: 2001-01-01 UTC.</remarks>
    public class TimestampFactory : TimestampFactory<int>
    {
        /// <inheritdoc/>
        protected override int FromTicks(long ticks) => Convert.ToInt32(ticks / TimeSpan.TicksPerSecond);

        /// <inheritdoc/>
        protected override long Ticks(int timestamp) => timestamp * TimeSpan.TicksPerSecond;
    }
}
