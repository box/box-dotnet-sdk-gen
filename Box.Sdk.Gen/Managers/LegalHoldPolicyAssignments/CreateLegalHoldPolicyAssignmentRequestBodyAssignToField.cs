using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateLegalHoldPolicyAssignmentRequestBodyAssignToField {
        /// <summary>
        /// The type of item to assign the policy to
        /// </summary>
        [JsonPropertyName("type")]
        public CreateLegalHoldPolicyAssignmentRequestBodyAssignToTypeField Type { get; }

        /// <summary>
        /// The ID of item to assign the policy to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateLegalHoldPolicyAssignmentRequestBodyAssignToField(CreateLegalHoldPolicyAssignmentRequestBodyAssignToTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}