using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingSlackCreateRequest {
        [JsonPropertyName("partner_item")]
        public IntegrationMappingPartnerItemSlack PartnerItem { get; }

        [JsonPropertyName("box_item")]
        public IntegrationMappingBoxItemSlack BoxItem { get; }

        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions? Options { get; init; }

        public IntegrationMappingSlackCreateRequest(IntegrationMappingPartnerItemSlack partnerItem, IntegrationMappingBoxItemSlack boxItem) {
            PartnerItem = partnerItem;
            BoxItem = boxItem;
        }
    }
}