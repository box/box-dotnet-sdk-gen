using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataCascadePolicyScopeField>))]
    public enum MetadataCascadePolicyScopeField {
        [Description("global")]
        Global,
        [Description("enterprise_*")]
        Enterprise
    }
}