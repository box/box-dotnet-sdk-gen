using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingBoxItemSlack {
        /// <summary>
        /// Type of the mapped item referenced in `id`
        /// </summary>
        [JsonPropertyName("type")]
        public IntegrationMappingBoxItemSlackTypeField Type { get; }

        /// <summary>
        /// ID of the mapped item (of type referenced in `type`)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public IntegrationMappingBoxItemSlack(string id, IntegrationMappingBoxItemSlackTypeField type = IntegrationMappingBoxItemSlackTypeField.Folder) {
            Type = type;
            Id = id;
        }
    }
}