using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderLockRequestBodyArgLockedOperationsField {
        /// <summary>
        /// Whether moving the folder should be locked.
        /// </summary>
        [JsonPropertyName("move")]
        public bool Move { get; set; }

        /// <summary>
        /// Whether deleting the folder should be locked.
        /// </summary>
        [JsonPropertyName("delete")]
        public bool Delete { get; set; }

        public CreateFolderLockRequestBodyArgLockedOperationsField(bool move, bool delete) {
            Move = move;
            Delete = delete;
        }
    }
}