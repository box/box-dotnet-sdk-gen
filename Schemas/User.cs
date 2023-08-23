using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class User : UserMini {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("language")]
        public string Language { get; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; }

        [JsonPropertyName("space_amount")]
        public long? SpaceAmount { get; }

        [JsonPropertyName("space_used")]
        public long? SpaceUsed { get; }

        [JsonPropertyName("max_upload_size")]
        public long? MaxUploadSize { get; }

        [JsonPropertyName("status")]
        public UserStatusField Status { get; }

        [JsonPropertyName("job_title")]
        public string JobTitle { get; }

        [JsonPropertyName("phone")]
        public string Phone { get; }

        [JsonPropertyName("address")]
        public string Address { get; }

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; }

        [JsonPropertyName("notification_email")]
        public UserNotificationEmailField NotificationEmail { get; }

        public User(string id, UserBaseTypeField type, string name, string login, string createdAt, string modifiedAt, string language, string timezone, long? spaceAmount, long? spaceUsed, long? maxUploadSize, UserStatusField status, string jobTitle, string phone, string address, string avatarUrl, UserNotificationEmailField notificationEmail) : base(id, type, name, login) {
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Language = language;
            Timezone = timezone;
            SpaceAmount = spaceAmount;
            SpaceUsed = spaceUsed;
            MaxUploadSize = maxUploadSize;
            Status = status;
            JobTitle = jobTitle;
            Phone = phone;
            Address = address;
            AvatarUrl = avatarUrl;
            NotificationEmail = notificationEmail;
        }
    }
}