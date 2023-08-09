using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class LegalHoldPolicyMini {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public LegalHoldPolicyMiniTypeField Type { get; }

        public LegalHoldPolicyMini(string id, LegalHoldPolicyMiniTypeField type) {
            Id = id;
            Type = type;
        }
    }
}