using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FolderBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("etag")]
        public string Etag { get; }

        [JsonPropertyName("type")]
        public FolderBaseTypeField Type { get; }

        public FolderBase(string id, string etag, FolderBaseTypeField type) {
            Id = id;
            Etag = etag;
            Type = type;
        }
    }
}