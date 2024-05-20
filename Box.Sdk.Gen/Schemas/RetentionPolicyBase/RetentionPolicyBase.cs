using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyBase {
        /// <summary>
        /// The unique identifier that represents a retention policy.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `retention_policy`
        /// </summary>
        [JsonPropertyName("type")]
        public RetentionPolicyBaseTypeField Type { get; }

        public RetentionPolicyBase(string id, RetentionPolicyBaseTypeField type = RetentionPolicyBaseTypeField.RetentionPolicy) {
            Id = id;
            Type = type;
        }
    }
}