using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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