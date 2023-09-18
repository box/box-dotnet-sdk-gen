using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateDisplayNameField>))]
    public enum ClassificationTemplateDisplayNameField {
        [Description("Classification")]
        Classification
    }
}