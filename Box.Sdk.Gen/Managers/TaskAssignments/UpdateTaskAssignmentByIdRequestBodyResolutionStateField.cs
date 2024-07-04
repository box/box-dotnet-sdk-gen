using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public enum UpdateTaskAssignmentByIdRequestBodyResolutionStateField {
        [Description("completed")]
        Completed,
        [Description("incomplete")]
        Incomplete,
        [Description("approved")]
        Approved,
        [Description("rejected")]
        Rejected
    }
}