using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsDisplayNameField>))]
    public enum ClassificationTemplateFieldsDisplayNameField {
        [Description("Classification")]
        Classification
    }
}