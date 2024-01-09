using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsTriggerScopeObjectTypeField>))]
    public enum WorkflowFlowsTriggerScopeObjectTypeField {
        [Description("folder")]
        Folder
    }
}