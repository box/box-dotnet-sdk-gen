using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullLockTypeField>))]
    public enum FileFullLockTypeField {
        [Description("lock")]
        Lock
    }
}