using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataCascadePolicyOwnerEnterpriseField {
        /// <summary>
        /// `enterprise`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<MetadataCascadePolicyOwnerEnterpriseTypeField>))]
        public StringEnum<MetadataCascadePolicyOwnerEnterpriseTypeField>? Type { get; init; }

        /// <summary>
        /// The ID of the enterprise that owns the policy.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public MetadataCascadePolicyOwnerEnterpriseField() {
            
        }
    }
}