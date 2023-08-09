using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateCommentRequestBodyArgItemFieldTypeField>))]
    public enum CreateCommentRequestBodyArgItemFieldTypeField {
        [Description("file")]
        File,
        [Description("comment")]
        Comment
    }
}