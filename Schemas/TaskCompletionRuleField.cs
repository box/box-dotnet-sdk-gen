using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TaskCompletionRuleField>))]
    public enum TaskCompletionRuleField {
        [Description("all_assignees")]
        AllAssignees,
        [Description("any_assignee")]
        AnyAssignee
    }
}