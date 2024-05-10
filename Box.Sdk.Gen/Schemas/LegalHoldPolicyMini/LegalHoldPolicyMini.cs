using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class LegalHoldPolicyMini {
        /// <summary>
        /// The unique identifier for this legal hold policy
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `legal_hold_policy`
        /// </summary>
        [JsonPropertyName("type")]
        public LegalHoldPolicyMiniTypeField Type { get; set; }

        public LegalHoldPolicyMini(string id, LegalHoldPolicyMiniTypeField type = LegalHoldPolicyMiniTypeField.LegalHoldPolicy) {
            Id = id;
            Type = type;
        }
    }
}