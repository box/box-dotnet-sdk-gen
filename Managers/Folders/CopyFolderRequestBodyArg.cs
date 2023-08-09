using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CopyFolderRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("parent")]
        public CopyFolderRequestBodyArgParentField Parent { get; }

        public CopyFolderRequestBodyArg(string name, CopyFolderRequestBodyArgParentField parent) {
            Name = name;
            Parent = parent;
        }
    }
}