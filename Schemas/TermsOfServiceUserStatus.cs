using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TermsOfServiceUserStatus {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public TermsOfServiceUserStatusTypeField Type { get; }

        [JsonPropertyName("tos")]
        public TermsOfServiceBase Tos { get; }

        [JsonPropertyName("user")]
        public UserMini User { get; }

        [JsonPropertyName("is_accepted")]
        public bool? IsAccepted { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        public TermsOfServiceUserStatus(string id, TermsOfServiceUserStatusTypeField type, TermsOfServiceBase tos, UserMini user, bool? isAccepted, string createdAt, string modifiedAt) {
            Id = id;
            Type = type;
            Tos = tos;
            User = user;
            IsAccepted = isAccepted;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}