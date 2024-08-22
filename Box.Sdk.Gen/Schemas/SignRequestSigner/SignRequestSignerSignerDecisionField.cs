using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestSignerSignerDecisionField {
        [JsonInclude]
        [JsonPropertyName("_isadditional_infoSet")]
        protected bool _isAdditionalInfoSet { get; set; }

        protected string? _additionalInfo { get; set; }

        /// <summary>
        /// Type of decision made by the signer.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<SignRequestSignerSignerDecisionTypeField>))]
        public StringEnum<SignRequestSignerSignerDecisionTypeField>? Type { get; init; }

        /// <summary>
        /// Date and Time that the decision was made.
        /// </summary>
        [JsonPropertyName("finalized_at")]
        public System.DateTimeOffset? FinalizedAt { get; init; }

        /// <summary>
        /// Additional info about the decision, such as the decline reason from the signer.
        /// </summary>
        [JsonPropertyName("additional_info")]
        public string? AdditionalInfo { get => _additionalInfo; init { _additionalInfo = value; _isAdditionalInfoSet = true; } }

        public SignRequestSignerSignerDecisionField() {
            
        }
    }
}