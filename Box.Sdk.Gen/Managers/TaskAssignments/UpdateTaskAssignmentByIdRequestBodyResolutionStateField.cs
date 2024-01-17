using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateTaskAssignmentByIdRequestBodyResolutionStateField>))]
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