using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class CollaborationAcceptanceRequirementsStatusFieldStrongPasswordRequirementField {
        /// <summary>
        /// Whether or not the enterprise that owns the content requires
        /// a strong password to collaborate on the content.
        /// </summary>
        [JsonPropertyName("enterprise_has_strong_password_required_for_external_users")]
        public bool? EnterpriseHasStrongPasswordRequiredForExternalUsers { get; set; } = default;

        /// <summary>
        /// Whether or not the user has a strong password set for their
        /// account. The field is `null` when a strong password is not
        /// required.
        /// </summary>
        [JsonPropertyName("user_has_strong_password")]
        public bool? UserHasStrongPassword { get; set; } = default;

        public CollaborationAcceptanceRequirementsStatusFieldStrongPasswordRequirementField() {
            
        }
    }
}