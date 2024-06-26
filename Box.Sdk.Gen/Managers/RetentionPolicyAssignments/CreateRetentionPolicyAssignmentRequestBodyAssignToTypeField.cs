using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public enum CreateRetentionPolicyAssignmentRequestBodyAssignToTypeField {
        [Description("enterprise")]
        Enterprise,
        [Description("folder")]
        Folder,
        [Description("metadata_template")]
        MetadataTemplate
    }
}