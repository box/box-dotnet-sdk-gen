using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateUserRequestBodyArgStatusField>))]
    public enum CreateUserRequestBodyArgStatusField {
        [Description("active")]
        Active,
        [Description("inactive")]
        Inactive,
        [Description("cannot_delete_edit")]
        CannotDeleteEdit,
        [Description("cannot_delete_edit_upload")]
        CannotDeleteEditUpload
    }
}