using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationRoleField>))]
    public enum CollaborationRoleField {
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
        CoOwner,
        [Description("owner")]
        Owner
    }
}