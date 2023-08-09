using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataCascadePolicyOwnerEnterpriseField {
        [JsonPropertyName("type")]
        public MetadataCascadePolicyOwnerEnterpriseFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public MetadataCascadePolicyOwnerEnterpriseField(MetadataCascadePolicyOwnerEnterpriseFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}