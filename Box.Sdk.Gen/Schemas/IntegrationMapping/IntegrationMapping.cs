using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMapping : IntegrationMappingBase {
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

        /// <summary>
        /// Identifies the Box partner app,
        /// with which the mapping is associated.
        /// Currently only supports Slack.
        /// (part of the composite key together with `id`)
        /// </summary>
        [JsonPropertyName("integration_type")]
        [JsonConverter(typeof(StringEnumConverter<IntegrationMappingIntegrationTypeField>))]
        public StringEnum<IntegrationMappingIntegrationTypeField>? IntegrationType { get; init; }

        /// <summary>
        /// Mapped item object for Slack or Teams
        /// </summary>
        [JsonPropertyName("partner_item")]
        public IntegrationMappingPartnerItemSlackUnion PartnerItem { get; }

        public IntegrationMapping(string id, FolderMini boxItem, IntegrationMappingPartnerItemSlackUnion partnerItem, IntegrationMappingBaseTypeField type = IntegrationMappingBaseTypeField.IntegrationMapping) : base(id, type) {
            BoxItem = boxItem;
            PartnerItem = partnerItem;
        }
        
        [JsonConstructorAttribute]
        internal IntegrationMapping(string id, FolderMini boxItem, IntegrationMappingPartnerItemSlackUnion partnerItem, StringEnum<IntegrationMappingBaseTypeField> type) : base(id, type ?? new StringEnum<IntegrationMappingBaseTypeField>(IntegrationMappingBaseTypeField.IntegrationMapping)) {
            BoxItem = boxItem;
            PartnerItem = partnerItem;
        }
    }
}