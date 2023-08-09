using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTaskRequestBodyArgActionField>))]
    public enum CreateTaskRequestBodyArgActionField {
        [Description("review")]
        Review,
        [Description("complete")]
        Complete
    }
}