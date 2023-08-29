using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileRequestBodyArgAttributesField {
        /// <summary>
        /// The name of the file
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The parent folder to upload the file to
        /// </summary>
        [JsonPropertyName("parent")]
        public UploadFileRequestBodyArgAttributesFieldParentField Parent { get; set; }

        /// <summary>
        /// Defines the time the file was originally created at.
        /// 
        /// If not set, the upload time will be used.
        /// </summary>
        [JsonPropertyName("content_created_at")]
        public string? ContentCreatedAt { get; set; } = default;

        /// <summary>
        /// Defines the time the file was last modified at.
        /// 
        /// If not set, the upload time will be used.
        /// </summary>
        [JsonPropertyName("content_modified_at")]
        public string? ContentModifiedAt { get; set; } = default;

        public UploadFileRequestBodyArgAttributesField(string name, UploadFileRequestBodyArgAttributesFieldParentField parent) {
            Name = name;
            Parent = parent;
        }
    }
}