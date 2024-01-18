using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataCascadePolicyOwnerEnterpriseTypeField>))]
    public enum MetadataCascadePolicyOwnerEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}