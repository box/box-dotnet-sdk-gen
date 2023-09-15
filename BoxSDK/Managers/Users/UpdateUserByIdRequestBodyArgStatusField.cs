using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateUserByIdRequestBodyArgStatusField>))]
    public enum UpdateUserByIdRequestBodyArgStatusField {
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