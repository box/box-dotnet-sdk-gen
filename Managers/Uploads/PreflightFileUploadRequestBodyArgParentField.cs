using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class PreflightFileUploadRequestBodyArgParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public PreflightFileUploadRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}