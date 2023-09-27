
namespace Box
{
    /// <summary>
    /// NetworkSession holding parameters for the network connection like retry strategy.
    /// </summary>
    public class NetworkSession
    {
        /// <summary>
        /// Number of request retries.
        /// </summary>
        public int RetryAttempts { get; }

        /// <summary>
        /// IRetryStrategy used when retrying http/s request.
        /// </summary>
        public IRetryStrategy RetryStrategy { get; }

        public NetworkSession(int retryAttempts = 5, IRetryStrategy? retryStrategy = null)
        {
            RetryAttempts = retryAttempts;
            RetryStrategy = retryStrategy ?? new ExponentialBackoffRetryStrategy();
        }
    }
}
