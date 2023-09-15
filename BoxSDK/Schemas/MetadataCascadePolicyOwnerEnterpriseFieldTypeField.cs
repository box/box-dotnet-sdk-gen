using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataCascadePolicyOwnerEnterpriseFieldTypeField>))]
    public enum MetadataCascadePolicyOwnerEnterpriseFieldTypeField {
        [Description("enterprise")]
        Enterprise
    }
}