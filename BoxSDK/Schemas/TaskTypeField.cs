using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TaskTypeField>))]
    public enum TaskTypeField {
        [Description("task")]
        Task
    }
}