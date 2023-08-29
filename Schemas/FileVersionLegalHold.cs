using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FileVersionLegalHold {
        /// <summary>
        /// The unique identifier for this file version legal hold
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `file_version_legal_hold`
        /// </summary>
        [JsonPropertyName("type")]
        public FileVersionLegalHoldTypeField? Type { get; set; } = default;

        [JsonPropertyName("file_version")]
        public FileVersionMini? FileVersion { get; set; } = default;

        [JsonPropertyName("file")]
        public FileMini? File { get; set; } = default;

        /// <summary>
        /// List of assignments contributing to this Hold.
        /// </summary>
        [JsonPropertyName("legal_hold_policy_assignments")]
        public IReadOnlyList<LegalHoldPolicyAssignment>? LegalHoldPolicyAssignments { get; set; } = default;

        /// <summary>
        /// Time that this File-Version-Legal-Hold was
        /// deleted.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string? DeletedAt { get; set; } = default;

        public FileVersionLegalHold() {
            
        }
    }
}