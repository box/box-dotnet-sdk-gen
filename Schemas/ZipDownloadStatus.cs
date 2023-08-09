using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class ZipDownloadStatus {
        [JsonPropertyName("total_file_count")]
        public int? TotalFileCount { get; }

        [JsonPropertyName("downloaded_file_count")]
        public int? DownloadedFileCount { get; }

        [JsonPropertyName("skipped_file_count")]
        public int? SkippedFileCount { get; }

        [JsonPropertyName("skipped_folder_count")]
        public int? SkippedFolderCount { get; }

        [JsonPropertyName("state")]
        public ZipDownloadStatusStateField State { get; }

        public ZipDownloadStatus(int? totalFileCount, int? downloadedFileCount, int? skippedFileCount, int? skippedFolderCount, ZipDownloadStatusStateField state) {
            TotalFileCount = totalFileCount;
            DownloadedFileCount = downloadedFileCount;
            SkippedFileCount = skippedFileCount;
            SkippedFolderCount = skippedFolderCount;
            State = state;
        }
    }
}