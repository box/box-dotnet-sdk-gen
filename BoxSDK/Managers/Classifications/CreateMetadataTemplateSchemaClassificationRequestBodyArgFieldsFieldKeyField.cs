using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldKeyField>))]
    public enum CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldKeyField {
        [Description("Box__Security__Classification__Key")]
        BoxSecurityClassificationKey
    }
}