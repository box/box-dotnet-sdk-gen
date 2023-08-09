using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<IntegrationMappingMiniBoxItemTypeField>))]
    public enum IntegrationMappingMiniBoxItemTypeField {
        [Description("folder")]
        Folder
    }
}