using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsFieldTriggerFieldTriggerTypeField>))]
    public enum WorkflowFlowsFieldTriggerFieldTriggerTypeField {
        [Description("WORKFLOW_MANUAL_START")]
        WorkflowManualStart
    }
}