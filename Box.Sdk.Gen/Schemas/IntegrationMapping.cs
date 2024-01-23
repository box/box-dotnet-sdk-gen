using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMapping : IntegrationMappingBase {
        /// <summary>
        /// Mapping type
        /// </summary>
        [JsonPropertyName("type")]
        public IntegrationMappingTypeField Type { get; set; }

        /// <summary>
        /// Mapped item object for Slack
        /// </summary>
        [JsonPropertyName("partner_item")]
        public IntegrationMappingPartnerItemSlack PartnerItem { get; set; }

        /// <summary>
        /// The Box folder, to which the object from the
        /// partner app domain (referenced in `partner_item_id`) is mapped
        /// </summary>
        [JsonPropertyName("box_item")]
        public FolderMini BoxItem { get; set; }

        /// <summary>
        /// Identifies whether the mapping has
        /// been manually set
        /// (as opposed to being automatically created)
        /// </summary>
        [JsonPropertyName("is_manually_created")]
        public bool? IsManuallyCreated { get; set; } = default;

        /// <summary>
        /// Integration mapping options for Slack
        /// </summary>
        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions? Options { get; set; } = default;

        /// <summary>
        /// An object representing the user who
        /// created the integration mapping
        /// </summary>
        [JsonPropertyName("created_by")]
        public UserIntegrationMappings? CreatedBy { get; set; } = default;

        /// <summary>
        /// The user who
        /// last modified the integration mapping
        /// </summary>
        [JsonPropertyName("modified_by")]
        public UserIntegrationMappings? ModifiedBy { get; set; } = default;

        /// <summary>
        /// When the integration mapping object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// When the integration mapping object was last modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        public IntegrationMapping(IntegrationMappingTypeField type, IntegrationMappingPartnerItemSlack partnerItem, FolderMini boxItem) {
            Type = type;
            PartnerItem = partnerItem;
            BoxItem = boxItem;
        }
    }
}