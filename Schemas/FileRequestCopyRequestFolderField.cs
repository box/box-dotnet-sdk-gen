using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileRequestCopyRequestFolderField {
        [JsonPropertyName("type")]
        public FileRequestCopyRequestFolderFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public FileRequestCopyRequestFolderField(FileRequestCopyRequestFolderFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}