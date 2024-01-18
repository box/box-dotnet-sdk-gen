using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyBase {
        /// <summary>
        /// The unique identifier that represents a retention policy.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `retention_policy`
        /// </summary>
        [JsonPropertyName("type")]
        public RetentionPolicyBaseTypeField Type { get; set; }

        public RetentionPolicyBase(string id, RetentionPolicyBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}