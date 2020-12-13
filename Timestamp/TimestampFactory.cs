using System;

namespace Timestamp
{
    /// <summary>
    /// Timestamp factory.
    /// </summary>
    public abstract class TimestampFactory<T> : ITimestampFactory<T>
    {
        private readonly DateTime centuryBegin = new DateTime(2001, 01, 01, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Time in Utc for which timestamp is zero which is begining of the century: 2001-01-01.
        /// </summary>
        protected virtual DateTime Zero => centuryBegin;

        /// <summary>
        /// Time for which timestamp is zero.
        /// </summary>
        /// <param name="kind">DateTime kind.</param>
        /// <returns><see cref="DateTime"/> for zero timestamp.</returns>
        public DateTime GetZero(DateTimeKind kind = default) =>
            kind == DateTimeKind.Utc ? Zero :
            kind == DateTimeKind.Local ?
            Zero.ToLocalTime() :
            DateTime.SpecifyKind(Zero.ToLocalTime(), DateTimeKind.Unspecified);

        /// <summary>
        /// Generate time stamp based on given value.
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> value.</param>
        /// <returns>Time stamp.</returns>
        public T Create(DateTime dateTime) =>
            dateTime.Kind == DateTimeKind.Utc ?
            FromTicks(dateTime.Ticks - Zero.Ticks) :
            FromTicks(dateTime.ToUniversalTime().Ticks - Zero.Ticks);

        /// <summary>
        /// Generate time stamp based on given value.
        /// </summary>
        /// <param name="timeSpan"><see cref="TimeSpan"/> value.</param>
        /// <returns>Time stamp.</returns>
        public T Create(TimeSpan timeSpan) => FromTicks(timeSpan.Ticks);

        /// <summary>
        /// Generate <see cref="DateTime"/> value based on given time stamp.
        /// </summary>
        /// <param name="timestamp">Time stamp value.</param>
        /// <param name="kind">Kind of <see cref="DateTime"/> to be generated.</param>
        /// <returns><see cref="DateTime"/> value.</returns>
        public DateTime ToDateTime(T timestamp, DateTimeKind kind = default)
        {
            var result = new DateTime(Ticks(timestamp) + Zero.Ticks, DateTimeKind.Utc);

            return kind == DateTimeKind.Utc ?
                result :
                kind == DateTimeKind.Local ?
                result.ToLocalTime() :
                DateTime.SpecifyKind(result.ToLocalTime(), DateTimeKind.Unspecified);
        }

        /// <summary>
        /// Generate <see cref="TimeSpan"/> value based on given time stamp.
        /// </summary>
        /// <param name="timestamp">Time stamp value.</param>
        /// <returns><see cref="DateTime"/> value.</returns>
        public TimeSpan ToTimeSpan(T timestamp) => TimeSpan.FromTicks(Ticks(timestamp));

        /// <summary>
        /// Converts time stamp to clock ticks.
        /// </summary>
        /// <param name="timestamp">Time stamp value.</param>
        /// <returns>Clock ticks.</returns>
        protected abstract long Ticks(T timestamp);

        /// <summary>
        /// Generates clock ticks from time stamp.
        /// </summary>
        /// <param name="ticks">Clock ticks.</param>
        /// <returns>Time stamp value.</returns>
        protected abstract T FromTicks(long ticks);
    }
}
