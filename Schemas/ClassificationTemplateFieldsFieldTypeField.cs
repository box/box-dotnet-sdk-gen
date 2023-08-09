using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsFieldTypeField>))]
    public enum ClassificationTemplateFieldsFieldTypeField {
        [Description("enum")]
        Enum
    }
}