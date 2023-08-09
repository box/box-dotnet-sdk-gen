using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullLockFieldAppTypeField>))]
    public enum FileFullLockFieldAppTypeField {
        [Description("gsuite")]
        Gsuite,
        [Description("office_wopi")]
        OfficeWopi,
        [Description("office_wopiplus")]
        OfficeWopiplus,
        [Description("other")]
        Other
    }
}