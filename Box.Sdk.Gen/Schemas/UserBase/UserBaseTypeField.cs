using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UserBaseTypeField>))]
    public enum UserBaseTypeField {
        [Description("user")]
        User
    }
}