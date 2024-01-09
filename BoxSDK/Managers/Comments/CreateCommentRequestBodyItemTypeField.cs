using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateCommentRequestBodyItemTypeField>))]
    public enum CreateCommentRequestBodyItemTypeField {
        [Description("file")]
        File,
        [Description("comment")]
        Comment
    }
}