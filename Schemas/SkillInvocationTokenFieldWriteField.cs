using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocationTokenFieldWriteField {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; }

        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; }

        [JsonPropertyName("token_type")]
        public SkillInvocationTokenFieldWriteFieldTokenTypeField TokenType { get; }

        [JsonPropertyName("restricted_to")]
        public string RestrictedTo { get; }

        public SkillInvocationTokenFieldWriteField(string accessToken, int? expiresIn, SkillInvocationTokenFieldWriteFieldTokenTypeField tokenType, string restrictedTo) {
            AccessToken = accessToken;
            ExpiresIn = expiresIn;
            TokenType = tokenType;
            RestrictedTo = restrictedTo;
        }
    }
}