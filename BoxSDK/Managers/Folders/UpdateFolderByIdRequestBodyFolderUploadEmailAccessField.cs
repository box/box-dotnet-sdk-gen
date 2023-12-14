using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFolderByIdRequestBodyFolderUploadEmailAccessField>))]
    public enum UpdateFolderByIdRequestBodyFolderUploadEmailAccessField {
        [Description("open")]
        Open,
        [Description("collaborators")]
        Collaborators
    }
}