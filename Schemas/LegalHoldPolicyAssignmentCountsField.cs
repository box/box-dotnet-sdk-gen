using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class LegalHoldPolicyAssignmentCountsField {
        [JsonPropertyName("user")]
        public long? User { get; }

        [JsonPropertyName("folder")]
        public long? Folder { get; }

        [JsonPropertyName("file")]
        public long? File { get; }

        [JsonPropertyName("file_version")]
        public long? FileVersion { get; }

        public LegalHoldPolicyAssignmentCountsField(long? user, long? folder, long? file, long? fileVersion) {
            User = user;
            Folder = folder;
            File = file;
            FileVersion = fileVersion;
        }
    }
}