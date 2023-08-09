using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TermsOfServiceBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public TermsOfServiceBaseTypeField Type { get; }

        public TermsOfServiceBase(string id, TermsOfServiceBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}