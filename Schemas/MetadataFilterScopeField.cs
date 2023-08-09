using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataFilterScopeField>))]
    public enum MetadataFilterScopeField {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise,
        [Description("enterprise_{enterprise_id}")]
        EnterpriseEnterpriseId
    }
}