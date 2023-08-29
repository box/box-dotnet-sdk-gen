using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderRequestBodyArg {
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
        public CreateFolderRequestBodyArgParentField Parent { get; set; }

        [JsonPropertyName("folder_upload_email")]
        public CreateFolderRequestBodyArgFolderUploadEmailField? FolderUploadEmail { get; set; } = default;

        /// <summary>
        /// Specifies whether a folder should be synced to a
        /// user's device or not. This is used by Box Sync
        /// (discontinued) and is not used by Box Drive.
        /// </summary>
        [JsonPropertyName("sync_state")]
        public CreateFolderRequestBodyArgSyncStateField? SyncState { get; set; } = default;

        public CreateFolderRequestBodyArg(string name, CreateFolderRequestBodyArgParentField parent) {
            Name = name;
            Parent = parent;
        }
    }
}