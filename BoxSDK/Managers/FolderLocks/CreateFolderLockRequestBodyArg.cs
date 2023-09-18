using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderLockRequestBodyArg {
        /// <summary>
        /// The operations to lock for the folder. If `locked_operations` is
        /// included in the request, both `move` and `delete` must also be
        /// included and both set to `true`.
        /// </summary>
        [JsonPropertyName("locked_operations")]
        public CreateFolderLockRequestBodyArgLockedOperationsField? LockedOperations { get; set; } = default;

        /// <summary>
        /// The folder to apply the lock to.
        /// </summary>
        [JsonPropertyName("folder")]
        public CreateFolderLockRequestBodyArgFolderField Folder { get; set; }

        public CreateFolderLockRequestBodyArg(CreateFolderLockRequestBodyArgFolderField folder) {
            Folder = folder;
        }
    }
}