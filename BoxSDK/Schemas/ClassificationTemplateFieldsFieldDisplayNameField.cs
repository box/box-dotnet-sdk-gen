using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsFieldDisplayNameField>))]
    public enum ClassificationTemplateFieldsFieldDisplayNameField {
        [Description("Classification")]
        Classification
    }
}