using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullRepresentationsFieldEntriesFieldPropertiesField {
        [JsonPropertyName("dimensions")]
        public string Dimensions { get; }

        [JsonPropertyName("paged")]
        public bool? Paged { get; }

        [JsonPropertyName("thumb")]
        public bool? Thumb { get; }

        public FileFullRepresentationsFieldEntriesFieldPropertiesField(string dimensions, bool? paged, bool? thumb) {
            Dimensions = dimensions;
            Paged = paged;
            Thumb = thumb;
        }
    }
}