using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum UserStatusField {
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