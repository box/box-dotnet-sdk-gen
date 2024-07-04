using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateRetentionPolicyAssignmentRequestBodyAssignToField {
        /// <summary>
        /// The type of item to assign the policy to.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateRetentionPolicyAssignmentRequestBodyAssignToTypeField>))]
        public StringEnum<CreateRetentionPolicyAssignmentRequestBodyAssignToTypeField> Type { get; }

        /// <summary>
        /// The ID of item to assign the policy to.
        /// Set to `null` or omit when `type` is set to
        /// `enterprise`.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public CreateRetentionPolicyAssignmentRequestBodyAssignToField(CreateRetentionPolicyAssignmentRequestBodyAssignToTypeField type) {
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal CreateRetentionPolicyAssignmentRequestBodyAssignToField(StringEnum<CreateRetentionPolicyAssignmentRequestBodyAssignToTypeField> type) {
            Type = type;
        }
    }
}