using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<IntegrationMappingBoxItemSlackTypeField>))]
    public enum IntegrationMappingBoxItemSlackTypeField {
        [Description("folder")]
        Folder
    }
}