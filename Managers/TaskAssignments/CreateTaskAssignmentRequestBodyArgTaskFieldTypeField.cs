using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTaskAssignmentRequestBodyArgTaskFieldTypeField>))]
    public enum CreateTaskAssignmentRequestBodyArgTaskFieldTypeField {
        [Description("task")]
        Task
    }
}