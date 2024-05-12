using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<IntegrationMappingTypeField>))]
    public enum IntegrationMappingTypeField {
        [Description("integration_mapping")]
        IntegrationMapping
    }
}