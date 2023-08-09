using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class ZipDownloadNameConflictsField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ZipDownloadNameConflictsFieldTypeField Type { get; }

        [JsonPropertyName("original_name")]
        public string OriginalName { get; }

        [JsonPropertyName("download_name")]
        public string DownloadName { get; }

        public ZipDownloadNameConflictsField(string id, ZipDownloadNameConflictsFieldTypeField type, string originalName, string downloadName) {
            Id = id;
            Type = type;
            OriginalName = originalName;
            DownloadName = downloadName;
        }
    }
}