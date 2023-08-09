using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class CollaborationAcceptanceRequirementsStatusFieldTwoFactorAuthenticationRequirementField {
        [JsonPropertyName("enterprise_has_two_factor_auth_enabled")]
        public bool? EnterpriseHasTwoFactorAuthEnabled { get; }

        [JsonPropertyName("user_has_two_factor_authentication_enabled")]
        public bool? UserHasTwoFactorAuthenticationEnabled { get; }

        public CollaborationAcceptanceRequirementsStatusFieldTwoFactorAuthenticationRequirementField(bool? enterpriseHasTwoFactorAuthEnabled, bool? userHasTwoFactorAuthenticationEnabled) {
            EnterpriseHasTwoFactorAuthEnabled = enterpriseHasTwoFactorAuthEnabled;
            UserHasTwoFactorAuthenticationEnabled = userHasTwoFactorAuthenticationEnabled;
        }
    }
}