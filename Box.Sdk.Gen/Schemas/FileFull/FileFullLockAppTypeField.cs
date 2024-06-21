using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum FileFullLockAppTypeField {
        [Description("gsuite")]
        Gsuite,
        [Description("office_wopi")]
        OfficeWopi,
        [Description("office_wopiplus")]
        OfficeWopiplus,
        [Description("other")]
        Other
    }
}