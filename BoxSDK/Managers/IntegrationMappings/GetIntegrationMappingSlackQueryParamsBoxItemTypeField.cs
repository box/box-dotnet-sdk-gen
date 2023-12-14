using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetIntegrationMappingSlackQueryParamsBoxItemTypeField>))]
    public enum GetIntegrationMappingSlackQueryParamsBoxItemTypeField {
        [Description("folder")]
        Folder
    }
}