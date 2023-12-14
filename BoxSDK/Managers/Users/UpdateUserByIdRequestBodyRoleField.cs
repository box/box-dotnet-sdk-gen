using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateUserByIdRequestBodyRoleField>))]
    public enum UpdateUserByIdRequestBodyRoleField {
        [Description("coadmin")]
        Coadmin,
        [Description("user")]
        User
    }
}