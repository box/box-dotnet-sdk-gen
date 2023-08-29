using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersionRetention {
        /// <summary>
        /// The unique identifier for this file version retention.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `file_version_retention`
        /// </summary>
        [JsonPropertyName("type")]
        public FileVersionRetentionTypeField? Type { get; set; } = default;

        [JsonPropertyName("file_version")]
        public FileVersionMini? FileVersion { get; set; } = default;

        [JsonPropertyName("file")]
        public FileMini? File { get; set; } = default;

        /// <summary>
        /// When this file version retention object was
        /// created
        /// </summary>
        [JsonPropertyName("applied_at")]
        public string? AppliedAt { get; set; } = default;

        /// <summary>
        /// When the retention expires on this file
        /// version retention
        /// </summary>
        [JsonPropertyName("disposition_at")]
        public string? DispositionAt { get; set; } = default;

        [JsonPropertyName("winning_retention_policy")]
        public RetentionPolicyMini? WinningRetentionPolicy { get; set; } = default;

        public FileVersionRetention() {
            
        }
    }
}