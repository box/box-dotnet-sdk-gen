using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CommentBaseTypeField>))]
    public enum CommentBaseTypeField {
        [Description("comment")]
        Comment
    }
}