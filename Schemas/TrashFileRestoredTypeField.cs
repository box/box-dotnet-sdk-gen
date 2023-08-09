using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFileRestoredTypeField>))]
    public enum TrashFileRestoredTypeField {
        [Description("file")]
        File
    }
}