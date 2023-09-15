using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTaskRequestBodyArgCompletionRuleField>))]
    public enum CreateTaskRequestBodyArgCompletionRuleField {
        [Description("all_assignees")]
        AllAssignees,
        [Description("any_assignee")]
        AnyAssignee
    }
}