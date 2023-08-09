using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class AccessToken {
        [JsonPropertyName("access_token")]
        public string AccessTokenField { get; }

        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; }

        [JsonPropertyName("token_type")]
        public AccessTokenTokenTypeField TokenType { get; }

        [JsonPropertyName("restricted_to")]
        public IReadOnlyList<FileScope> RestrictedTo { get; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; }

        [JsonPropertyName("issued_token_type")]
        public AccessTokenIssuedTokenTypeField IssuedTokenType { get; }

        public AccessToken(string accessTokenField, int? expiresIn, AccessTokenTokenTypeField tokenType, IReadOnlyList<FileScope> restrictedTo, string refreshToken, AccessTokenIssuedTokenTypeField issuedTokenType) {
            AccessTokenField = accessTokenField;
            ExpiresIn = expiresIn;
            TokenType = tokenType;
            RestrictedTo = restrictedTo;
            RefreshToken = refreshToken;
            IssuedTokenType = issuedTokenType;
        }
    }
}