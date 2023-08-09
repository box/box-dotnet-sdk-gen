using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyArg {
        [JsonPropertyName("storage_policy")]
        public CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyField StoragePolicy { get; }

        [JsonPropertyName("assigned_to")]
        public CreateStoragePolicyAssignmentRequestBodyArgAssignedToField AssignedTo { get; }

        public CreateStoragePolicyAssignmentRequestBodyArg(CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyField storagePolicy, CreateStoragePolicyAssignmentRequestBodyArgAssignedToField assignedTo) {
            StoragePolicy = storagePolicy;
            AssignedTo = assignedTo;
        }
    }
}