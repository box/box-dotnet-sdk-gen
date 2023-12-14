using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsOutcomesIfRejectedTypeField>))]
    public enum WorkflowFlowsOutcomesIfRejectedTypeField {
        [Description("outcome")]
        Outcome
    }
}