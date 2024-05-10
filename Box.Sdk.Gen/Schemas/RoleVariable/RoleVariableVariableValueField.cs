using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RoleVariableVariableValueField>))]
    public enum RoleVariableVariableValueField {
        [Description("editor")]
        Editor,
        [Description("viewer")]
        Viewer,
        [Description("previewer")]
        Previewer,
        [Description("uploader")]
        Uploader,
        [Description("previewer uploader")]
        PreviewerUploader,
        [Description("viewer uploader")]
        ViewerUploader,
        [Description("co-owner")]
        CoOwner
    }
}