using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg {
        [JsonPropertyName("Box__Security__Classification__Key")]
        public string BoxSecurityClassificationKey { get; }

        public CreateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg(string boxSecurityClassificationKey) {
            BoxSecurityClassificationKey = boxSecurityClassificationKey;
        }
    }
}