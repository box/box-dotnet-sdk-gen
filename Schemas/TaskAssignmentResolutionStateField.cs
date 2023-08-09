using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TaskAssignmentResolutionStateField>))]
    public enum TaskAssignmentResolutionStateField {
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