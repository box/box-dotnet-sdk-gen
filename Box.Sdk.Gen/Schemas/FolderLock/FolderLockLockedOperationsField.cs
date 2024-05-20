using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FolderLockLockedOperationsField {
        /// <summary>
        /// Whether moving the folder is restricted.
        /// </summary>
        [JsonPropertyName("move")]
        public bool Move { get; }

        /// <summary>
        /// Whether deleting the folder is restricted.
        /// </summary>
        [JsonPropertyName("delete")]
        public bool Delete { get; }

        public FolderLockLockedOperationsField(bool move, bool delete) {
            Move = move;
            Delete = delete;
        }
    }
}