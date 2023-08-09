using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileVersionRequestBodyArgAttributesField {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("content_modified_at")]
        public string ContentModifiedAt { get; }

        public UploadFileVersionRequestBodyArgAttributesField(string name, string contentModifiedAt) {
            Name = name;
            ContentModifiedAt = contentModifiedAt;
        }
    }
}