using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateCollaborationRequestBodyArgItemFieldTypeField>))]
    public enum CreateCollaborationRequestBodyArgItemFieldTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}