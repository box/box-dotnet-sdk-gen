using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class IntegrationMappingSlackCreateRequest {
        [JsonPropertyName("partner_item")]
        public IntegrationMappingPartnerItemSlack PartnerItem { get; }

        [JsonPropertyName("box_item")]
        public IntegrationMappingBoxItemSlack BoxItem { get; }

        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions Options { get; }

        public IntegrationMappingSlackCreateRequest(IntegrationMappingPartnerItemSlack partnerItem, IntegrationMappingBoxItemSlack boxItem, IntegrationMappingSlackOptions options) {
            PartnerItem = partnerItem;
            BoxItem = boxItem;
            Options = options;
        }
    }
}