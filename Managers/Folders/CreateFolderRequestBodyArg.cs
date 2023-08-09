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
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("parent")]
        public CreateFolderRequestBodyArgParentField Parent { get; }

        [JsonPropertyName("folder_upload_email")]
        public CreateFolderRequestBodyArgFolderUploadEmailField FolderUploadEmail { get; }

        [JsonPropertyName("sync_state")]
        public CreateFolderRequestBodyArgSyncStateField SyncState { get; }

        public CreateFolderRequestBodyArg(string name, CreateFolderRequestBodyArgParentField parent, CreateFolderRequestBodyArgFolderUploadEmailField folderUploadEmail, CreateFolderRequestBodyArgSyncStateField syncState) {
            Name = name;
            Parent = parent;
            FolderUploadEmail = folderUploadEmail;
            SyncState = syncState;
        }
    }
}