using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingBoxItemSlack {
        /// <summary>
        /// Type of the mapped item referenced in `id`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<IntegrationMappingBoxItemSlackTypeField>))]
        public StringEnum<IntegrationMappingBoxItemSlackTypeField> Type { get; }

        /// <summary>
        /// ID of the mapped item (of type referenced in `type`)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public IntegrationMappingBoxItemSlack(string id, IntegrationMappingBoxItemSlackTypeField type = IntegrationMappingBoxItemSlackTypeField.Folder) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal IntegrationMappingBoxItemSlack(string id, StringEnum<IntegrationMappingBoxItemSlackTypeField> type) {
            Type = IntegrationMappingBoxItemSlackTypeField.Folder;
            Id = id;
        }
    }
}