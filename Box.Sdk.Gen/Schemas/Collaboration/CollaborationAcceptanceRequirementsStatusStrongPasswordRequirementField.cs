using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class CollaborationAcceptanceRequirementsStatusStrongPasswordRequirementField {
        [JsonInclude]
        [JsonPropertyName("_isuser_has_strong_passwordSet")]
        protected bool _isUserHasStrongPasswordSet { get; set; }

        protected bool? _userHasStrongPassword { get; set; }

        /// <summary>
        /// Whether or not the enterprise that owns the content requires
        /// a strong password to collaborate on the content.
        /// </summary>
        [JsonPropertyName("enterprise_has_strong_password_required_for_external_users")]
        public bool? EnterpriseHasStrongPasswordRequiredForExternalUsers { get; init; }

        /// <summary>
        /// Whether or not the user has a strong password set for their
        /// account. The field is `null` when a strong password is not
        /// required.
        /// </summary>
        [JsonPropertyName("user_has_strong_password")]
        public bool? UserHasStrongPassword { get => _userHasStrongPassword; init { _userHasStrongPassword = value; _isUserHasStrongPasswordSet = true; } }

        public CollaborationAcceptanceRequirementsStatusStrongPasswordRequirementField() {
            
        }
    }
}