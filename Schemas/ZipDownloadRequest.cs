using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ZipDownloadRequest {
        /// <summary>
        /// A list of items to add to the `zip` archive. These can
        /// be folders or files.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<ZipDownloadRequestItemsField> Items { get; set; }

        /// <summary>
        /// The optional name of the `zip` archive. This name will be appended by the
        /// `.zip` file extension, for example `January Financials.zip`.
        /// </summary>
        [JsonPropertyName("download_file_name")]
        public string? DownloadFileName { get; set; } = default;

        public ZipDownloadRequest(IReadOnlyList<ZipDownloadRequestItemsField> items) {
            Items = items;
        }
    }
}