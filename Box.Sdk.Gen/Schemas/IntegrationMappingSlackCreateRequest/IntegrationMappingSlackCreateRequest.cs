using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingSlackCreateRequest {
        [JsonPropertyName("partner_item")]
        public IntegrationMappingPartnerItemSlack PartnerItem { get; set; }

        [JsonPropertyName("box_item")]
        public IntegrationMappingBoxItemSlack BoxItem { get; set; }

        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions? Options { get; set; } = default;

        public IntegrationMappingSlackCreateRequest(IntegrationMappingPartnerItemSlack partnerItem, IntegrationMappingBoxItemSlack boxItem) {
            PartnerItem = partnerItem;
            BoxItem = boxItem;
        }
    }
}