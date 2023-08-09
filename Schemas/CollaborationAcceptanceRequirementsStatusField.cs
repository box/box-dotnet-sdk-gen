using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class CollaborationAcceptanceRequirementsStatusField {
        [JsonPropertyName("terms_of_service_requirement")]
        public CollaborationAcceptanceRequirementsStatusFieldTermsOfServiceRequirementField TermsOfServiceRequirement { get; }

        [JsonPropertyName("strong_password_requirement")]
        public CollaborationAcceptanceRequirementsStatusFieldStrongPasswordRequirementField StrongPasswordRequirement { get; }

        [JsonPropertyName("two_factor_authentication_requirement")]
        public CollaborationAcceptanceRequirementsStatusFieldTwoFactorAuthenticationRequirementField TwoFactorAuthenticationRequirement { get; }

        public CollaborationAcceptanceRequirementsStatusField(CollaborationAcceptanceRequirementsStatusFieldTermsOfServiceRequirementField termsOfServiceRequirement, CollaborationAcceptanceRequirementsStatusFieldStrongPasswordRequirementField strongPasswordRequirement, CollaborationAcceptanceRequirementsStatusFieldTwoFactorAuthenticationRequirementField twoFactorAuthenticationRequirement) {
            TermsOfServiceRequirement = termsOfServiceRequirement;
            StrongPasswordRequirement = strongPasswordRequirement;
            TwoFactorAuthenticationRequirement = twoFactorAuthenticationRequirement;
        }
    }
}