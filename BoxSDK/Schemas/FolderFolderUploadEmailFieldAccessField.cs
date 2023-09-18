using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderFolderUploadEmailFieldAccessField>))]
    public enum FolderFolderUploadEmailFieldAccessField {
        [Description("open")]
        Open,
        [Description("collaborators")]
        Collaborators
    }
}