using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ZipDownloadStatus {
        /// <summary>
        /// The total number of files in the archive.
        /// </summary>
        [JsonPropertyName("total_file_count")]
        public long? TotalFileCount { get; set; } = default;

        /// <summary>
        /// The number of files that have already been downloaded.
        /// </summary>
        [JsonPropertyName("downloaded_file_count")]
        public long? DownloadedFileCount { get; set; } = default;

        /// <summary>
        /// The number of files that have been skipped as they could not be
        /// downloaded. In many cases this is due to permission issues that have
        /// surfaced between the creation of the request for the archive and the
        /// archive being downloaded.
        /// </summary>
        [JsonPropertyName("skipped_file_count")]
        public long? SkippedFileCount { get; set; } = default;

        /// <summary>
        /// The number of folders that have been skipped as they could not be
        /// downloaded. In many cases this is due to permission issues that have
        /// surfaced between the creation of the request for the archive and the
        /// archive being downloaded.
        /// </summary>
        [JsonPropertyName("skipped_folder_count")]
        public long? SkippedFolderCount { get; set; } = default;

        /// <summary>
        /// The state of the archive being downloaded.
        /// </summary>
        [JsonPropertyName("state")]
        public ZipDownloadStatusStateField? State { get; set; } = default;

        public ZipDownloadStatus() {
            
        }
    }
}