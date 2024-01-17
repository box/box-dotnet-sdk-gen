using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TaskActionField>))]
    public enum TaskActionField {
        [Description("review")]
        Review,
        [Description("complete")]
        Complete
    }
}