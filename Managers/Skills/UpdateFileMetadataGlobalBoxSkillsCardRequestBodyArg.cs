using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArg {
        [JsonPropertyName("op")]
        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgOpField Op { get; }

        [JsonPropertyName("path")]
        public string Path { get; }

        [JsonPropertyName("value")]
        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgValueField Value { get; }

        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArg(UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgOpField op, string path, UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgValueField value) {
            Op = op;
            Path = path;
            Value = value;
        }
    }
}