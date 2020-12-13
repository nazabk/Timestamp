using System;

namespace Timestamp
{
    /// <summary>
    /// Time stamp factory.
    /// </summary>
    /// <remarks>Generate timestamps as number of seconds elapsed since January 1st, 1970 at UTC.</remarks>
    public class UnixTimestampFactory : UnixTimestampFactory<int>
    {
        /// <inheritdoc/>
        protected override int FromTicks(long ticks) => Convert.ToInt32(ticks / TimeSpan.TicksPerSecond);

        /// <inheritdoc/>
        protected override long Ticks(int timestamp) => timestamp * TimeSpan.TicksPerSecond;
    }
}
