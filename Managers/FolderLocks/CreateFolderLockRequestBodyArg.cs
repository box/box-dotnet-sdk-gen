using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderLockRequestBodyArg {
        [JsonPropertyName("locked_operations")]
        public CreateFolderLockRequestBodyArgLockedOperationsField LockedOperations { get; }

        [JsonPropertyName("folder")]
        public CreateFolderLockRequestBodyArgFolderField Folder { get; }

        public CreateFolderLockRequestBodyArg(CreateFolderLockRequestBodyArgLockedOperationsField lockedOperations, CreateFolderLockRequestBodyArgFolderField folder) {
            LockedOperations = lockedOperations;
            Folder = folder;
        }
    }
}