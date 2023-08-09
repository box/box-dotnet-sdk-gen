using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class EnterpriseBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public EnterpriseBaseTypeField Type { get; }

        public EnterpriseBase(string id, EnterpriseBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}