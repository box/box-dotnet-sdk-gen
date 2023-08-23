using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullExpiringEmbedLinkField {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; }

        [JsonPropertyName("expires_in")]
        public long? ExpiresIn { get; }

        [JsonPropertyName("token_type")]
        public FileFullExpiringEmbedLinkFieldTokenTypeField TokenType { get; }

        [JsonPropertyName("restricted_to")]
        public IReadOnlyList<FileScope> RestrictedTo { get; }

        [JsonPropertyName("url")]
        public string Url { get; }

        public FileFullExpiringEmbedLinkField(string accessToken, long? expiresIn, FileFullExpiringEmbedLinkFieldTokenTypeField tokenType, IReadOnlyList<FileScope> restrictedTo, string url) {
            AccessToken = accessToken;
            ExpiresIn = expiresIn;
            TokenType = tokenType;
            RestrictedTo = restrictedTo;
            Url = url;
        }
    }
}