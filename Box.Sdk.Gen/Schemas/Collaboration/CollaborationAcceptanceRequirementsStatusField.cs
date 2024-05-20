using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAcceptanceRequirementsStatusField {
        [JsonPropertyName("terms_of_service_requirement")]
        public CollaborationAcceptanceRequirementsStatusTermsOfServiceRequirementField? TermsOfServiceRequirement { get; init; }

        [JsonPropertyName("strong_password_requirement")]
        public CollaborationAcceptanceRequirementsStatusStrongPasswordRequirementField? StrongPasswordRequirement { get; init; }

        [JsonPropertyName("two_factor_authentication_requirement")]
        public CollaborationAcceptanceRequirementsStatusTwoFactorAuthenticationRequirementField? TwoFactorAuthenticationRequirement { get; init; }

        public CollaborationAcceptanceRequirementsStatusField() {
            
        }
    }
}