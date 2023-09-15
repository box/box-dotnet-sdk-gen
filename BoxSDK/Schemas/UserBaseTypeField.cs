using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UserBaseTypeField>))]
    public enum UserBaseTypeField {
        [Description("user")]
        User
    }
}