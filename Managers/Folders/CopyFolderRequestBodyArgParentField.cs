using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CopyFolderRequestBodyArgParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public CopyFolderRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}