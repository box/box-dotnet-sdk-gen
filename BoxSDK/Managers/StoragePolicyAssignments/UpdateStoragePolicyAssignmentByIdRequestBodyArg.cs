using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateStoragePolicyAssignmentByIdRequestBodyArg {
        /// <summary>
        /// The storage policy to assign to the user or
        /// enterprise
        /// </summary>
        [JsonPropertyName("storage_policy")]
        public UpdateStoragePolicyAssignmentByIdRequestBodyArgStoragePolicyField StoragePolicy { get; set; }

        public UpdateStoragePolicyAssignmentByIdRequestBodyArg(UpdateStoragePolicyAssignmentByIdRequestBodyArgStoragePolicyField storagePolicy) {
            StoragePolicy = storagePolicy;
        }
    }
}