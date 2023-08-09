using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class PreflightFileUploadRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("size")]
        public int? Size { get; }

        [JsonPropertyName("parent")]
        public PreflightFileUploadRequestBodyArgParentField Parent { get; }

        public PreflightFileUploadRequestBodyArg(string name, int? size, PreflightFileUploadRequestBodyArgParentField parent) {
            Name = name;
            Size = size;
            Parent = parent;
        }
    }
}