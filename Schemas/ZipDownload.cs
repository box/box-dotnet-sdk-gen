using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class ZipDownload {
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; }

        [JsonPropertyName("status_url")]
        public string StatusUrl { get; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; }

        [JsonPropertyName("name_conflicts")]
        public IReadOnlyList<IReadOnlyList<ZipDownloadNameConflictsField>> NameConflicts { get; }

        public ZipDownload(string downloadUrl, string statusUrl, string expiresAt, IReadOnlyList<IReadOnlyList<ZipDownloadNameConflictsField>> nameConflicts) {
            DownloadUrl = downloadUrl;
            StatusUrl = statusUrl;
            ExpiresAt = expiresAt;
            NameConflicts = nameConflicts;
        }
    }
}