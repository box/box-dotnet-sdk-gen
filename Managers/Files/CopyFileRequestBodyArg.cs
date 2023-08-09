using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CopyFileRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("version")]
        public string Version { get; }

        [JsonPropertyName("parent")]
        public CopyFileRequestBodyArgParentField Parent { get; }

        public CopyFileRequestBodyArg(string name, string version, CopyFileRequestBodyArgParentField parent) {
            Name = name;
            Version = version;
            Parent = parent;
        }
    }
}