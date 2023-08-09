using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateMetadataTemplateSchemaClassificationRequestBodyArgTemplateKeyField>))]
    public enum CreateMetadataTemplateSchemaClassificationRequestBodyArgTemplateKeyField {
        [Description("securityClassification-6VMVochwUWo")]
        SecurityClassification6VmVochwUWo
    }
}