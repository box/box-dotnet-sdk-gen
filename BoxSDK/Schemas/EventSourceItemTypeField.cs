using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<EventSourceItemTypeField>))]
    public enum EventSourceItemTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}