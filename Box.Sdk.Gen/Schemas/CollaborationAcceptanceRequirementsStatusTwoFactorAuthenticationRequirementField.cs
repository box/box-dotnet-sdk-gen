using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAcceptanceRequirementsStatusTwoFactorAuthenticationRequirementField {
        /// <summary>
        /// Whether or not the enterprise that owns the content requires
        /// two-factor authentication to be enabled in order to
        /// collaborate on the content.
        /// </summary>
        [JsonPropertyName("enterprise_has_two_factor_auth_enabled")]
        public bool? EnterpriseHasTwoFactorAuthEnabled { get; set; } = default;

        /// <summary>
        /// Whether or not the user has two-factor authentication
        /// enabled. The field is `null` when two-factor
        /// authentication is not required.
        /// </summary>
        [JsonPropertyName("user_has_two_factor_authentication_enabled")]
        public bool? UserHasTwoFactorAuthenticationEnabled { get; set; } = default;

        public CollaborationAcceptanceRequirementsStatusTwoFactorAuthenticationRequirementField() {
            
        }
    }
}