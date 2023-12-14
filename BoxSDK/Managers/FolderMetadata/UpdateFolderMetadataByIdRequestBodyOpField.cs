using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFolderMetadataByIdRequestBodyOpField>))]
    public enum UpdateFolderMetadataByIdRequestBodyOpField {
        [Description("add")]
        Add,
        [Description("replace")]
        Replace,
        [Description("remove")]
        Remove,
        [Description("test")]
        Test,
        [Description("move")]
        Move,
        [Description("copy")]
        Copy
    }
}