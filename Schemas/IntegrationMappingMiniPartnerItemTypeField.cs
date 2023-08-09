using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<IntegrationMappingMiniPartnerItemTypeField>))]
    public enum IntegrationMappingMiniPartnerItemTypeField {
        [Description("channel")]
        Channel
    }
}