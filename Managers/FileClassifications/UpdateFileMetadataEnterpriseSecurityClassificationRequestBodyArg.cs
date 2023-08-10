using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArg {
        [JsonPropertyName("op")]
        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgOpField Op { get; }

        [JsonPropertyName("path")]
        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgPathField Path { get; }

        [JsonPropertyName("value")]
        public string Value { get; }

        public UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArg(UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgOpField op, UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgPathField path, string value) {
            Op = op;
            Path = path;
            Value = value;
        }
    }
}