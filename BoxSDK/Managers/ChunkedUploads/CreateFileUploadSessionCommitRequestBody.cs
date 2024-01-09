using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionCommitRequestBody {
        /// <summary>
        /// The list details for the uploaded parts
        /// </summary>
        [JsonPropertyName("parts")]
        public IReadOnlyList<UploadPart> Parts { get; set; }

        public CreateFileUploadSessionCommitRequestBody(IReadOnlyList<UploadPart> parts) {
            Parts = parts;
        }
    }
}