using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestSignerSignerDecisionField {
        [JsonPropertyName("type")]
        public SignRequestSignerSignerDecisionFieldTypeField Type { get; }

        [JsonPropertyName("finalized_at")]
        public string FinalizedAt { get; }

        public SignRequestSignerSignerDecisionField(SignRequestSignerSignerDecisionFieldTypeField type, string finalizedAt) {
            Type = type;
            FinalizedAt = finalizedAt;
        }
    }
}