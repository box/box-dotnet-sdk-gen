using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FolderLockLockedOperationsField {
        /// <summary>
        /// Whether moving the folder is restricted.
        /// </summary>
        [JsonPropertyName("move")]
        public bool Move { get; set; }

        /// <summary>
        /// Whether deleting the folder is restricted.
        /// </summary>
        [JsonPropertyName("delete")]
        public bool Delete { get; set; }

        public FolderLockLockedOperationsField(bool move, bool delete) {
            Move = move;
            Delete = delete;
        }
    }
}