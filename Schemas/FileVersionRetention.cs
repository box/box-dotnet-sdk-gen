using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersionRetention {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public FileVersionRetentionTypeField Type { get; }

        [JsonPropertyName("file_version")]
        public FileVersionMini FileVersion { get; }

        [JsonPropertyName("file")]
        public FileMini File { get; }

        [JsonPropertyName("applied_at")]
        public string AppliedAt { get; }

        [JsonPropertyName("disposition_at")]
        public string DispositionAt { get; }

        [JsonPropertyName("winning_retention_policy")]
        public RetentionPolicyMini WinningRetentionPolicy { get; }

        public FileVersionRetention(string id, FileVersionRetentionTypeField type, FileVersionMini fileVersion, FileMini file, string appliedAt, string dispositionAt, RetentionPolicyMini winningRetentionPolicy) {
            Id = id;
            Type = type;
            FileVersion = fileVersion;
            File = file;
            AppliedAt = appliedAt;
            DispositionAt = dispositionAt;
            WinningRetentionPolicy = winningRetentionPolicy;
        }
    }
}