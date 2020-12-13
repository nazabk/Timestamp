using System;

namespace Timestamp
{
    /// <summary>
    /// Timestamp factory.
    /// </summary>
    /// <typeparam name="T">Type of timestamps.</typeparam>
    public interface ITimestampFactory<T>
    {
        /// <summary>
        /// Generate time stamp based on given value.
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> value.</param>
        /// <returns>Time stamp.</returns>
        T Create(DateTime dateTime);

        /// <summary>
        /// Generate time stamp based on given value.
        /// </summary>
        /// <param name="timeSpan"><see cref="TimeSpan"/> value.</param>
        /// <returns>Time stamp.</returns>
        T Create(TimeSpan timeSpan);

        /// <summary>
        /// Time for which timestamp is zero.
        /// </summary>
        /// <param name="kind">DateTime kind.</param>
        /// <returns><see cref="DateTime"/> for zero timestamp.</returns>
        DateTime GetZero(DateTimeKind kind = DateTimeKind.Unspecified);

        /// <summary>
        /// Generate <see cref="DateTime"/> value based on given time stamp.
        /// </summary>
        /// <param name="timestamp">Time stamp value.</param>
        /// <param name="kind">Kind of <see cref="DateTime"/> to be generated.</param>
        /// <returns><see cref="DateTime"/> value.</returns>
        DateTime ToDateTime(T timestamp, DateTimeKind kind = DateTimeKind.Unspecified);

        /// <summary>
        /// Generate <see cref="TimeSpan"/> value based on given time stamp.
        /// </summary>
        /// <param name="timestamp">Time stamp value.</param>
        /// <returns><see cref="DateTime"/> value.</returns>
        TimeSpan ToTimeSpan(T timestamp);
    }
}
