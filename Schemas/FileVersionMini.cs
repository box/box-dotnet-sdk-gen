using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersionMini : FileVersionBase {
        [JsonPropertyName("sha1")]
        public string Sha1 { get; }

        public FileVersionMini(string id, FileVersionBaseTypeField type, string sha1) : base(id, type) {
            Sha1 = sha1;
        }
    }
}