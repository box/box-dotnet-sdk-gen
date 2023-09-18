using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class AccessToken {
        /// <summary>
        /// The requested access token.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string? AccessTokenField { get; set; } = default;

        /// <summary>
        /// The time in seconds by which this token will expire.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public long? ExpiresIn { get; set; } = default;

        /// <summary>
        /// The type of access token returned.
        /// </summary>
        [JsonPropertyName("token_type")]
        public AccessTokenTokenTypeField? TokenType { get; set; } = default;

        /// <summary>
        /// The permissions that this access token permits,
        /// providing a list of resources (files, folders, etc)
        /// and the scopes permitted for each of those resources.
        /// </summary>
        [JsonPropertyName("restricted_to")]
        public IReadOnlyList<FileScope>? RestrictedTo { get; set; } = default;

        /// <summary>
        /// The refresh token for this access token, which can be used
        /// to request a new access token when the current one expires.
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; } = default;

        /// <summary>
        /// The type of downscoped access token returned. This is only
        /// returned if an access token has been downscoped.
        /// </summary>
        [JsonPropertyName("issued_token_type")]
        public AccessTokenIssuedTokenTypeField? IssuedTokenType { get; set; } = default;

        public AccessToken() {
            
        }
    }
}