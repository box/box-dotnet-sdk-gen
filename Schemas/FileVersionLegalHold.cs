using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FileVersionLegalHold {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public FileVersionLegalHoldTypeField Type { get; }

        [JsonPropertyName("file_version")]
        public FileVersionMini FileVersion { get; }

        [JsonPropertyName("file")]
        public FileMini File { get; }

        [JsonPropertyName("legal_hold_policy_assignments")]
        public IReadOnlyList<LegalHoldPolicyAssignment> LegalHoldPolicyAssignments { get; }

        [JsonPropertyName("deleted_at")]
        public string DeletedAt { get; }

        public FileVersionLegalHold(string id, FileVersionLegalHoldTypeField type, FileVersionMini fileVersion, FileMini file, IReadOnlyList<LegalHoldPolicyAssignment> legalHoldPolicyAssignments, string deletedAt) {
            Id = id;
            Type = type;
            FileVersion = fileVersion;
            File = file;
            LegalHoldPolicyAssignments = legalHoldPolicyAssignments;
            DeletedAt = deletedAt;
        }
    }
}