using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateClassificationTemplateRequestBodyArgTemplateKeyField>))]
    public enum CreateClassificationTemplateRequestBodyArgTemplateKeyField {
        [Description("securityClassification-6VMVochwUWo")]
        SecurityClassification6VmVochwUWo
    }
}