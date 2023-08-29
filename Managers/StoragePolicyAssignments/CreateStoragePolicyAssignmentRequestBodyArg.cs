using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyArg {
        /// <summary>
        /// The storage policy to assign to the user or
        /// enterprise
        /// </summary>
        [JsonPropertyName("storage_policy")]
        public CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyField StoragePolicy { get; set; }

        /// <summary>
        /// The user or enterprise to assign the storage
        /// policy to.
        /// </summary>
        [JsonPropertyName("assigned_to")]
        public CreateStoragePolicyAssignmentRequestBodyArgAssignedToField AssignedTo { get; set; }

        public CreateStoragePolicyAssignmentRequestBodyArg(CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyField storagePolicy, CreateStoragePolicyAssignmentRequestBodyArgAssignedToField assignedTo) {
            StoragePolicy = storagePolicy;
            AssignedTo = assignedTo;
        }
    }
}