using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TaskTypeField>))]
    public enum TaskTypeField {
        [Description("task")]
        Task
    }
}