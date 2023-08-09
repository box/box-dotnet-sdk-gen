using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WebLinkBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public WebLinkBaseTypeField Type { get; }

        [JsonPropertyName("etag")]
        public string Etag { get; }

        public WebLinkBase(string id, WebLinkBaseTypeField type, string etag) {
            Id = id;
            Type = type;
            Etag = etag;
        }
    }
}