using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsFieldOutcomesFieldIfRejectedFieldTypeField>))]
    public enum WorkflowFlowsFieldOutcomesFieldIfRejectedFieldTypeField {
        [Description("outcome")]
        Outcome
    }
}