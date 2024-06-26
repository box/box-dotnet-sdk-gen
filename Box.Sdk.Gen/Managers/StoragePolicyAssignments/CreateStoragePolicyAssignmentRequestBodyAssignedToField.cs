using Unions;
using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateStoragePolicyAssignmentRequestBodyAssignedToField {
        /// <summary>
        /// The type to assign the policy to.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateStoragePolicyAssignmentRequestBodyAssignedToTypeField>))]
        public StringEnum<CreateStoragePolicyAssignmentRequestBodyAssignedToTypeField> Type { get; }

        /// <summary>
        /// The ID of the user or enterprise
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateStoragePolicyAssignmentRequestBodyAssignedToField(CreateStoragePolicyAssignmentRequestBodyAssignedToTypeField type, string id) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal CreateStoragePolicyAssignmentRequestBodyAssignedToField(StringEnum<CreateStoragePolicyAssignmentRequestBodyAssignedToTypeField> type, string id) {
            Type = type;
            Id = id;
        }
    }
}