using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsTriggerScopeTypeField>))]
    public enum WorkflowFlowsTriggerScopeTypeField {
        [Description("trigger_scope")]
        TriggerScope
    }
}