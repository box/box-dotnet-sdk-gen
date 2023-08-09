using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WebLinkMini : WebLinkBase {
        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("sequence_id")]
        public string SequenceId { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public WebLinkMini(string id, WebLinkBaseTypeField type, string etag, string url, string sequenceId, string name) : base(id, type, etag) {
            Url = url;
            SequenceId = sequenceId;
            Name = name;
        }
    }
}