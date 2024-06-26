using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

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
        [JsonConverter(typeof(StringEnumConverter<RetentionPolicyBaseTypeField>))]
        public StringEnum<RetentionPolicyBaseTypeField> Type { get; }

        public RetentionPolicyBase(string id, RetentionPolicyBaseTypeField type = RetentionPolicyBaseTypeField.RetentionPolicy) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal RetentionPolicyBase(string id, StringEnum<RetentionPolicyBaseTypeField> type) {
            Id = id;
            Type = RetentionPolicyBaseTypeField.RetentionPolicy;
        }
    }
}