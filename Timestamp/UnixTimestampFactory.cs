using System;

namespace Timestamp
{
    /// <summary>
    /// Timestamp factory.
    /// </summary>
    public abstract class UnixTimestampFactory<T> : TimestampFactory<T>        
    {
        private readonly DateTime unixEpoch = DateTime.UnixEpoch.ToUniversalTime();

        /// <summary>
        /// Time in Utc for which timestamp is zero which is <see cref="DateTime.UnixEpoch"/>.
        /// </summary>
        protected override DateTime Zero => unixEpoch;
    }
}
