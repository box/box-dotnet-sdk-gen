using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataCascadePolicyTypeField>))]
    public enum MetadataCascadePolicyTypeField {
        [Description("metadata_cascade_policy")]
        MetadataCascadePolicy
    }
}