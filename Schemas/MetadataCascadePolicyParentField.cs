using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataCascadePolicyParentField {
        [JsonPropertyName("type")]
        public MetadataCascadePolicyParentFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public MetadataCascadePolicyParentField(MetadataCascadePolicyParentFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}