using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateFolderRequestBody {
        /// <summary>
        /// The name for the new folder.
        /// 
        /// There are some restrictions to the file name. Names containing
        /// non-printable ASCII characters, forward and backward slashes
        /// (`/`, `\`), as well as names with trailing spaces are
        /// prohibited.
        /// 
        /// Additionally, the names `.` and `..` are
        /// not allowed either.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The parent folder to create the new folder within.
        /// </summary>
        [JsonPropertyName("parent")]
        public CreateFolderRequestBodyParentField Parent { get; set; }

        [JsonPropertyName("folder_upload_email")]
        public CreateFolderRequestBodyFolderUploadEmailField? FolderUploadEmail { get; set; } = default;

        /// <summary>
        /// Specifies whether a folder should be synced to a
        /// user's device or not. This is used by Box Sync
        /// (discontinued) and is not used by Box Drive.
        /// </summary>
        [JsonPropertyName("sync_state")]
        public CreateFolderRequestBodySyncStateField? SyncState { get; set; } = default;

        public CreateFolderRequestBody(string name, CreateFolderRequestBodyParentField parent) {
            Name = name;
            Parent = parent;
        }
    }
}