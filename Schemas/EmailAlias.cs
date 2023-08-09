using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class EmailAlias {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public EmailAliasTypeField Type { get; }

        [JsonPropertyName("email")]
        public string Email { get; }

        [JsonPropertyName("is_confirmed")]
        public bool? IsConfirmed { get; }

        public EmailAlias(string id, EmailAliasTypeField type, string email, bool? isConfirmed) {
            Id = id;
            Type = type;
            Email = email;
            IsConfirmed = isConfirmed;
        }
    }
}