using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderMetadataByIdRequestBodyArgItem {
        [JsonPropertyName("op")]
        public UpdateFolderMetadataByIdRequestBodyArgItemOpField Op { get; }

        [JsonPropertyName("path")]
        public string Path { get; }

        [JsonPropertyName("value")]
        public string Value { get; }

        [JsonPropertyName("from")]
        public string From { get; }

        public UpdateFolderMetadataByIdRequestBodyArgItem(UpdateFolderMetadataByIdRequestBodyArgItemOpField op, string path, string value, string from) {
            Op = op;
            Path = path;
            Value = value;
            From = from;
        }
    }
}