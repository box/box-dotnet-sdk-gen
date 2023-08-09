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
    public class UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItem {
        [JsonPropertyName("op")]
        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemOpField Op { get; }

        [JsonPropertyName("path")]
        public string Path { get; }

        [JsonPropertyName("value")]
        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField Value { get; }

        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItem(UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemOpField op, string path, UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField value) {
            Op = op;
            Path = path;
            Value = value;
        }
    }
}