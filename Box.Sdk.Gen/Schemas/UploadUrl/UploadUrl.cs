using Box.Sdk.Gen;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class UploadUrl {
        /// <summary>
        /// A URL for an upload session that can be used to upload
        /// the file.
        /// </summary>
        [JsonPropertyName("upload_url")]
        public string? UploadUrlField { get; init; }

        /// <summary>
        /// An optional access token to use to upload the file
        /// </summary>
        [JsonPropertyName("upload_token")]
        public string? UploadToken { get; init; }

        public UploadUrl() {
            
        }
    }
}