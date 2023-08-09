using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersionBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public FileVersionBaseTypeField Type { get; }

        public FileVersionBase(string id, FileVersionBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}