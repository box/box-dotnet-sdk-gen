using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField {
        /// <summary>
        /// The type to assign.
        /// </summary>
        [JsonPropertyName("type")]
        public UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField Type { get; set; }

        /// <summary>
        /// The ID of the storage policy to assign.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField(string id, UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField type = UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField.StoragePolicy) {
            Type = type;
            Id = id;
        }
    }
}