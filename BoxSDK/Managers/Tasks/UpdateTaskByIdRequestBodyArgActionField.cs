using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateTaskByIdRequestBodyArgActionField>))]
    public enum UpdateTaskByIdRequestBodyArgActionField {
        [Description("review")]
        Review,
        [Description("complete")]
        Complete
    }
}