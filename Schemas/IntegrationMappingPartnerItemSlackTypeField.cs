using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<IntegrationMappingPartnerItemSlackTypeField>))]
    public enum IntegrationMappingPartnerItemSlackTypeField {
        [Description("channel")]
        Channel
    }
}