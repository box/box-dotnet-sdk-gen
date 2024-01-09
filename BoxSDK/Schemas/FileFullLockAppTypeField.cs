using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullLockAppTypeField>))]
    public enum FileFullLockAppTypeField {
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