using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderByIdRequestBodyArgCollectionsField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        public UpdateFolderByIdRequestBodyArgCollectionsField(string id, string type) {
            Id = id;
            Type = type;
        }
    }
}