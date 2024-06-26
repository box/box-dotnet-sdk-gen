using Unions;
using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateLegalHoldPolicyAssignmentRequestBodyAssignToField {
        /// <summary>
        /// The type of item to assign the policy to
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateLegalHoldPolicyAssignmentRequestBodyAssignToTypeField>))]
        public StringEnum<CreateLegalHoldPolicyAssignmentRequestBodyAssignToTypeField> Type { get; }

        /// <summary>
        /// The ID of item to assign the policy to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateLegalHoldPolicyAssignmentRequestBodyAssignToField(CreateLegalHoldPolicyAssignmentRequestBodyAssignToTypeField type, string id) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal CreateLegalHoldPolicyAssignmentRequestBodyAssignToField(StringEnum<CreateLegalHoldPolicyAssignmentRequestBodyAssignToTypeField> type, string id) {
            Type = type;
            Id = id;
        }
    }
}