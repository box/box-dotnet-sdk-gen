using System.ComponentModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public enum CreateTaskRequestBodyCompletionRuleField {
        [Description("all_assignees")]
        AllAssignees,
        [Description("any_assignee")]
        AnyAssignee
    }
}