using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TermsOfServiceEnterpriseField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public TermsOfServiceEnterpriseFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public TermsOfServiceEnterpriseField(string id, TermsOfServiceEnterpriseFieldTypeField type, string name) {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}