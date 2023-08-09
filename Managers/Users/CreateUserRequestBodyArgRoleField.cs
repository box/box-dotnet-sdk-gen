using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateUserRequestBodyArgRoleField>))]
    public enum CreateUserRequestBodyArgRoleField {
        [Description("coadmin")]
        Coadmin,
        [Description("user")]
        User
    }
}