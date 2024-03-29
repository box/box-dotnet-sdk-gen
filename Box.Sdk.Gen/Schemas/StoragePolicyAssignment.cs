using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class StoragePolicyAssignment {
        /// <summary>
        /// The unique identifier for a storage policy assignment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `storage_policy_assignment`
        /// </summary>
        [JsonPropertyName("type")]
        public StoragePolicyAssignmentTypeField Type { get; set; }

        [JsonPropertyName("storage_policy")]
        public StoragePolicyMini? StoragePolicy { get; set; } = default;

        [JsonPropertyName("assigned_to")]
        public StoragePolicyAssignmentAssignedToField? AssignedTo { get; set; } = default;

        public StoragePolicyAssignment(string id, StoragePolicyAssignmentTypeField type = StoragePolicyAssignmentTypeField.StoragePolicyAssignment) {
            Id = id;
            Type = type;
        }
    }
}