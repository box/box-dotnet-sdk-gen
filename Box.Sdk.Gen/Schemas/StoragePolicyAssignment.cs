using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class StoragePolicyAssignment {
        [JsonPropertyName("storage_policy")]
        public StoragePolicyMini? StoragePolicy { get; set; } = default;

        [JsonPropertyName("assigned_to")]
        public StoragePolicyAssignmentAssignedToField? AssignedTo { get; set; } = default;

        public StoragePolicyAssignment() {
            
        }
    }
}