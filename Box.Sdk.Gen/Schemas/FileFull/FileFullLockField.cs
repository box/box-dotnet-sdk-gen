using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileFullLockField {
        /// <summary>
        /// The unique identifier for this lock
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `lock`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<FileFullLockTypeField>))]
        public StringEnum<FileFullLockTypeField>? Type { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        /// <summary>
        /// The time this lock was created at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// The time this lock is to expire at, which might be in the past.
        /// </summary>
        [JsonPropertyName("expired_at")]
        public System.DateTimeOffset? ExpiredAt { get; init; }

        /// <summary>
        /// Whether or not the file can be downloaded while locked.
        /// </summary>
        [JsonPropertyName("is_download_prevented")]
        public bool? IsDownloadPrevented { get; init; }

        /// <summary>
        /// If the lock is managed by an application rather than a user, this
        /// field identifies the type of the application that holds the lock.
        /// This is an open enum and may be extended with additional values in
        /// the future.
        /// </summary>
        [JsonPropertyName("app_type")]
        [JsonConverter(typeof(StringEnumConverter<FileFullLockAppTypeField>))]
        public StringEnum<FileFullLockAppTypeField>? AppType { get; init; }

        public FileFullLockField() {
            
        }
    }
}