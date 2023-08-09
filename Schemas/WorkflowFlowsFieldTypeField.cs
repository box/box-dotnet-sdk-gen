using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsFieldTypeField>))]
    public enum WorkflowFlowsFieldTypeField {
        [Description("flow")]
        Flow
    }
}