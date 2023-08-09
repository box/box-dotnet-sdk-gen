using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderLockRequestBodyArgLockedOperationsField {
        [JsonPropertyName("move")]
        public bool Move { get; }

        [JsonPropertyName("delete")]
        public bool Delete { get; }

        public CreateFolderLockRequestBodyArgLockedOperationsField(bool move, bool delete) {
            Move = move;
            Delete = delete;
        }
    }
}