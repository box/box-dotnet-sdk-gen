using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestSignerSignerDecisionField {
        /// <summary>
        /// Type of decision made by the signer
        /// </summary>
        [JsonPropertyName("type")]
        public SignRequestSignerSignerDecisionTypeField? Type { get; set; } = default;

        /// <summary>
        /// Date and Time that the decision was made
        /// </summary>
        [JsonPropertyName("finalized_at")]
        public System.DateTimeOffset? FinalizedAt { get; set; } = default;

        /// <summary>
        /// Additional info about the decision, such as the decline reason from the signer
        /// </summary>
        [JsonPropertyName("additional_info")]
        public string? AdditionalInfo { get; set; } = default;

        public SignRequestSignerSignerDecisionField() {
            
        }
    }
}