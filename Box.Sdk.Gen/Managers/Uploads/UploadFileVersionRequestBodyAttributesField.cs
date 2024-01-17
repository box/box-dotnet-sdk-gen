using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UploadFileVersionRequestBodyAttributesField {
        /// <summary>
        /// An optional new name for the file. If specified, the file
        /// will be renamed when the new version is uploaded.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Defines the time the file was last modified at.
        /// 
        /// If not set, the upload time will be used.
        /// </summary>
        [JsonPropertyName("content_modified_at")]
        public string? ContentModifiedAt { get; set; } = default;

        public UploadFileVersionRequestBodyAttributesField(string name) {
            Name = name;
        }
    }
}