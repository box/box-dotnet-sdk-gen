using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FolderLock {
        [JsonPropertyName("folder")]
        public FolderMini Folder { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("created_by")]
        public UserBase CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("locked_operations")]
        public FolderLockLockedOperationsField LockedOperations { get; }

        [JsonPropertyName("lock_type")]
        public string LockType { get; }

        public FolderLock(FolderMini folder, string id, string type, UserBase createdBy, string createdAt, FolderLockLockedOperationsField lockedOperations, string lockType) {
            Folder = folder;
            Id = id;
            Type = type;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            LockedOperations = lockedOperations;
            LockType = lockType;
        }
    }
}