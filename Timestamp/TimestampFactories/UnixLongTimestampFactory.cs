namespace Timestamp
{
    /// <summary>
    /// Time stamp factory.
    /// </summary>
    /// <remarks>Generate timestamps as number of clock ticks elapsed since January 1st, 1970 at UTC.</remarks>
    public class UnixLongTimestampFactory : UnixTimestampFactory<long>
    {
        /// <inheritdoc/>
        protected override long FromTicks(long ticks) => ticks;

        /// <inheritdoc/>
        protected override long Ticks(long timestamp) => timestamp;
    }
}
