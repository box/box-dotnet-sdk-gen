using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingSlackCreateRequest {
        [JsonPropertyName("box_item")]
        public IntegrationMappingBoxItemSlack BoxItem { get; }

        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions? Options { get; init; }

        [JsonPropertyName("partner_item")]
        public IntegrationMappingPartnerItemSlack? PartnerItem { get; init; }

        public IntegrationMappingSlackCreateRequest(IntegrationMappingBoxItemSlack boxItem) {
            BoxItem = boxItem;
        }
    }
}