using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg {
        [JsonPropertyName("op")]
        public UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgOpField Op { get; }

        [JsonPropertyName("path")]
        public UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgPathField Path { get; }

        [JsonPropertyName("value")]
        public string Value { get; }

        public UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg(UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgOpField op, UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgPathField path, string value) {
            Op = op;
            Path = path;
            Value = value;
        }
    }
}