using Unions;
using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyStoragePolicyField {
        /// <summary>
        /// The type to assign.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateStoragePolicyAssignmentRequestBodyStoragePolicyTypeField>))]
        public StringEnum<CreateStoragePolicyAssignmentRequestBodyStoragePolicyTypeField> Type { get; }

        /// <summary>
        /// The ID of the storage policy to assign.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateStoragePolicyAssignmentRequestBodyStoragePolicyField(string id, CreateStoragePolicyAssignmentRequestBodyStoragePolicyTypeField type = CreateStoragePolicyAssignmentRequestBodyStoragePolicyTypeField.StoragePolicy) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal CreateStoragePolicyAssignmentRequestBodyStoragePolicyField(string id, StringEnum<CreateStoragePolicyAssignmentRequestBodyStoragePolicyTypeField> type) {
            Type = CreateStoragePolicyAssignmentRequestBodyStoragePolicyTypeField.StoragePolicy;
            Id = id;
        }
    }
}