using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("etag")]
        public string Etag { get; }

        [JsonPropertyName("type")]
        public FileBaseTypeField Type { get; }

        public FileBase(string id, string etag, FileBaseTypeField type) {
            Id = id;
            Etag = etag;
            Type = type;
        }
    }
}