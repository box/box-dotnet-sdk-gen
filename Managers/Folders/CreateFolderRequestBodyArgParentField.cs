using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderRequestBodyArgParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateFolderRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}