using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingMini : IntegrationMappingBase {
        /// <summary>
        /// ID of the mapped partner item
        /// </summary>
        [JsonPropertyName("partner_item_id")]
        public string? PartnerItemId { get; init; }

        /// <summary>
        /// Domain-specific type of the mapped partner item
        /// </summary>
        [JsonPropertyName("partner_item_type")]
        public IntegrationMappingMiniPartnerItemTypeField? PartnerItemType { get; init; }

        /// <summary>
        /// ID of the Box item mapped to the object referenced in `partner_item_id`
        /// </summary>
        [JsonPropertyName("box_item_id")]
        public string? BoxItemId { get; init; }

        /// <summary>
        /// Type of the Box object referenced in `box_item_id`
        /// </summary>
        [JsonPropertyName("box_item_type")]
        public IntegrationMappingMiniBoxItemTypeField? BoxItemType { get; init; }

        public IntegrationMappingMini() {
            
        }
    }
}