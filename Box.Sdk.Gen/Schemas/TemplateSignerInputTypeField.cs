using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TemplateSignerInputTypeField>))]
    public enum TemplateSignerInputTypeField {
        [Description("signature")]
        Signature,
        [Description("date")]
        Date,
        [Description("text")]
        Text,
        [Description("checkbox")]
        Checkbox,
        [Description("attachment")]
        Attachment,
        [Description("radio")]
        Radio,
        [Description("dropdown")]
        Dropdown
    }
}