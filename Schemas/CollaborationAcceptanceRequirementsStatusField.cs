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
        public CollaborationAcceptanceRequirementsStatusFieldTermsOfServiceRequirementField? TermsOfServiceRequirement { get; set; } = default;

        [JsonPropertyName("strong_password_requirement")]
        public CollaborationAcceptanceRequirementsStatusFieldStrongPasswordRequirementField? StrongPasswordRequirement { get; set; } = default;

        [JsonPropertyName("two_factor_authentication_requirement")]
        public CollaborationAcceptanceRequirementsStatusFieldTwoFactorAuthenticationRequirementField? TwoFactorAuthenticationRequirement { get; set; } = default;

        public CollaborationAcceptanceRequirementsStatusField() {
            
        }
    }
}