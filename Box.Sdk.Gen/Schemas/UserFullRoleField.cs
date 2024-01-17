using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UserFullRoleField>))]
    public enum UserFullRoleField {
        [Description("admin")]
        Admin,
        [Description("coadmin")]
        Coadmin,
        [Description("user")]
        User
    }
}