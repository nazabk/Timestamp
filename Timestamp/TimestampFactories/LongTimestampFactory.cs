namespace Timestamp
{
    /// <summary>
    /// Time stamp factory.
    /// </summary>
    /// <remarks>Generate timestamps as number of clock ticks elapsed since
    /// begining of the century: 2001-01-01 UTC.</remarks>
    public class LongTimestampFactory : TimestampFactory<long>
    {
        /// <inheritdoc/>
        protected override long FromTicks(long ticks) => ticks;

        /// <inheritdoc/>
        protected override long Ticks(long timestamp) => timestamp;
    }
}
