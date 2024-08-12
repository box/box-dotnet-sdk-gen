using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateFileUploadSessionCommitByUrlRequestBody {
        /// <summary>
        /// The list details for the uploaded parts
        /// </summary>
        [JsonPropertyName("parts")]
        public IReadOnlyList<UploadPart> Parts { get; }

        public CreateFileUploadSessionCommitByUrlRequestBody(IReadOnlyList<UploadPart> parts) {
            Parts = parts;
        }
    }
}