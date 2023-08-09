using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class CollaborationAcceptanceRequirementsStatusFieldStrongPasswordRequirementField {
        [JsonPropertyName("enterprise_has_strong_password_required_for_external_users")]
        public bool? EnterpriseHasStrongPasswordRequiredForExternalUsers { get; }

        [JsonPropertyName("user_has_strong_password")]
        public bool? UserHasStrongPassword { get; }

        public CollaborationAcceptanceRequirementsStatusFieldStrongPasswordRequirementField(bool? enterpriseHasStrongPasswordRequiredForExternalUsers, bool? userHasStrongPassword) {
            EnterpriseHasStrongPasswordRequiredForExternalUsers = enterpriseHasStrongPasswordRequiredForExternalUsers;
            UserHasStrongPassword = userHasStrongPassword;
        }
    }
}