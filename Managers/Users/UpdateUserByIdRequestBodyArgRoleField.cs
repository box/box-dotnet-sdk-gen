using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateUserByIdRequestBodyArgRoleField>))]
    public enum UpdateUserByIdRequestBodyArgRoleField {
        [Description("coadmin")]
        Coadmin,
        [Description("user")]
        User
    }
}