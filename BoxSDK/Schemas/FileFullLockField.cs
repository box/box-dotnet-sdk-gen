using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullLockField {
        /// <summary>
        /// The unique identifier for this lock
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `lock`
        /// </summary>
        [JsonPropertyName("type")]
        public FileFullLockFieldTypeField? Type { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        /// <summary>
        /// The time this lock was created at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// The time this lock is to expire at, which might be in the past.
        /// </summary>
        [JsonPropertyName("expired_at")]
        public string? ExpiredAt { get; set; } = default;

        /// <summary>
        /// Whether or not the file can be downloaded while locked.
        /// </summary>
        [JsonPropertyName("is_download_prevented")]
        public bool? IsDownloadPrevented { get; set; } = default;

        /// <summary>
        /// If the lock is managed by an application rather than a user, this
        /// field identifies the type of the application that holds the lock.
        /// This is an open enum and may be extended with additional values in
        /// the future.
        /// </summary>
        [JsonPropertyName("app_type")]
        public FileFullLockFieldAppTypeField? AppType { get; set; } = default;

        public FileFullLockField() {
            
        }
    }
}