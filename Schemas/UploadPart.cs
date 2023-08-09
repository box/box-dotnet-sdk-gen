using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadPart : UploadPartMini {
        [JsonPropertyName("sha1")]
        public string Sha1 { get; }

        public UploadPart(string partId, int? offset, int? size, string sha1) : base(partId, offset, size) {
            Sha1 = sha1;
        }
    }
}