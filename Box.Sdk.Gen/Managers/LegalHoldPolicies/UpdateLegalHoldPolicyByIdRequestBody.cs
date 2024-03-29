using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateLegalHoldPolicyByIdRequestBody {
        /// <summary>
        /// The name of the policy.
        /// </summary>
        [JsonPropertyName("policy_name")]
        public string? PolicyName { get; set; } = default;

        /// <summary>
        /// A description for the policy.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// Notes around why the policy was released.
        /// </summary>
        [JsonPropertyName("release_notes")]
        public string? ReleaseNotes { get; set; } = default;

        public UpdateLegalHoldPolicyByIdRequestBody() {
            
        }
    }
}