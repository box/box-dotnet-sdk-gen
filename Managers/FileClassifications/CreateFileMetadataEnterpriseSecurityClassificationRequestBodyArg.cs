using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileMetadataEnterpriseSecurityClassificationRequestBodyArg {
        [JsonPropertyName("Box__Security__Classification__Key")]
        public string BoxSecurityClassificationKey { get; }

        public CreateFileMetadataEnterpriseSecurityClassificationRequestBodyArg(string boxSecurityClassificationKey) {
            BoxSecurityClassificationKey = boxSecurityClassificationKey;
        }
    }
}