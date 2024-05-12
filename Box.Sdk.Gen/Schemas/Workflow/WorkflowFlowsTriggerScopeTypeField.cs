using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsTriggerScopeTypeField>))]
    public enum WorkflowFlowsTriggerScopeTypeField {
        [Description("trigger_scope")]
        TriggerScope
    }
}