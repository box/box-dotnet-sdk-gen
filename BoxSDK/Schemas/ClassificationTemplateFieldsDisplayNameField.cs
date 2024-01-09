using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsDisplayNameField>))]
    public enum ClassificationTemplateFieldsDisplayNameField {
        [Description("Classification")]
        Classification
    }
}