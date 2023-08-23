using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class UserFull : User {
        [JsonPropertyName("role")]
        public UserFullRoleField Role { get; }

        [JsonPropertyName("tracking_codes")]
        public IReadOnlyList<TrackingCode> TrackingCodes { get; }

        [JsonPropertyName("can_see_managed_users")]
        public bool? CanSeeManagedUsers { get; }

        [JsonPropertyName("is_sync_enabled")]
        public bool? IsSyncEnabled { get; }

        [JsonPropertyName("is_external_collab_restricted")]
        public bool? IsExternalCollabRestricted { get; }

        [JsonPropertyName("is_exempt_from_device_limits")]
        public bool? IsExemptFromDeviceLimits { get; }

        [JsonPropertyName("is_exempt_from_login_verification")]
        public bool? IsExemptFromLoginVerification { get; }

        [JsonPropertyName("enterprise")]
        public UserFullEnterpriseField Enterprise { get; }

        [JsonPropertyName("my_tags")]
        public IReadOnlyList<string> MyTags { get; }

        [JsonPropertyName("hostname")]
        public string Hostname { get; }

        [JsonPropertyName("is_platform_access_only")]
        public bool? IsPlatformAccessOnly { get; }

        [JsonPropertyName("external_app_user_id")]
        public string ExternalAppUserId { get; }

        public UserFull(string id, UserBaseTypeField type, string name, string login, string createdAt, string modifiedAt, string language, string timezone, long? spaceAmount, long? spaceUsed, long? maxUploadSize, UserStatusField status, string jobTitle, string phone, string address, string avatarUrl, UserNotificationEmailField notificationEmail, UserFullRoleField role, IReadOnlyList<TrackingCode> trackingCodes, bool? canSeeManagedUsers, bool? isSyncEnabled, bool? isExternalCollabRestricted, bool? isExemptFromDeviceLimits, bool? isExemptFromLoginVerification, UserFullEnterpriseField enterprise, IReadOnlyList<string> myTags, string hostname, bool? isPlatformAccessOnly, string externalAppUserId) : base(id, type, name, login, createdAt, modifiedAt, language, timezone, spaceAmount, spaceUsed, maxUploadSize, status, jobTitle, phone, address, avatarUrl, notificationEmail) {
            Role = role;
            TrackingCodes = trackingCodes;
            CanSeeManagedUsers = canSeeManagedUsers;
            IsSyncEnabled = isSyncEnabled;
            IsExternalCollabRestricted = isExternalCollabRestricted;
            IsExemptFromDeviceLimits = isExemptFromDeviceLimits;
            IsExemptFromLoginVerification = isExemptFromLoginVerification;
            Enterprise = enterprise;
            MyTags = myTags;
            Hostname = hostname;
            IsPlatformAccessOnly = isPlatformAccessOnly;
            ExternalAppUserId = externalAppUserId;
        }
    }
}