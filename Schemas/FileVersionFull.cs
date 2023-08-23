using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersionFull : FileVersion {
        [JsonPropertyName("version_number")]
        public string VersionNumber { get; }

        public FileVersionFull(string id, FileVersionBaseTypeField type, string sha1, string name, long? size, string createdAt, string modifiedAt, UserMini modifiedBy, string trashedAt, UserMini trashedBy, string restoredAt, UserMini restoredBy, string purgedAt, string uploaderDisplayName, string versionNumber) : base(id, type, sha1, name, size, createdAt, modifiedAt, modifiedBy, trashedAt, trashedBy, restoredAt, restoredBy, purgedAt, uploaderDisplayName) {
            VersionNumber = versionNumber;
        }
    }
}