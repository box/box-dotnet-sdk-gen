using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<StartWorkflowRequestBodyFilesTypeField>))]
    public enum StartWorkflowRequestBodyFilesTypeField {
        [Description("file")]
        File
    }
}