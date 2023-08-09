using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFileTypeField>))]
    public enum TrashFileTypeField {
        [Description("file")]
        File
    }
}