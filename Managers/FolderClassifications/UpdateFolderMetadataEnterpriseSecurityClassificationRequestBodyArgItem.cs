using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgItem {
        [JsonPropertyName("op")]
        public UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgItemOpField Op { get; }

        [JsonPropertyName("path")]
        public UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgItemPathField Path { get; }

        [JsonPropertyName("value")]
        public string Value { get; }

        public UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgItem(UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgItemOpField op, UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgItemPathField path, string value) {
            Op = op;
            Path = path;
            Value = value;
        }
    }
}