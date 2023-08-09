using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public RetentionPolicyBaseTypeField Type { get; }

        public RetentionPolicyBase(string id, RetentionPolicyBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}