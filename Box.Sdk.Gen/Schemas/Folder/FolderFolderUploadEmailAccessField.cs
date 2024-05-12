using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderFolderUploadEmailAccessField>))]
    public enum FolderFolderUploadEmailAccessField {
        [Description("open")]
        Open,
        [Description("collaborators")]
        Collaborators
    }
}