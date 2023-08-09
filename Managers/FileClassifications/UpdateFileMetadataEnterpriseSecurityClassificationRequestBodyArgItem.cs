using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgItem {
        [JsonPropertyName("op")]
        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgItemOpField Op { get; }

        [JsonPropertyName("path")]
        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgItemPathField Path { get; }

        [JsonPropertyName("value")]
        public string Value { get; }

        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgItem(UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgItemOpField op, UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgItemPathField path, string value) {
            Op = op;
            Path = path;
            Value = value;
        }
    }
}