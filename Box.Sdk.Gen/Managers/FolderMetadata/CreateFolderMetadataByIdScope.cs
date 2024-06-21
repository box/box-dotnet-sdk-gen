using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public enum CreateFolderMetadataByIdScope {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise
    }
}