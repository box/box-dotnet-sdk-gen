using Unions;
using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField {
        /// <summary>
        /// The type to assign.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField>))]
        public StringEnum<UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField> Type { get; }

        /// <summary>
        /// The ID of the storage policy to assign.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField(string id, UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField type = UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField.StoragePolicy) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyField(string id, StringEnum<UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField> type) {
            Type = UpdateStoragePolicyAssignmentByIdRequestBodyStoragePolicyTypeField.StoragePolicy;
            Id = id;
        }
    }
}