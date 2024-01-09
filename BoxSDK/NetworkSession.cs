using System.Collections.Generic;
using DictionaryExtensions;

namespace Box
{
    /// <summary>
    /// NetworkSession holding parameters for the network connection like retry strategy.
    /// </summary>
    public class NetworkSession
    {
        /// <summary>
        /// Additional headers, which are appended to each API request
        /// </summary>
        public Dictionary<string, string> AdditionalHeaders { get; }

        /// <summary>
        /// Custom base urls.
        /// </summary>
        public BaseUrls BaseUrls { get; } = new BaseUrls();

        /// <summary>
        /// Number of request retries.
        /// </summary>
        public int RetryAttempts { get; }

        /// <summary>
        /// IRetryStrategy used when retrying http/s request.
        /// </summary>
        public IRetryStrategy RetryStrategy { get; }

        public NetworkSession(Dictionary<string, string>? additionalHeaders = default, int retryAttempts = 5, IRetryStrategy? retryStrategy = null, BaseUrls? baseUrls = null)
        {
            AdditionalHeaders = additionalHeaders ?? new Dictionary<string, string>();
            RetryAttempts = retryAttempts;
            RetryStrategy = retryStrategy ?? new ExponentialBackoffRetryStrategy();
            BaseUrls = baseUrls ?? new BaseUrls();
        }

        /// <summary>
        /// Generate a fresh network session by duplicating the existing configuration and network parameters,
        /// while also including additional headers to be attached to every API call.
        /// </summary>
        /// <param name="additionalHeaders">
        /// Map of headers, which are appended to each API request
        /// </param>
        public NetworkSession WithAdditionalHeaders(Dictionary<string, string> additionalHeaders) {
            return new NetworkSession(DictionaryUtils.MergeDictionaries(this.AdditionalHeaders, additionalHeaders), this.RetryAttempts, this.RetryStrategy, this.BaseUrls);
        }

        /// <summary>
        /// Generate a fresh network session by duplicating the existing configuration and network parameters,
        /// while using custom base urls for the API calls.
        /// </summary>
        /// <param name="baseUrls">
        /// Custom base urls.
        /// </param>
        public NetworkSession WithCustomBaseUrls(BaseUrls baseUrls) {
            return new NetworkSession(this.AdditionalHeaders, this.RetryAttempts, this.RetryStrategy, baseUrls);
        }
    }
}
