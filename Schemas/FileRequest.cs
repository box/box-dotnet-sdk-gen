using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileRequest {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public FileRequestTypeField Type { get; }

        [JsonPropertyName("title")]
        public string Title { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("status")]
        public FileRequestStatusField Status { get; }

        [JsonPropertyName("is_email_required")]
        public bool? IsEmailRequired { get; }

        [JsonPropertyName("is_description_required")]
        public bool? IsDescriptionRequired { get; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; }

        [JsonPropertyName("folder")]
        public FolderMini Folder { get; }

        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("etag")]
        public string Etag { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("updated_by")]
        public UserMini UpdatedBy { get; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; }

        public FileRequest(string id, FileRequestTypeField type, string title, string description, FileRequestStatusField status, bool? isEmailRequired, bool? isDescriptionRequired, string expiresAt, FolderMini folder, string url, string etag, UserMini createdBy, string createdAt, UserMini updatedBy, string updatedAt) {
            Id = id;
            Type = type;
            Title = title;
            Description = description;
            Status = status;
            IsEmailRequired = isEmailRequired;
            IsDescriptionRequired = isDescriptionRequired;
            ExpiresAt = expiresAt;
            Folder = folder;
            Url = url;
            Etag = etag;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            UpdatedBy = updatedBy;
            UpdatedAt = updatedAt;
        }
    }
}