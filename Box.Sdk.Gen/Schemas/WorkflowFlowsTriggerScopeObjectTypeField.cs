using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsTriggerScopeObjectTypeField>))]
    public enum WorkflowFlowsTriggerScopeObjectTypeField {
        [Description("folder")]
        Folder
    }
}