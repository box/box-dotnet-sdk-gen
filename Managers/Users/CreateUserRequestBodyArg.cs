using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("login")]
        public string Login { get; }

        [JsonPropertyName("is_platform_access_only")]
        public bool? IsPlatformAccessOnly { get; }

        [JsonPropertyName("role")]
        public CreateUserRequestBodyArgRoleField Role { get; }

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

        [JsonPropertyName("space_amount")]
        public int? SpaceAmount { get; }

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

        [JsonPropertyName("status")]
        public CreateUserRequestBodyArgStatusField Status { get; }

        [JsonPropertyName("external_app_user_id")]
        public string ExternalAppUserId { get; }

        public CreateUserRequestBodyArg(string name, string login, bool? isPlatformAccessOnly, CreateUserRequestBodyArgRoleField role, string language, bool? isSyncEnabled, string jobTitle, string phone, string address, int? spaceAmount, IReadOnlyList<TrackingCode> trackingCodes, bool? canSeeManagedUsers, string timezone, bool? isExternalCollabRestricted, bool? isExemptFromDeviceLimits, bool? isExemptFromLoginVerification, CreateUserRequestBodyArgStatusField status, string externalAppUserId) {
            Name = name;
            Login = login;
            IsPlatformAccessOnly = isPlatformAccessOnly;
            Role = role;
            Language = language;
            IsSyncEnabled = isSyncEnabled;
            JobTitle = jobTitle;
            Phone = phone;
            Address = address;
            SpaceAmount = spaceAmount;
            TrackingCodes = trackingCodes;
            CanSeeManagedUsers = canSeeManagedUsers;
            Timezone = timezone;
            IsExternalCollabRestricted = isExternalCollabRestricted;
            IsExemptFromDeviceLimits = isExemptFromDeviceLimits;
            IsExemptFromLoginVerification = isExemptFromLoginVerification;
            Status = status;
            ExternalAppUserId = externalAppUserId;
        }
    }
}