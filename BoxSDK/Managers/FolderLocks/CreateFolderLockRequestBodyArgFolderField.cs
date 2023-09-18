using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderLockRequestBodyArgFolderField {
        /// <summary>
        /// The content type the lock is being applied to. Only `folder`
        /// is supported.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the folder.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateFolderLockRequestBodyArgFolderField(string type, string id) {
            Type = type;
            Id = id;
        }
    }
}