using System.Collections.Generic;
using DictionaryExtensions;

namespace Box.Sdk.Gen
{
    /// <summary>
    /// NetworkSession holding parameters for the network connection like retry strategy.
    /// </summary>
    public class NetworkSession
    {
        /// <summary>
        /// Additional headers, which are appended to each API request
        /// </summary>
        public Dictionary<string, string> AdditionalHeaders { get; init; }

        /// <summary>
        /// Custom base urls.
        /// </summary>
        public BaseUrls BaseUrls { get; } = new BaseUrls();

        /// <summary>
        /// Number of request retries.
        /// </summary>
        public int RetryAttempts { get; init; } = 5;

        /// <summary>
        /// IRetryStrategy used when retrying http/s request.
        /// </summary>
        public IRetryStrategy RetryStrategy { get; init; } = new ExponentialBackoffRetryStrategy();

        public NetworkSession(Dictionary<string, string>? additionalHeaders = default, BaseUrls? baseUrls = null)
        {
            AdditionalHeaders = additionalHeaders ?? new Dictionary<string, string>();
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
            return new NetworkSession(DictionaryUtils.MergeDictionaries(this.AdditionalHeaders, additionalHeaders), this.BaseUrls) { RetryAttempts = this.RetryAttempts, RetryStrategy = this.RetryStrategy };
        }

        /// <summary>
        /// Generate a fresh network session by duplicating the existing configuration and network parameters,
        /// while using custom base urls for the API calls.
        /// </summary>
        /// <param name="baseUrls">
        /// Custom base urls.
        /// </param>
        public NetworkSession WithCustomBaseUrls(BaseUrls baseUrls) {
            return new NetworkSession(this.AdditionalHeaders, baseUrls) { RetryAttempts = this.RetryAttempts, RetryStrategy = this.RetryStrategy };
        }
    }
}
