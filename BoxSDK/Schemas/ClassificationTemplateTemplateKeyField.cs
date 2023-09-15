using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateTemplateKeyField>))]
    public enum ClassificationTemplateTemplateKeyField {
        [Description("securityClassification-6VMVochwUWo")]
        SecurityClassification6VmVochwUWo
    }
}