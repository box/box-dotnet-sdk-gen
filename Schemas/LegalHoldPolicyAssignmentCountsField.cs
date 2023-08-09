using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class LegalHoldPolicyAssignmentCountsField {
        [JsonPropertyName("user")]
        public int? User { get; }

        [JsonPropertyName("folder")]
        public int? Folder { get; }

        [JsonPropertyName("file")]
        public int? File { get; }

        [JsonPropertyName("file_version")]
        public int? FileVersion { get; }

        public LegalHoldPolicyAssignmentCountsField(int? user, int? folder, int? file, int? fileVersion) {
            User = user;
            Folder = folder;
            File = file;
            FileVersion = fileVersion;
        }
    }
}