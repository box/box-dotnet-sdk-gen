using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WebLinkBase {
        /// <summary>
        /// The unique identifier for this web link
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `web_link`
        /// </summary>
        [JsonPropertyName("type")]
        public WebLinkBaseTypeField Type { get; set; }

        /// <summary>
        /// The entity tag of this web link. Used with `If-Match`
        /// headers.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; set; } = default;

        public WebLinkBase(string id, WebLinkBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}