using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateUserByIdRequestBodyArg {
        [JsonPropertyName("enterprise")]
        public string Enterprise { get; }

        [JsonPropertyName("notify")]
        public bool? Notify { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("login")]
        public string Login { get; }

        [JsonPropertyName("role")]
        public UpdateUserByIdRequestBodyArgRoleField Role { get; }

        [JsonPropertyName("language")]
        public string Language { get; }

        [JsonPropertyName("is_sync_enabled")]
        public bool? IsSyncEnabled { get; }

        [JsonPropertyName("job_title")]
        public string JobTitle { get; }

        [JsonPropertyName("phone")]
        public string Phone { get; }

        [JsonPropertyName("address")]
        public string Address { get; }

        [JsonPropertyName("tracking_codes")]
        public IReadOnlyList<TrackingCode> TrackingCodes { get; }

        [JsonPropertyName("can_see_managed_users")]
        public bool? CanSeeManagedUsers { get; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; }

        [JsonPropertyName("is_external_collab_restricted")]
        public bool? IsExternalCollabRestricted { get; }

        [JsonPropertyName("is_exempt_from_device_limits")]
        public bool? IsExemptFromDeviceLimits { get; }

        [JsonPropertyName("is_exempt_from_login_verification")]
        public bool? IsExemptFromLoginVerification { get; }

        [JsonPropertyName("is_password_reset_required")]
        public bool? IsPasswordResetRequired { get; }

        [JsonPropertyName("status")]
        public UpdateUserByIdRequestBodyArgStatusField Status { get; }

        [JsonPropertyName("space_amount")]
        public long? SpaceAmount { get; }

        [JsonPropertyName("notification_email")]
        public UpdateUserByIdRequestBodyArgNotificationEmailField NotificationEmail { get; }

        [JsonPropertyName("external_app_user_id")]
        public string ExternalAppUserId { get; }

        public UpdateUserByIdRequestBodyArg(string enterprise, bool? notify, string name, string login, UpdateUserByIdRequestBodyArgRoleField role, string language, bool? isSyncEnabled, string jobTitle, string phone, string address, IReadOnlyList<TrackingCode> trackingCodes, bool? canSeeManagedUsers, string timezone, bool? isExternalCollabRestricted, bool? isExemptFromDeviceLimits, bool? isExemptFromLoginVerification, bool? isPasswordResetRequired, UpdateUserByIdRequestBodyArgStatusField status, long? spaceAmount, UpdateUserByIdRequestBodyArgNotificationEmailField notificationEmail, string externalAppUserId) {
            Enterprise = enterprise;
            Notify = notify;
            Name = name;
            Login = login;
            Role = role;
            Language = language;
            IsSyncEnabled = isSyncEnabled;
            JobTitle = jobTitle;
            Phone = phone;
            Address = address;
            TrackingCodes = trackingCodes;
            CanSeeManagedUsers = canSeeManagedUsers;
            Timezone = timezone;
            IsExternalCollabRestricted = isExternalCollabRestricted;
            IsExemptFromDeviceLimits = isExemptFromDeviceLimits;
            IsExemptFromLoginVerification = isExemptFromLoginVerification;
            IsPasswordResetRequired = isPasswordResetRequired;
            Status = status;
            SpaceAmount = spaceAmount;
            NotificationEmail = notificationEmail;
            ExternalAppUserId = externalAppUserId;
        }
    }
}