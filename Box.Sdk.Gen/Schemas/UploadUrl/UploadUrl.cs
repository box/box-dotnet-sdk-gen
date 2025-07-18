using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class UploadUrl : ISerializable {
        /// <summary>
        /// A URL for an upload session that can be used to upload
        /// the file.
        /// </summary>
        [JsonPropertyName("upload_url")]
        public string? UploadUrlField { get; init; }

        /// <summary>
        /// An optional access token to use to upload the file.
        /// </summary>
        [JsonPropertyName("upload_token")]
        public string? UploadToken { get; init; }

        public UploadUrl() {
            
        }
        internal string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}