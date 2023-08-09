using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionCommitRequestBodyArg {
        [JsonPropertyName("parts")]
        public IReadOnlyList<UploadPart> Parts { get; }

        public CreateFileUploadSessionCommitRequestBodyArg(IReadOnlyList<UploadPart> parts) {
            Parts = parts;
        }
    }
}