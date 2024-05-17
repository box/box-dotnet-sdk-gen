using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAcceptanceRequirementsStatusTermsOfServiceRequirementField {
        /// <summary>
        /// Whether or not the terms of service have been accepted.  The
        /// field is `null` when there is no terms of service required.
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool? IsAccepted { get; init; }

        [JsonPropertyName("terms_of_service")]
        public TermsOfServiceBase? TermsOfService { get; init; }

        public CollaborationAcceptanceRequirementsStatusTermsOfServiceRequirementField() {
            
        }
    }
}