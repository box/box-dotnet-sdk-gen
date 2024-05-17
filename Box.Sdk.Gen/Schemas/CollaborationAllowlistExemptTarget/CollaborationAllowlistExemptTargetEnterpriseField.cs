using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAllowlistExemptTargetEnterpriseField {
        /// <summary>
        /// The unique identifier for this enterprise.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `enterprise`
        /// </summary>
        [JsonPropertyName("type")]
        public CollaborationAllowlistExemptTargetEnterpriseTypeField? Type { get; init; }

        /// <summary>
        /// The name of the enterprise
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        public CollaborationAllowlistExemptTargetEnterpriseField() {
            
        }
    }
}