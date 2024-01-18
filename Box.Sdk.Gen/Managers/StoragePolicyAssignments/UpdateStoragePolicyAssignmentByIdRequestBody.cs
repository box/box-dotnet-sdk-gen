using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateStoragePolicyAssignmentByIdRequestBody {
        /// <summary>
        /// The storage policy to assign to the user or
        /// enterprise
        /// </summary>
        [JsonPropertyName("storage_policy")]
        public UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField StoragePolicy { get; set; }

        public UpdateStoragePolicyAssignmentByIdRequestBody(UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField storagePolicy) {
            StoragePolicy = storagePolicy;
        }
    }
}