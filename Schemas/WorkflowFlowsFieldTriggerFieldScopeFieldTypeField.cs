using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsFieldTriggerFieldScopeFieldTypeField>))]
    public enum WorkflowFlowsFieldTriggerFieldScopeFieldTypeField {
        [Description("trigger_scope")]
        TriggerScope
    }
}