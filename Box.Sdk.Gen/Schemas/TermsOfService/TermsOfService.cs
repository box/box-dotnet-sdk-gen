using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TermsOfService : TermsOfServiceBase {
        /// <summary>
        /// Whether these terms are enabled or not
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringEnumConverter<TermsOfServiceStatusField>))]
        public StringEnum<TermsOfServiceStatusField>? Status { get; init; }

        [JsonPropertyName("enterprise")]
        public TermsOfServiceEnterpriseField? Enterprise { get; init; }

        /// <summary>
        /// Whether to apply these terms to managed users or external users
        /// </summary>
        [JsonPropertyName("tos_type")]
        [JsonConverter(typeof(StringEnumConverter<TermsOfServiceTosTypeField>))]
        public StringEnum<TermsOfServiceTosTypeField>? TosType { get; init; }

        /// <summary>
        /// The text for your terms and conditions. This text could be
        /// empty if the `status` is set to `disabled`.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; init; }

        /// <summary>
        /// When the legal item was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When the legal item was modified.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        public TermsOfService(string id, TermsOfServiceBaseTypeField type = TermsOfServiceBaseTypeField.TermsOfService) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal TermsOfService(string id, StringEnum<TermsOfServiceBaseTypeField> type) : base(id, type ?? new StringEnum<TermsOfServiceBaseTypeField>(TermsOfServiceBaseTypeField.TermsOfService)) {
            
        }
    }
}