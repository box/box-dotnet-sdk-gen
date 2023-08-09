using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadUrl {
        [JsonPropertyName("upload_url")]
        public string UploadUrlField { get; }

        [JsonPropertyName("upload_token")]
        public string UploadToken { get; }

        public UploadUrl(string uploadUrlField, string uploadToken) {
            UploadUrlField = uploadUrlField;
            UploadToken = uploadToken;
        }
    }
}