using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class StoragePolicyAssignment {
        /// <summary>
        /// The unique identifier for a storage policy assignment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `storage_policy_assignment`
        /// </summary>
        [JsonPropertyName("type")]
        public StoragePolicyAssignmentTypeField Type { get; }

        [JsonPropertyName("storage_policy")]
        public StoragePolicyMini? StoragePolicy { get; init; }

        [JsonPropertyName("assigned_to")]
        public StoragePolicyAssignmentAssignedToField? AssignedTo { get; init; }

        public StoragePolicyAssignment(string id, StoragePolicyAssignmentTypeField type = StoragePolicyAssignmentTypeField.StoragePolicyAssignment) {
            Id = id;
            Type = type;
        }
    }
}