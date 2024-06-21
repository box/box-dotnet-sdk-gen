using System.ComponentModel;

namespace Box.Sdk.Gen.Schemas {
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