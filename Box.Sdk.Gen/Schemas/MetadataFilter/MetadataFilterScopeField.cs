using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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