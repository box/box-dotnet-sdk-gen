using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<IntegrationMappingBaseIntegrationTypeField>))]
    public enum IntegrationMappingBaseIntegrationTypeField {
        [Description("slack")]
        Slack
    }
}