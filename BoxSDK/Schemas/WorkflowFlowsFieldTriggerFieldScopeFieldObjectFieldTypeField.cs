using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsFieldTriggerFieldScopeFieldObjectFieldTypeField>))]
    public enum WorkflowFlowsFieldTriggerFieldScopeFieldObjectFieldTypeField {
        [Description("folder")]
        Folder
    }
}