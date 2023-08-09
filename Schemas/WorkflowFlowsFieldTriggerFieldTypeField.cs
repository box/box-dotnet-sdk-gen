using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsFieldTriggerFieldTypeField>))]
    public enum WorkflowFlowsFieldTriggerFieldTypeField {
        [Description("trigger")]
        Trigger
    }
}