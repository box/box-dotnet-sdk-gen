using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateDisplayNameField>))]
    public enum ClassificationTemplateDisplayNameField {
        [Description("Classification")]
        Classification
    }
}