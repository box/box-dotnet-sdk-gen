using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAcceptanceRequirementsStatusField {
        [JsonPropertyName("terms_of_service_requirement")]
        public CollaborationAcceptanceRequirementsStatusTermsOfServiceRequirementField? TermsOfServiceRequirement { get; set; } = default;

        [JsonPropertyName("strong_password_requirement")]
        public CollaborationAcceptanceRequirementsStatusStrongPasswordRequirementField? StrongPasswordRequirement { get; set; } = default;

        [JsonPropertyName("two_factor_authentication_requirement")]
        public CollaborationAcceptanceRequirementsStatusTwoFactorAuthenticationRequirementField? TwoFactorAuthenticationRequirement { get; set; } = default;

        public CollaborationAcceptanceRequirementsStatusField() {
            
        }
    }
}