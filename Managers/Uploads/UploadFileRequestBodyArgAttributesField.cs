using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileRequestBodyArgAttributesField {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("parent")]
        public UploadFileRequestBodyArgAttributesFieldParentField Parent { get; }

        [JsonPropertyName("content_created_at")]
        public string ContentCreatedAt { get; }

        [JsonPropertyName("content_modified_at")]
        public string ContentModifiedAt { get; }

        public UploadFileRequestBodyArgAttributesField(string name, UploadFileRequestBodyArgAttributesFieldParentField parent, string contentCreatedAt, string contentModifiedAt) {
            Name = name;
            Parent = parent;
            ContentCreatedAt = contentCreatedAt;
            ContentModifiedAt = contentModifiedAt;
        }
    }
}