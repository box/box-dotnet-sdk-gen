using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileMini : FileBase {
        [JsonPropertyName("sequence_id")]
        public string SequenceId { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("sha1")]
        public string Sha1 { get; }

        [JsonPropertyName("file_version")]
        public FileVersionMini FileVersion { get; }

        public FileMini(string id, string etag, FileBaseTypeField type, string sequenceId, string name, string sha1, FileVersionMini fileVersion) : base(id, etag, type) {
            SequenceId = sequenceId;
            Name = name;
            Sha1 = sha1;
            FileVersion = fileVersion;
        }
    }
}