using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
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