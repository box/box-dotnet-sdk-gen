using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataTemplateFieldsTypeField>))]
    public enum MetadataTemplateFieldsTypeField {
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