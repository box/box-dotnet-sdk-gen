using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class LegalHoldPolicyMini {
        /// <summary>
        /// The unique identifier for this legal hold policy
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `legal_hold_policy`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<LegalHoldPolicyMiniTypeField>))]
        public StringEnum<LegalHoldPolicyMiniTypeField> Type { get; }

        public LegalHoldPolicyMini(string id, LegalHoldPolicyMiniTypeField type = LegalHoldPolicyMiniTypeField.LegalHoldPolicy) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal LegalHoldPolicyMini(string id, StringEnum<LegalHoldPolicyMiniTypeField> type) {
            Id = id;
            Type = LegalHoldPolicyMiniTypeField.LegalHoldPolicy;
        }
    }
}