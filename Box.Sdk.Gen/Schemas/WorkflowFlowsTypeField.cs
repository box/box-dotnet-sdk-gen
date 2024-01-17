using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsTypeField>))]
    public enum WorkflowFlowsTypeField {
        [Description("flow")]
        Flow
    }
}