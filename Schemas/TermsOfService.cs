using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TermsOfService : TermsOfServiceBase {
        [JsonPropertyName("status")]
        public TermsOfServiceStatusField Status { get; }

        [JsonPropertyName("enterprise")]
        public TermsOfServiceEnterpriseField Enterprise { get; }

        [JsonPropertyName("tos_type")]
        public TermsOfServiceTosTypeField TosType { get; }

        [JsonPropertyName("text")]
        public string Text { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        public TermsOfService(string id, TermsOfServiceBaseTypeField type, TermsOfServiceStatusField status, TermsOfServiceEnterpriseField enterprise, TermsOfServiceTosTypeField tosType, string text, string createdAt, string modifiedAt) : base(id, type) {
            Status = status;
            Enterprise = enterprise;
            TosType = tosType;
            Text = text;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}