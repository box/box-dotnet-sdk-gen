using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateStoragePolicyAssignmentRequestBody {
        /// <summary>
        /// The storage policy to assign to the user or
        /// enterprise
        /// </summary>
        [JsonPropertyName("storage_policy")]
        public CreateStoragePolicyAssignmentRequestBodyStoragePolicyField StoragePolicy { get; }

        /// <summary>
        /// The user or enterprise to assign the storage
        /// policy to.
        /// </summary>
        [JsonPropertyName("assigned_to")]
        public CreateStoragePolicyAssignmentRequestBodyAssignedToField AssignedTo { get; }

        public CreateStoragePolicyAssignmentRequestBody(CreateStoragePolicyAssignmentRequestBodyStoragePolicyField storagePolicy, CreateStoragePolicyAssignmentRequestBodyAssignedToField assignedTo) {
            StoragePolicy = storagePolicy;
            AssignedTo = assignedTo;
        }
    }
}