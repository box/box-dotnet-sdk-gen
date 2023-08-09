using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullLockFieldTypeField>))]
    public enum FileFullLockFieldTypeField {
        [Description("lock")]
        Lock
    }
}