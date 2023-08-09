using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FolderMini : FolderBase {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("sequence_id")]
        public string SequenceId { get; }

        public FolderMini(string id, string etag, FolderBaseTypeField type, string name, string sequenceId) : base(id, etag, type) {
            Name = name;
            SequenceId = sequenceId;
        }
    }
}