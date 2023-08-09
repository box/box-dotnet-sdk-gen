using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class StoragePolicyAssignment {
        [JsonPropertyName("storage_policy")]
        public StoragePolicyMini StoragePolicy { get; }

        [JsonPropertyName("assigned_to")]
        public StoragePolicyAssignmentAssignedToField AssignedTo { get; }

        public StoragePolicyAssignment(StoragePolicyMini storagePolicy, StoragePolicyAssignmentAssignedToField assignedTo) {
            StoragePolicy = storagePolicy;
            AssignedTo = assignedTo;
        }
    }
}