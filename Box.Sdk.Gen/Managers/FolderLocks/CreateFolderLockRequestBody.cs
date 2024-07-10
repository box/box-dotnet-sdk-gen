using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateFolderLockRequestBody {
        /// <summary>
        /// The operations to lock for the folder. If `locked_operations` is
        /// included in the request, both `move` and `delete` must also be
        /// included and both set to `true`.
        /// </summary>
        [JsonPropertyName("locked_operations")]
        public CreateFolderLockRequestBodyLockedOperationsField? LockedOperations { get; init; }

        /// <summary>
        /// The folder to apply the lock to.
        /// </summary>
        [JsonPropertyName("folder")]
        public CreateFolderLockRequestBodyFolderField Folder { get; }

        public CreateFolderLockRequestBody(CreateFolderLockRequestBodyFolderField folder) {
            Folder = folder;
        }
    }
}