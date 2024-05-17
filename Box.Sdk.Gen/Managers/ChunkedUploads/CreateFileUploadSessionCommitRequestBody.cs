using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateFileUploadSessionCommitRequestBody {
        /// <summary>
        /// The list details for the uploaded parts
        /// </summary>
        [JsonPropertyName("parts")]
        public IReadOnlyList<UploadPart> Parts { get; }

        public CreateFileUploadSessionCommitRequestBody(IReadOnlyList<UploadPart> parts) {
            Parts = parts;
        }
    }
}