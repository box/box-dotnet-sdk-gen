using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsTriggerTypeField>))]
    public enum WorkflowFlowsTriggerTypeField {
        [Description("trigger")]
        Trigger
    }
}