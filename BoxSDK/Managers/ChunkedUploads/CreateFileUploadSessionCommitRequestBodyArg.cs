using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionCommitRequestBodyArg {
        /// <summary>
        /// The list details for the uploaded parts
        /// </summary>
        [JsonPropertyName("parts")]
        public IReadOnlyList<UploadPart> Parts { get; set; }

        public CreateFileUploadSessionCommitRequestBodyArg(IReadOnlyList<UploadPart> parts) {
            Parts = parts;
        }
    }
}