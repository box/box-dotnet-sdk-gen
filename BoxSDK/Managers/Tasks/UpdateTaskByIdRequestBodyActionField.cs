using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateTaskByIdRequestBodyActionField>))]
    public enum UpdateTaskByIdRequestBodyActionField {
        [Description("review")]
        Review,
        [Description("complete")]
        Complete
    }
}