using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class UserFull : User {
        /// <summary>
        /// The user’s enterprise role
        /// </summary>
        [JsonPropertyName("role")]
        public UserFullRoleField? Role { get; set; } = default;

        /// <summary>
        /// Tracking codes allow an admin to generate reports from the
        /// admin console and assign an attribute to a specific group
        /// of users. This setting must be enabled for an enterprise
        /// before it can be used.
        /// </summary>
        [JsonPropertyName("tracking_codes")]
        public IReadOnlyList<TrackingCode>? TrackingCodes { get; set; } = default;

        /// <summary>
        /// Whether the user can see other enterprise users in their contact list
        /// </summary>
        [JsonPropertyName("can_see_managed_users")]
        public bool? CanSeeManagedUsers { get; set; } = default;

        /// <summary>
        /// Whether the user can use Box Sync
        /// </summary>
        [JsonPropertyName("is_sync_enabled")]
        public bool? IsSyncEnabled { get; set; } = default;

        /// <summary>
        /// Whether the user is allowed to collaborate with users outside their
        /// enterprise
        /// </summary>
        [JsonPropertyName("is_external_collab_restricted")]
        public bool? IsExternalCollabRestricted { get; set; } = default;

        /// <summary>
        /// Whether to exempt the user from Enterprise device limits
        /// </summary>
        [JsonPropertyName("is_exempt_from_device_limits")]
        public bool? IsExemptFromDeviceLimits { get; set; } = default;

        /// <summary>
        /// Whether the user must use two-factor authentication
        /// </summary>
        [JsonPropertyName("is_exempt_from_login_verification")]
        public bool? IsExemptFromLoginVerification { get; set; } = default;

        [JsonPropertyName("enterprise")]
        public UserFullEnterpriseField? Enterprise { get; set; } = default;

        /// <summary>
        /// Tags for all files and folders owned by the user. Values returned
        /// will only contain tags that were set by the requester.
        /// </summary>
        [JsonPropertyName("my_tags")]
        public IReadOnlyList<string>? MyTags { get; set; } = default;

        /// <summary>
        /// The root (protocol, subdomain, domain) of any links that need to be
        /// generated for the user
        /// </summary>
        [JsonPropertyName("hostname")]
        public string? Hostname { get; set; } = default;

        /// <summary>
        /// Whether the user is an App User
        /// </summary>
        [JsonPropertyName("is_platform_access_only")]
        public bool? IsPlatformAccessOnly { get; set; } = default;

        /// <summary>
        /// An external identifier for an app user, which can be used to look up
        /// the user. This can be used to tie user IDs from external identity
        /// providers to Box users.
        /// </summary>
        [JsonPropertyName("external_app_user_id")]
        public string? ExternalAppUserId { get; set; } = default;

        public UserFull(string id, UserBaseTypeField type) : base(id, type) {
            
        }
    }
}