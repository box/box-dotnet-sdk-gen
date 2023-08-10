using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileRequestBodyArgAttributesFieldParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public UploadFileRequestBodyArgAttributesFieldParentField(string id) {
            Id = id;
        }
    }
}