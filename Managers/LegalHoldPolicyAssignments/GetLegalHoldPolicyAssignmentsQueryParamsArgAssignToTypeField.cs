using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetLegalHoldPolicyAssignmentsQueryParamsArgAssignToTypeField {
        [Description("file")]
        File,
        [Description("file_version")]
        FileVersion,
        [Description("folder")]
        Folder,
        [Description("user")]
        User
    }
}