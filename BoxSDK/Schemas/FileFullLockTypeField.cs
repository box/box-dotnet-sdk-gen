using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullLockTypeField>))]
    public enum FileFullLockTypeField {
        [Description("lock")]
        Lock
    }
}