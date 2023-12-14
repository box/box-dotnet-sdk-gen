using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateCollaborationRequestBodyAccessibleByTypeField>))]
    public enum CreateCollaborationRequestBodyAccessibleByTypeField {
        [Description("user")]
        User,
        [Description("group")]
        Group
    }
}