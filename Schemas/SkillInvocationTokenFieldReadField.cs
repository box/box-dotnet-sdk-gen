using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocationTokenFieldReadField {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; }

        [JsonPropertyName("expires_in")]
        public long? ExpiresIn { get; }

        [JsonPropertyName("token_type")]
        public SkillInvocationTokenFieldReadFieldTokenTypeField TokenType { get; }

        [JsonPropertyName("restricted_to")]
        public string RestrictedTo { get; }

        public SkillInvocationTokenFieldReadField(string accessToken, long? expiresIn, SkillInvocationTokenFieldReadFieldTokenTypeField tokenType, string restrictedTo) {
            AccessToken = accessToken;
            ExpiresIn = expiresIn;
            TokenType = tokenType;
            RestrictedTo = restrictedTo;
        }
    }
}