using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderFolderUploadEmailAccessField>))]
    public enum FolderFolderUploadEmailAccessField {
        [Description("open")]
        Open,
        [Description("collaborators")]
        Collaborators
    }
}