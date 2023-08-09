using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WorkflowMiniTypeField>))]
    public enum WorkflowMiniTypeField {
        [Description("workflow")]
        Workflow
    }
}