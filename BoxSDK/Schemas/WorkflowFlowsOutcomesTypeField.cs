using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsOutcomesTypeField>))]
    public enum WorkflowFlowsOutcomesTypeField {
        [Description("outcome")]
        Outcome
    }
}