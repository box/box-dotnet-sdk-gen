using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
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
        [Description("radio")]
        Radio,
        [Description("dropdown")]
        Dropdown
    }
}