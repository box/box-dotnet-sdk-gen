using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFileByIdRequestBodyLockAccessField>))]
    public enum UpdateFileByIdRequestBodyLockAccessField {
        [Description("lock")]
        Lock
    }
}