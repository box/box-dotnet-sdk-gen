using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsTriggerTriggerTypeField>))]
    public enum WorkflowFlowsTriggerTriggerTypeField {
        [Description("WORKFLOW_MANUAL_START")]
        WorkflowManualStart
    }
}