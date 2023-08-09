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
    public class UpdateSkillInvocationByIdRequestBodyArg {
        [JsonPropertyName("status")]
        public UpdateSkillInvocationByIdRequestBodyArgStatusField Status { get; }

        [JsonPropertyName("metadata")]
        public UpdateSkillInvocationByIdRequestBodyArgMetadataField Metadata { get; }

        [JsonPropertyName("file")]
        public UpdateSkillInvocationByIdRequestBodyArgFileField File { get; }

        [JsonPropertyName("file_version")]
        public UpdateSkillInvocationByIdRequestBodyArgFileVersionField FileVersion { get; }

        [JsonPropertyName("usage")]
        public UpdateSkillInvocationByIdRequestBodyArgUsageField Usage { get; }

        public UpdateSkillInvocationByIdRequestBodyArg(UpdateSkillInvocationByIdRequestBodyArgStatusField status, UpdateSkillInvocationByIdRequestBodyArgMetadataField metadata, UpdateSkillInvocationByIdRequestBodyArgFileField file, UpdateSkillInvocationByIdRequestBodyArgFileVersionField fileVersion, UpdateSkillInvocationByIdRequestBodyArgUsageField usage) {
            Status = status;
            Metadata = metadata;
            File = file;
            FileVersion = fileVersion;
            Usage = usage;
        }
    }
}