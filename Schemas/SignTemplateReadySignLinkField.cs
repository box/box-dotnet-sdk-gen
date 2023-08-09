using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignTemplateReadySignLinkField {
        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("instructions")]
        public string Instructions { get; }

        [JsonPropertyName("folder_id")]
        public string FolderId { get; }

        [JsonPropertyName("is_notification_disabled")]
        public bool? IsNotificationDisabled { get; }

        [JsonPropertyName("is_active")]
        public bool? IsActive { get; }

        public SignTemplateReadySignLinkField(string url, string name, string instructions, string folderId, bool? isNotificationDisabled, bool? isActive) {
            Url = url;
            Name = name;
            Instructions = instructions;
            FolderId = folderId;
            IsNotificationDisabled = isNotificationDisabled;
            IsActive = isActive;
        }
    }
}