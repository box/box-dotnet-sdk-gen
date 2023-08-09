using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FolderLockLockedOperationsField {
        [JsonPropertyName("move")]
        public bool Move { get; }

        [JsonPropertyName("delete")]
        public bool Delete { get; }

        public FolderLockLockedOperationsField(bool move, bool delete) {
            Move = move;
            Delete = delete;
        }
    }
}