using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SkillInvocationTokenWriteField {
        /// <summary>
        /// The requested access token.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string? AccessTokenField { get; init; }

        /// <summary>
        /// The time in seconds by which this token will expire.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public long? ExpiresIn { get; init; }

        /// <summary>
        /// The type of access token returned.
        /// </summary>
        [JsonPropertyName("token_type")]
        public SkillInvocationTokenWriteTokenTypeField? TokenType { get; init; }

        /// <summary>
        /// The permissions that this access token permits,
        /// providing a list of resources (files, folders, etc)
        /// and the scopes permitted for each of those resources.
        /// </summary>
        [JsonPropertyName("restricted_to")]
        public string? RestrictedTo { get; init; }

        public SkillInvocationTokenWriteField() {
            
        }
    }
}