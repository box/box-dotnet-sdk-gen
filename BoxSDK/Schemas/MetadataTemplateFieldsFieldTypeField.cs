using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataTemplateFieldsFieldTypeField>))]
    public enum MetadataTemplateFieldsFieldTypeField {
        [Description("string")]
        String,
        [Description("float")]
        Float,
        [Description("date")]
        Date,
        [Description("enum")]
        Enum,
        [Description("multiSelect")]
        MultiSelect,
        [Description("integer")]
        Integer
    }
}