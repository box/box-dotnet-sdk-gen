using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateFolderLockRequestBodyFolderField {
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

        public CreateFolderLockRequestBodyFolderField(string type, string id) {
            Type = type;
            Id = id;
        }
    }
}