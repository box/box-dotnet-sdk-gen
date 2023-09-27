using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserRequestBodyArg {
        /// <summary>
        /// The name of the user
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The email address the user uses to log in
        /// 
        /// Required, unless `is_platform_access_only`
        /// is set to `true`.
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; set; } = default;

        /// <summary>
        /// Specifies that the user is an app user.
        /// </summary>
        [JsonPropertyName("is_platform_access_only")]
        public bool? IsPlatformAccessOnly { get; set; } = default;

        /// <summary>
        /// The user’s enterprise role
        /// </summary>
        [JsonPropertyName("role")]
        public CreateUserRequestBodyArgRoleField? Role { get; set; } = default;

        /// <summary>
        /// The language of the user, formatted in modified version of the
        /// [ISO 639-1](/guides/api-calls/language-codes) format.
        /// </summary>
        [JsonPropertyName("language")]
        public string? Language { get; set; } = default;

        /// <summary>
        /// Whether the user can use Box Sync
        /// </summary>
        [JsonPropertyName("is_sync_enabled")]
        public bool? IsSyncEnabled { get; set; } = default;

        /// <summary>
        /// The user’s job title
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; } = default;

        /// <summary>
        /// The user’s phone number
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; } = default;

        /// <summary>
        /// The user’s address
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get; set; } = default;

        /// <summary>
        /// The user’s total available space in bytes. Set this to `-1` to
        /// indicate unlimited storage.
        /// </summary>
        [JsonPropertyName("space_amount")]
        public long? SpaceAmount { get; set; } = default;

        /// <summary>
        /// Tracking codes allow an admin to generate reports from the
        /// admin console and assign an attribute to a specific group
        /// of users. This setting must be enabled for an enterprise before it
        /// can be used.
        /// </summary>
        [JsonPropertyName("tracking_codes")]
        public IReadOnlyList<TrackingCode>? TrackingCodes { get; set; } = default;

        /// <summary>
        /// Whether the user can see other enterprise users in their
        /// contact list
        /// </summary>
        [JsonPropertyName("can_see_managed_users")]
        public bool? CanSeeManagedUsers { get; set; } = default;

        /// <summary>
        /// The user's timezone
        /// </summary>
        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; } = default;

        /// <summary>
        /// Whether the user is allowed to collaborate with users outside
        /// their enterprise
        /// </summary>
        [JsonPropertyName("is_external_collab_restricted")]
        public bool? IsExternalCollabRestricted { get; set; } = default;

        /// <summary>
        /// Whether to exempt the user from enterprise device limits
        /// </summary>
        [JsonPropertyName("is_exempt_from_device_limits")]
        public bool? IsExemptFromDeviceLimits { get; set; } = default;

        /// <summary>
        /// Whether the user must use two-factor authentication
        /// </summary>
        [JsonPropertyName("is_exempt_from_login_verification")]
        public bool? IsExemptFromLoginVerification { get; set; } = default;

        /// <summary>
        /// The user's account status
        /// </summary>
        [JsonPropertyName("status")]
        public CreateUserRequestBodyArgStatusField? Status { get; set; } = default;

        /// <summary>
        /// An external identifier for an app user, which can be used to look
        /// up the user. This can be used to tie user IDs from external
        /// identity providers to Box users.
        /// </summary>
        [JsonPropertyName("external_app_user_id")]
        public string? ExternalAppUserId { get; set; } = default;

        public CreateUserRequestBodyArg(string name) {
            Name = name;
        }
    }
}