using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<PostOAuth2TokenBoxSubjectTypeField>))]
    public enum PostOAuth2TokenBoxSubjectTypeField {
        [Description("enterprise")]
        Enterprise,
        [Description("user")]
        User
    }
}