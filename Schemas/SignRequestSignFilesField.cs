using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestSignFilesField {
        [JsonPropertyName("files")]
        public IReadOnlyList<FileMini> Files { get; }

        [JsonPropertyName("is_ready_for_download")]
        public bool? IsReadyForDownload { get; }

        public SignRequestSignFilesField(IReadOnlyList<FileMini> files, bool? isReadyForDownload) {
            Files = files;
            IsReadyForDownload = isReadyForDownload;
        }
    }
}