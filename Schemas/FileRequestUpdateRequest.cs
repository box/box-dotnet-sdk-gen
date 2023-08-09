using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileRequestUpdateRequest {
        [JsonPropertyName("title")]
        public string Title { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("status")]
        public FileRequestUpdateRequestStatusField Status { get; }

        [JsonPropertyName("is_email_required")]
        public bool? IsEmailRequired { get; }

        [JsonPropertyName("is_description_required")]
        public bool? IsDescriptionRequired { get; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; }

        public FileRequestUpdateRequest(string title, string description, FileRequestUpdateRequestStatusField status, bool? isEmailRequired, bool? isDescriptionRequired, string expiresAt) {
            Title = title;
            Description = description;
            Status = status;
            IsEmailRequired = isEmailRequired;
            IsDescriptionRequired = isDescriptionRequired;
            ExpiresAt = expiresAt;
        }
    }
}