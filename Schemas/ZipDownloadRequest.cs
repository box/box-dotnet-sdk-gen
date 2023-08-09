using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ZipDownloadRequest {
        [JsonPropertyName("items")]
        public IReadOnlyList<ZipDownloadRequestItemsField> Items { get; }

        [JsonPropertyName("download_file_name")]
        public string DownloadFileName { get; }

        public ZipDownloadRequest(IReadOnlyList<ZipDownloadRequestItemsField> items, string downloadFileName) {
            Items = items;
            DownloadFileName = downloadFileName;
        }
    }
}