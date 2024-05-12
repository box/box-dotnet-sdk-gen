using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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