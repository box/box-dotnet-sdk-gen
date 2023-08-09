using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsFieldOutcomesFieldTypeField>))]
    public enum WorkflowFlowsFieldOutcomesFieldTypeField {
        [Description("outcome")]
        Outcome
    }
}