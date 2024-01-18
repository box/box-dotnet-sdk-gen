using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FileFullExpiringEmbedLinkField {
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
        public FileFullExpiringEmbedLinkTokenTypeField? TokenType { get; set; } = default;

        /// <summary>
        /// The permissions that this access token permits,
        /// providing a list of resources (files, folders, etc)
        /// and the scopes permitted for each of those resources.
        /// </summary>
        [JsonPropertyName("restricted_to")]
        public IReadOnlyList<FileOrFolderScope>? RestrictedTo { get; set; } = default;

        /// <summary>
        /// The actual expiring embed URL for this file, constructed
        /// from the file ID and access tokens specified in this object.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; } = default;

        public FileFullExpiringEmbedLinkField() {
            
        }
    }
}