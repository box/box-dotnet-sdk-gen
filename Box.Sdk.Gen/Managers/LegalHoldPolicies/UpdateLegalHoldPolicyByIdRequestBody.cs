using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateLegalHoldPolicyByIdRequestBody : ISerializable {
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
        internal string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}