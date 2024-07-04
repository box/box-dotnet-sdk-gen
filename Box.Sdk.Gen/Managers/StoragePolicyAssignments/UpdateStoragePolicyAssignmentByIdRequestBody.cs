using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateStoragePolicyAssignmentByIdRequestBody {
        /// <summary>
        /// The storage policy to assign to the user or
        /// enterprise
        /// </summary>
        [JsonPropertyName("storage_policy")]
        public UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField StoragePolicy { get; }

        public UpdateStoragePolicyAssignmentByIdRequestBody(UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField storagePolicy) {
            StoragePolicy = storagePolicy;
        }
    }
}