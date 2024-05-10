using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestSignFilesField {
        [JsonPropertyName("files")]
        public IReadOnlyList<FileMini>? Files { get; set; } = default;

        /// <summary>
        /// Indicates whether the `sign_files` documents are processing
        /// and the PDFs may be out of date. A change to any document
        /// requires processing on all `sign_files`. We
        /// recommended waiting until processing is finished
        /// (and this value is true) before downloading the PDFs.
        /// </summary>
        [JsonPropertyName("is_ready_for_download")]
        public bool? IsReadyForDownload { get; set; } = default;

        public SignRequestSignFilesField() {
            
        }
    }
}