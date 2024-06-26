using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersionRetention {
        /// <summary>
        /// The unique identifier for this file version retention.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `file_version_retention`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<FileVersionRetentionTypeField>))]
        public StringEnum<FileVersionRetentionTypeField>? Type { get; init; }

        [JsonPropertyName("file_version")]
        public FileVersionMini? FileVersion { get; init; }

        [JsonPropertyName("file")]
        public FileMini? File { get; init; }

        /// <summary>
        /// When this file version retention object was
        /// created
        /// </summary>
        [JsonPropertyName("applied_at")]
        public System.DateTimeOffset? AppliedAt { get; init; }

        /// <summary>
        /// When the retention expires on this file
        /// version retention
        /// </summary>
        [JsonPropertyName("disposition_at")]
        public System.DateTimeOffset? DispositionAt { get; init; }

        [JsonPropertyName("winning_retention_policy")]
        public RetentionPolicyMini? WinningRetentionPolicy { get; init; }

        public FileVersionRetention() {
            
        }
    }
}