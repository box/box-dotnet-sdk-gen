using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class UploadFileRequestBodyAttributesField {
        /// <summary>
        /// The name of the file
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// The parent folder to upload the file to
        /// </summary>
        [JsonPropertyName("parent")]
        public UploadFileRequestBodyAttributesParentField Parent { get; }

        /// <summary>
        /// Defines the time the file was originally created at.
        /// 
        /// If not set, the upload time will be used.
        /// </summary>
        [JsonPropertyName("content_created_at")]
        public System.DateTimeOffset? ContentCreatedAt { get; init; }

        /// <summary>
        /// Defines the time the file was last modified at.
        /// 
        /// If not set, the upload time will be used.
        /// </summary>
        [JsonPropertyName("content_modified_at")]
        public System.DateTimeOffset? ContentModifiedAt { get; init; }

        public UploadFileRequestBodyAttributesField(string name, UploadFileRequestBodyAttributesParentField parent) {
            Name = name;
            Parent = parent;
        }
    }
}