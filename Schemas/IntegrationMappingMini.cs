using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class IntegrationMappingMini : IntegrationMappingBase {
        [JsonPropertyName("partner_item_id")]
        public string PartnerItemId { get; }

        [JsonPropertyName("partner_item_type")]
        public IntegrationMappingMiniPartnerItemTypeField PartnerItemType { get; }

        [JsonPropertyName("box_item_id")]
        public string BoxItemId { get; }

        [JsonPropertyName("box_item_type")]
        public IntegrationMappingMiniBoxItemTypeField BoxItemType { get; }

        public IntegrationMappingMini(string id, IntegrationMappingBaseIntegrationTypeField integrationType, string partnerItemId, IntegrationMappingMiniPartnerItemTypeField partnerItemType, string boxItemId, IntegrationMappingMiniBoxItemTypeField boxItemType) : base(id, integrationType) {
            PartnerItemId = partnerItemId;
            PartnerItemType = partnerItemType;
            BoxItemId = boxItemId;
            BoxItemType = boxItemType;
        }
    }
}