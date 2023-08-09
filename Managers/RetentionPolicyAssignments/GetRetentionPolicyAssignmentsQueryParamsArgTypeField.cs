using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetRetentionPolicyAssignmentsQueryParamsArgTypeField {
        [Description("folder")]
        Folder,
        [Description("enterprise")]
        Enterprise,
        [Description("metadata_template")]
        MetadataTemplate
    }
}