using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadUrl {
        /// <summary>
        /// A URL for an upload session that can be used to upload
        /// the file.
        /// </summary>
        [JsonPropertyName("upload_url")]
        public string? UploadUrlField { get; set; } = default;

        /// <summary>
        /// An optional access token to use to upload the file
        /// </summary>
        [JsonPropertyName("upload_token")]
        public string? UploadToken { get; set; } = default;

        public UploadUrl() {
            
        }
    }
}