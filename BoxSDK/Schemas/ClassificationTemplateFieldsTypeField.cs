using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsTypeField>))]
    public enum ClassificationTemplateFieldsTypeField {
        [Description("enum")]
        Enum
    }
}