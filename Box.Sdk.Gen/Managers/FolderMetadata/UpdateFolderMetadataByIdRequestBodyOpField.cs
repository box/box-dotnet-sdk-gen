using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public enum UpdateFolderMetadataByIdRequestBodyOpField {
        [Description("add")]
        Add,
        [Description("replace")]
        Replace,
        [Description("remove")]
        Remove,
        [Description("test")]
        Test,
        [Description("move")]
        Move,
        [Description("copy")]
        Copy
    }
}