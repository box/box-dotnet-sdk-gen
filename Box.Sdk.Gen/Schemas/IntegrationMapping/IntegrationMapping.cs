using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMapping : IntegrationMappingBase {
        /// <summary>
        /// Mapping type
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<IntegrationMappingTypeField>))]
        public StringEnum<IntegrationMappingTypeField> Type { get; }

        /// <summary>
        /// Mapped item object for Slack
        /// </summary>
        [JsonPropertyName("partner_item")]
        public IntegrationMappingPartnerItemSlack PartnerItem { get; }

        /// <summary>
        /// The Box folder, to which the object from the
        /// partner app domain (referenced in `partner_item_id`) is mapped
        /// </summary>
        [JsonPropertyName("box_item")]
        public FolderMini BoxItem { get; }

        /// <summary>
        /// Identifies whether the mapping has
        /// been manually set
        /// (as opposed to being automatically created)
        /// </summary>
        [JsonPropertyName("is_manually_created")]
        public bool? IsManuallyCreated { get; init; }

        /// <summary>
        /// Integration mapping options for Slack
        /// </summary>
        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions? Options { get; init; }

        /// <summary>
        /// An object representing the user who
        /// created the integration mapping
        /// </summary>
        [JsonPropertyName("created_by")]
        public UserIntegrationMappings? CreatedBy { get; init; }

        /// <summary>
        /// The user who
        /// last modified the integration mapping
        /// </summary>
        [JsonPropertyName("modified_by")]
        public UserIntegrationMappings? ModifiedBy { get; init; }

        /// <summary>
        /// When the integration mapping object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When the integration mapping object was last modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        public IntegrationMapping(IntegrationMappingPartnerItemSlack partnerItem, FolderMini boxItem, IntegrationMappingTypeField type = IntegrationMappingTypeField.IntegrationMapping) {
            Type = type;
            PartnerItem = partnerItem;
            BoxItem = boxItem;
        }
        
        [JsonConstructorAttribute]
        internal IntegrationMapping(IntegrationMappingPartnerItemSlack partnerItem, FolderMini boxItem, StringEnum<IntegrationMappingTypeField> type) {
            Type = IntegrationMappingTypeField.IntegrationMapping;
            PartnerItem = partnerItem;
            BoxItem = boxItem;
        }
    }
}