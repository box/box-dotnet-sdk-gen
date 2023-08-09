using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class IntegrationMapping : IntegrationMappingBase {
        [JsonPropertyName("type")]
        public IntegrationMappingTypeField Type { get; }

        [JsonPropertyName("partner_item")]
        public IntegrationMappingPartnerItemField PartnerItem { get; }

        [JsonPropertyName("box_item")]
        public FolderMini BoxItem { get; }

        [JsonPropertyName("is_manually_created")]
        public bool? IsManuallyCreated { get; }

        [JsonPropertyName("options")]
        public IntegrationMappingOptionsField Options { get; }

        [JsonPropertyName("created_by")]
        public UserIntegrationMappings CreatedBy { get; }

        [JsonPropertyName("modified_by")]
        public UserIntegrationMappings ModifiedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        public IntegrationMapping(string id, IntegrationMappingBaseIntegrationTypeField integrationType, IntegrationMappingTypeField type, IntegrationMappingPartnerItemField partnerItem, FolderMini boxItem, bool? isManuallyCreated, IntegrationMappingOptionsField options, UserIntegrationMappings createdBy, UserIntegrationMappings modifiedBy, string createdAt, string modifiedAt) : base(id, integrationType) {
            Type = type;
            PartnerItem = partnerItem;
            BoxItem = boxItem;
            IsManuallyCreated = isManuallyCreated;
            Options = options;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}