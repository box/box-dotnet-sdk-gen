using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class StoragePolicyAssignmentAssignedToField {
        /// <summary>
        /// The unique identifier for this object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type for this object
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; init; }

        public StoragePolicyAssignmentAssignedToField() {
            
        }
    }
}