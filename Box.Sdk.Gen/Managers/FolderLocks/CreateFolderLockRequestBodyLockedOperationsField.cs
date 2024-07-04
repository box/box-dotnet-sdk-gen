using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateFolderLockRequestBodyLockedOperationsField {
        /// <summary>
        /// Whether moving the folder should be locked.
        /// </summary>
        [JsonPropertyName("move")]
        public bool Move { get; }

        /// <summary>
        /// Whether deleting the folder should be locked.
        /// </summary>
        [JsonPropertyName("delete")]
        public bool Delete { get; }

        public CreateFolderLockRequestBodyLockedOperationsField(bool move, bool delete) {
            Move = move;
            Delete = delete;
        }
    }
}