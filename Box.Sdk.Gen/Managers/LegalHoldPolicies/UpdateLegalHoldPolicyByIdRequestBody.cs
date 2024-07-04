using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class UpdateLegalHoldPolicyByIdRequestBody {
        /// <summary>
        /// The name of the policy.
        /// </summary>
        [JsonPropertyName("policy_name")]
        public string? PolicyName { get; init; }

        /// <summary>
        /// A description for the policy.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// Notes around why the policy was released.
        /// </summary>
        [JsonPropertyName("release_notes")]
        public string? ReleaseNotes { get; init; }

        public UpdateLegalHoldPolicyByIdRequestBody() {
            
        }
    }
}