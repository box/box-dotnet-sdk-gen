using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FolderLock {
        [JsonPropertyName("folder")]
        public FolderMini? Folder { get; set; } = default;

        /// <summary>
        /// The unique identifier for this folder lock.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The object type, always `folder_lock`.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; set; } = default;

        /// <summary>
        /// When the folder lock object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// The operations that have been locked. Currently the `move`
        /// and `delete` operations cannot be locked separately, and both need to be
        /// set to `true`.
        /// 
        /// </summary>
        [JsonPropertyName("locked_operations")]
        public FolderLockLockedOperationsField? LockedOperations { get; set; } = default;

        /// <summary>
        /// The lock type, always `freeze`.
        /// </summary>
        [JsonPropertyName("lock_type")]
        public string? LockType { get; set; } = default;

        public FolderLock() {
            
        }
    }
}