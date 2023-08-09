using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullRepresentationsFieldEntriesFieldContentField {
        [JsonPropertyName("url_template")]
        public string UrlTemplate { get; }

        public FileFullRepresentationsFieldEntriesFieldContentField(string urlTemplate) {
            UrlTemplate = urlTemplate;
        }
    }
}