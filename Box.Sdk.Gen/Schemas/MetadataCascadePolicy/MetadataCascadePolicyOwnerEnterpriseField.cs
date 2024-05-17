using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataCascadePolicyOwnerEnterpriseField {
        /// <summary>
        /// `enterprise`
        /// </summary>
        [JsonPropertyName("type")]
        public MetadataCascadePolicyOwnerEnterpriseTypeField? Type { get; init; }

        /// <summary>
        /// The ID of the enterprise that owns the policy.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public MetadataCascadePolicyOwnerEnterpriseField() {
            
        }
    }
}