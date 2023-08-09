using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateFolderRequestBodyArgFolderUploadEmailFieldAccessField>))]
    public enum CreateFolderRequestBodyArgFolderUploadEmailFieldAccessField {
        [Description("open")]
        Open,
        [Description("collaborators")]
        Collaborators
    }
}