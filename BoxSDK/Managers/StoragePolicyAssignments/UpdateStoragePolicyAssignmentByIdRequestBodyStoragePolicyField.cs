using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
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

        public UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField(UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}